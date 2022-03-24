using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    //https://www.youtube.com/watch?v=rHM9bDgT2zQ
    public class Bola : MonoBehaviour
    {
        [HideInInspector] public int id;
        public Player photonJugador;

        private float angulo = 0;
        private float potencia = 0;
        private bool potenciaDecrecer = false;
        private int golpes = 0;

        private bool permitirPotencia;
        private bool permitirRotarIzquierda;
        private bool permitirRotarDerecha;

        [HideInInspector] public Vector3 ultimaPosicion;
        private LineRenderer linea;
        private Rigidbody cuerpo;

        private Vector3 camaraOffset;
        private Vector2 camaraMovimientoInput;
        private float camaraZoom;
        private float camaraZoomInput;

        public static Bola instancia;

        [PunRPC]
        public void Arranque(Player jugador)
        {
            photonJugador = jugador;
            id = jugador.ActorNumber;

            Configuracion.instancia.jugadores[id - 1] = this;
        }

        public void Awake()
        {
            instancia = this;

            instancia.linea = instancia.transform.GetChild(1).gameObject.GetComponent<LineRenderer>();
            instancia.cuerpo = instancia.transform.GetChild(1).gameObject.GetComponent<Rigidbody>();
            instancia.cuerpo.maxAngularVelocity = 1000;            
        }

        public void Start()
        {
            Objetos.instancia.sliderPotencia.maxValue = Configuracion.instancia.potenciaMaxima;

            //--------------------------------------------------------------------

            instancia.camaraOffset = instancia.transform.GetChild(0).gameObject.transform.position - instancia.transform.GetChild(1).gameObject.transform.position;
            instancia.ultimaPosicion = instancia.transform.GetChild(1).gameObject.transform.localPosition;

            //--------------------------------------------------------------------

            if (Configuracion.instancia.aleatorio == false)
            {
                instancia.camaraZoom = Partida.Cargar.CargarBolaZoom();
                instancia.angulo = Partida.Cargar.CargarBolaRotacion();
                instancia.golpes = Partida.Cargar.CargarBolaGolpes();
            }
            else
            {
                instancia.camaraZoom = Configuracion.instancia.zoomDefecto;
                instancia.angulo = 90;
            }

            Objetos.instancia.textoGolpes.text = string.Format("Golpes: {0}", instancia.golpes.ToString());
           
            //--------------------------------------------------------------------

            Renderer renderer = instancia.transform.GetChild(1).gameObject.GetComponent<Renderer>();
            renderer.material.shader = Shader.Find("HDRP/Lit");
            renderer.material.SetColor("_BaseColor", Configuracion.instancia.color);

            instancia.linea.material = new Material(Shader.Find("Sprites/Default"));
            Gradient gradiente = new Gradient();
            gradiente.SetKeys(
                new GradientColorKey[] { new GradientColorKey(Configuracion.instancia.color, 0.0f), new GradientColorKey(Configuracion.instancia.color, 1.0f) },
                new GradientAlphaKey[] { new GradientAlphaKey(0.5f, 0.0f), new GradientAlphaKey(0.5f, 1.0f) }
            );
            instancia.linea.colorGradient = gradiente;
        }

        public void Update()
        {
            if (Configuracion.instancia.poderMover == true)
            {
                instancia.linea.enabled = true;

                Vector3 velocidad = instancia.cuerpo.velocity;

                if (velocidad.magnitude <= 0.001f)
                {
                    instancia.cuerpo.velocity = Vector3.zero;
                    instancia.cuerpo.angularVelocity = Vector3.zero;

                    instancia.linea.enabled = true;
                    instancia.ultimaPosicion = instancia.transform.GetChild(1).gameObject.transform.localPosition;
            
                    Partida.Guardar.GuardarMaestro(instancia.ultimaPosicion, instancia.angulo, instancia.golpes, instancia.camaraZoom, DateTime.Now, Configuracion.instancia.campo.id, Configuracion.instancia.nivel, Configuracion.instancia.numeroPartida);
                    Transparentar.Casillas(instancia.ultimaPosicion, Transparentar.CasillasMaterial.Transparente);

                    if (instancia.permitirPotencia == true)
                    {
                        if (instancia.potenciaDecrecer == false)
                        {
                            if (instancia.potencia <= Configuracion.instancia.potenciaMaxima)
                            {
                                instancia.potencia += 0.1f;
                            }
                            else
                            {
                                instancia.potencia = Configuracion.instancia.potenciaMaxima;
                                instancia.potenciaDecrecer = true;
                            }
                        }
                        else if (instancia.potenciaDecrecer == true)
                        {
                            if (instancia.potencia >= 0)
                            {
                                instancia.potencia -= 0.1f;
                            }
                            else
                            {
                                instancia.potencia = 0;
                                instancia.potenciaDecrecer = false;
                            }
                        }
                    }
                    else
                    {
                        if (instancia.potencia != 0)
                        {
                            if (Configuracion.instancia.palos == Configuracion.Palos.Madera)
                            {
                                instancia.cuerpo.AddForce(Quaternion.Euler(0, instancia.angulo, 0) * Vector3.up * (instancia.potencia * 2), ForceMode.Impulse);
                                instancia.cuerpo.AddForce(Quaternion.Euler(0, instancia.angulo, 0) * Vector3.forward * (instancia.potencia * 2), ForceMode.Impulse);
                            }
                            else
                            {
                                instancia.cuerpo.AddForce(Quaternion.Euler(0, instancia.angulo, 0) * Vector3.forward * instancia.potencia, ForceMode.Impulse);
                            }

                            instancia.potencia = 0;

                            instancia.golpes += 1;
                            Objetos.instancia.textoGolpes.text = string.Format("Golpes: {0}", instancia.golpes.ToString());
                        }
                    }

                    Objetos.instancia.sliderPotencia.value = instancia.potencia;

                    if (instancia.potencia == 0)
                    {
                        Objetos.instancia.sliderPotencia.gameObject.SetActive(false);
                    }
                    else
                    {
                        Objetos.instancia.sliderPotencia.gameObject.SetActive(true);
                    }

                    //--------------------------------------------------------

                    if (instancia.permitirRotarIzquierda == true)
                    {
                        instancia.angulo -= Time.deltaTime * Configuracion.instancia.anguloVelocidad;
                    }

                    if (instancia.permitirRotarDerecha == true)
                    {
                        instancia.angulo += Time.deltaTime * Configuracion.instancia.anguloVelocidad;
                    }

                    //--------------------------------------------------------

                    instancia.linea.SetPosition(0, instancia.transform.GetChild(1).gameObject.transform.position);
                    instancia.linea.SetPosition(1, instancia.transform.GetChild(1).gameObject.transform.position + Quaternion.Euler(0, instancia.angulo, 0) * Vector3.forward * (Configuracion.instancia.lineaLongitud + instancia.potencia / 4));
                }
                else
                {
                    instancia.linea.enabled = false;

                    if (instancia.transform.GetChild(1).gameObject.transform.localPosition.y <= -5f)
                    {
                        instancia.transform.GetChild(1).gameObject.transform.localPosition = instancia.ultimaPosicion;
                        instancia.cuerpo.velocity = Vector3.zero;
                        instancia.cuerpo.angularVelocity = Vector3.zero;
                    }

                    Transparentar.Casillas(instancia.ultimaPosicion, Transparentar.CasillasMaterial.Opaco);
                }
            }     
            else
            {
                instancia.linea.enabled = false;
            }
        }

        public void FixedUpdate()
        {
            if (Configuracion.instancia.poderMover == true)
            {
                if (Configuracion.instancia.camara == Configuracion.CamaraModos.Libre)
                {
                    if (instancia.camaraMovimientoInput.x > 0 && instancia.camaraMovimientoInput.y == 0)
                    {
                        instancia.transform.GetChild(0).gameObject.transform.Translate(new Vector3(Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0, 0));
                    }
                    else if (instancia.camaraMovimientoInput.x < 0 && instancia.camaraMovimientoInput.y == 0)
                    {
                        instancia.transform.GetChild(0).gameObject.transform.Translate(new Vector3(-Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0, 0));
                    }
                    else if (instancia.camaraMovimientoInput.x == 0 && instancia.camaraMovimientoInput.y > 0)
                    {
                        instancia.transform.GetChild(0).gameObject.transform.Translate(new Vector3(0, Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0));
                    }
                    else if (instancia.camaraMovimientoInput.x == 0 && instancia.camaraMovimientoInput.y < 0)
                    {
                        instancia.transform.GetChild(0).gameObject.transform.Translate(new Vector3(0, -Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0));
                    }

                    instancia.transform.GetChild(0).gameObject.transform.position = new Vector3(instancia.transform.GetChild(0).gameObject.transform.position.x, 60, instancia.transform.GetChild(0).gameObject.transform.position.z);              
                }
                else if (Configuracion.instancia.camara == Configuracion.CamaraModos.Fija)
                {
                    Vector3 posicion = instancia.transform.GetChild(1).position + instancia.camaraOffset;
                    posicion.x -= Configuracion.instancia.rotacionCamaraX - (instancia.transform.GetChild(1).position.y - 1f) / 2;
                    posicion.y = 60;
                    posicion.z -= Configuracion.instancia.rotacionCamaraZ - (instancia.transform.GetChild(1).position.y - 1f) / 2;

                    instancia.transform.GetChild(0).gameObject.transform.position = posicion;
                }

                //------------------------------------

                Camera camara = instancia.transform.GetChild(0).gameObject.GetComponent<Camera>();
                camara.orthographicSize = instancia.camaraZoom;

                if (instancia.camaraZoomInput > 0)
                {
                    instancia.camaraZoomInput = 0.1f;
                }
                else if (instancia.camaraZoomInput < 0)
                {
                    instancia.camaraZoomInput = -0.1f;
                }
                else
                {
                    instancia.camaraZoomInput = 0;
                }
   
                camara.orthographicSize = Mathf.Clamp(camara.orthographicSize -= instancia.camaraZoomInput * (10f * camara.orthographicSize * .1f), Configuracion.instancia.zoomCerca, Configuracion.instancia.zoomLejos);
                instancia.camaraZoom = camara.orthographicSize;
            }
        }

        private void OnTriggerEnter(Collider colision)
        {
            if (colision.gameObject.name == "FondoHoyo")
            {
                StartCoroutine(TerminarHoyo());
            }
        }

        private void OnTriggerStay(Collider colision)
        {
            
        }

        private void OnTriggerExit(Collider colision)
        {
            if (colision.gameObject.name == "FondoHoyo")
            {
                StopCoroutine(TerminarHoyo());
            }           
        }

        IEnumerator TerminarHoyo()
        {            
            yield return new WaitForSeconds(5);
            Destroy(instancia.gameObject);
            Configuracion.instancia.NuevoNivel(Configuracion.instancia.nivel += 1);
        }

        public void PotenciaInput(InputAction.CallbackContext contexto)
        {
            if (Configuracion.instancia.poderMover == true)
            {
                if (contexto.phase == InputActionPhase.Performed)
                {
                    instancia.permitirPotencia = true;
                }
                else if (contexto.phase == InputActionPhase.Canceled)
                {
                    instancia.permitirPotencia = false;
                }
            }               
        }

        public void RotarIzquierdaInput(InputAction.CallbackContext contexto)
        {
            if (Configuracion.instancia.poderMover == true)
            {
                if (contexto.phase == InputActionPhase.Performed)
                {
                    instancia.permitirRotarIzquierda = true;
                }
                else if (contexto.phase == InputActionPhase.Canceled)
                {
                    instancia.permitirRotarIzquierda = false;
                }
            }                
        }

        public void RotarDerechaInput(InputAction.CallbackContext contexto)
        {
            if (Configuracion.instancia.poderMover == true)
            {
                if (contexto.phase == InputActionPhase.Performed)
                {
                    instancia.permitirRotarDerecha = true;
                }
                else if (contexto.phase == InputActionPhase.Canceled)
                {
                    instancia.permitirRotarDerecha = false;
                }
            }                
        }

        public void CamaraMovimientoInput(InputAction.CallbackContext contexto)
        {
            if (Configuracion.instancia.poderMover == true)
            {
                if (contexto.phase == InputActionPhase.Performed)
                {
                    instancia.camaraMovimientoInput = contexto.ReadValue<Vector2>();
                }
                else if (contexto.phase == InputActionPhase.Canceled)
                {
                    instancia.camaraMovimientoInput = Vector2.zero;
                }
            }                
        }

        public void CamaraZoomInput(InputAction.CallbackContext contexto)
        {
            if (Configuracion.instancia.poderMover == true)
            {
                if (contexto.phase == InputActionPhase.Performed)
                {
                    instancia.camaraZoomInput = contexto.ReadValue<float>();
                }
            }              
        }

        public void CamaraModoInput(InputAction.CallbackContext contexto)
        {
            if (Configuracion.instancia.poderMover == true)
            {
                if (contexto.phase == InputActionPhase.Performed)
                {
                    if (Configuracion.instancia.camara == Configuracion.CamaraModos.Fija)
                    {
                        Configuracion.instancia.camara = Configuracion.CamaraModos.Libre;
                    }
                    else
                    {
                        Configuracion.instancia.camara = Configuracion.CamaraModos.Fija;
                    }
                }
            }              
        }

        public void CambiarPaloInput(InputAction.CallbackContext contexto)
        {
            if (Configuracion.instancia.poderMover == true)
            {
                if (contexto.phase == InputActionPhase.Performed)
                {
                    if (Configuracion.instancia.palos == Configuracion.Palos.Madera)
                    {
                        Configuracion.instancia.palos = Configuracion.Palos.Hierro;
                    }
                    else
                    {
                        Configuracion.instancia.palos = Configuracion.Palos.Madera;
                    }
                  
                    Objetos.instancia.textoPalos.text = Configuracion.instancia.palos.ToString();
                }
            }              
        }

    }
}

