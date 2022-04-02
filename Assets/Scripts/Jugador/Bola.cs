using Escenario;
using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    //https://www.youtube.com/watch?v=rHM9bDgT2zQ
    public class Bola : MonoBehaviourPunCallbacks
    {
        [HideInInspector] public Player photonJugador;
        [HideInInspector] public int id;

        private float angulo = 0;
        private float potencia = 0;
        private bool potenciaDecrecer = false;
        private int golpes = 0;

        [HideInInspector] public Vector3 ultimaPosicion;
        private LineRenderer linea;
        private Rigidbody cuerpo;

        private Vector3 camaraOffset;
        private Vector2 camaraMovimientoInput;
        private float camaraZoom;
        private float camaraZoomInput;

        private Controles controles;

        public static Bola instancia;

        [PunRPC]
        public void Arranque(Player jugador)
        {
            photonJugador = jugador;
            id = jugador.ActorNumber;

            Configuracion.instancia.jugadores[id - 1] = this;

            //Color.Cambiar(gameObject, linea, color);

            if (photonView.IsMine == false)
            {
                cuerpo.isKinematic = true;
            }
        }

        public void Awake()
        {
            instancia = this;

            controles = new Controles();
            controles.Principal.Enable();

            linea = GetComponent<LineRenderer>();
            cuerpo = GetComponent<Rigidbody>();
            cuerpo.maxAngularVelocity = 1000;            
        }

        public void Start()
        {
            Objetos.instancia.sliderPotencia.maxValue = Configuracion.instancia.potenciaMaxima;

            //--------------------------------------------------------------------

            camaraOffset = Objetos.instancia.camara.gameObject.transform.position - gameObject.transform.position;
            ultimaPosicion = gameObject.transform.localPosition;

            //--------------------------------------------------------------------

            if (Configuracion.instancia.aleatorio == false)
            {
                camaraZoom = Partida.Cargar.CargarBolaZoom();
                angulo = Partida.Cargar.CargarBolaRotacion();
                golpes = Partida.Cargar.CargarBolaGolpes();
            }
            else
            {
                camaraZoom = Configuracion.instancia.zoomDefecto;
                angulo = 90;
            }

            Objetos.instancia.textoGolpes.text = string.Format("Golpes: {0}", golpes.ToString());

            //--------------------------------------------------------------------

            Configuracion.instancia.camaraModo = Configuracion.CamaraModos.Fija;
            Color.Cambiar(gameObject, linea, Atributos.instancia.color);
        }

        public void Update()
        {
            bool jugadorAsignado = false;

            if (PhotonNetwork.IsConnected == true)
            {
                if (photonView.IsMine == true)
                {
                    jugadorAsignado = true;
                }
            }
            else
            {
                jugadorAsignado = true;
            }

            if (Configuracion.instancia.poderMover == true && jugadorAsignado == true)
            {
                linea.enabled = true;

                Vector3 velocidad = cuerpo.velocity;

                if (velocidad.magnitude <= 0.001f)
                {
                    cuerpo.velocity = Vector3.zero;
                    cuerpo.angularVelocity = Vector3.zero;

                    linea.enabled = true;
                    ultimaPosicion = gameObject.transform.localPosition;
            
                    Partida.Guardar.GuardarMaestro(ultimaPosicion, angulo, golpes, camaraZoom, DateTime.Now, Configuracion.instancia.campo.id, Configuracion.instancia.nivel, Configuracion.instancia.numeroPartida);
                    Transparentar.Casillas(ultimaPosicion, Transparentar.CasillasMaterial.Transparente);

                    if (controles.Principal.BolaPotencia.phase == InputActionPhase.Performed)
                    {
                        if (potenciaDecrecer == false)
                        {
                            if (potencia <= Configuracion.instancia.potenciaMaxima)
                            {
                                potencia += 0.1f;
                            }
                            else
                            {
                                potencia = Configuracion.instancia.potenciaMaxima;
                                potenciaDecrecer = true;
                            }
                        }
                        else if (potenciaDecrecer == true)
                        {
                            if (potencia >= 0)
                            {
                                potencia -= 0.1f;
                            }
                            else
                            {
                                potencia = 0;
                                potenciaDecrecer = false;
                            }
                        }
                    }
                    else
                    {
                        if (potencia != 0)
                        {
                            if (Configuracion.instancia.palos == Configuracion.Palos.Madera)
                            {
                                cuerpo.AddForce(Quaternion.Euler(0, angulo, 0) * Vector3.up * (potencia * 2), ForceMode.Impulse);
                                cuerpo.AddForce(Quaternion.Euler(0, angulo, 0) * Vector3.forward * (potencia * 2), ForceMode.Impulse);
                            }
                            else
                            {
                                cuerpo.AddForce(Quaternion.Euler(0, angulo, 0) * Vector3.forward * potencia, ForceMode.Impulse);
                            }

                            potencia = 0;

                            golpes += 1;
                            Objetos.instancia.textoGolpes.text = string.Format("Golpes: {0}", golpes.ToString());
                        }
                    }

                    Objetos.instancia.sliderPotencia.value = potencia;

                    if (potencia == 0)
                    {
                        Objetos.instancia.sliderPotencia.gameObject.SetActive(false);
                    }
                    else
                    {
                        Objetos.instancia.sliderPotencia.gameObject.SetActive(true);
                    }

                    //--------------------------------------------------------

                    if (controles.Principal.BolaRotarIzquierda.phase == InputActionPhase.Performed)
                    {
                        angulo -= Time.deltaTime * Configuracion.instancia.anguloVelocidad;
                    }

                    
                    if (controles.Principal.BolaRotarDerecha.phase == InputActionPhase.Performed)
                    {
                        angulo += Time.deltaTime * Configuracion.instancia.anguloVelocidad;
                    }

                    //--------------------------------------------------------

                    linea.SetPosition(0, gameObject.transform.position);
                    linea.SetPosition(1, gameObject.transform.position + Quaternion.Euler(0, angulo, 0) * Vector3.forward * (Configuracion.instancia.lineaLongitud + potencia / 4));
                }
                else
                {
                    linea.enabled = false;

                    if (gameObject.transform.localPosition.y <= -5f)
                    {
                        gameObject.transform.localPosition = ultimaPosicion;
                        cuerpo.velocity = Vector3.zero;
                        cuerpo.angularVelocity = Vector3.zero;
                    }

                    Transparentar.Casillas(ultimaPosicion, Transparentar.CasillasMaterial.Opaco);
                }
            }     
            else
            {
                linea.enabled = false;
            }
        }

        public void FixedUpdate()
        {
            bool jugadorAsignado = false;

            if (PhotonNetwork.IsConnected == true)
            {
                if (photonView.IsMine == true)
                {
                    jugadorAsignado = true;
                }
            }
            else
            {
                jugadorAsignado = true;
            }

            if (Configuracion.instancia.poderMover == true && jugadorAsignado == true)
            {
                if (Configuracion.instancia.camaraModo == Configuracion.CamaraModos.Libre)
                {
                    camaraMovimientoInput = controles.Principal.CamaraLibreMovimiento.ReadValue<Vector2>();

                    if (camaraMovimientoInput.x > 0 && camaraMovimientoInput.y == 0)
                    {
                        Objetos.instancia.camara.transform.Translate(new Vector3(Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0, 0));
                    }
                    else if (camaraMovimientoInput.x < 0 && camaraMovimientoInput.y == 0)
                    {
                        Objetos.instancia.camara.transform.Translate(new Vector3(-Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0, 0));
                    }
                    else if (camaraMovimientoInput.x == 0 && camaraMovimientoInput.y > 0)
                    {
                        Objetos.instancia.camara.transform.Translate(new Vector3(0, Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0));
                    }
                    else if (camaraMovimientoInput.x == 0 && camaraMovimientoInput.y < 0)
                    {
                        Objetos.instancia.camara.transform.Translate(new Vector3(0, -Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0));
                    }

                    Objetos.instancia.camara.transform.position = new Vector3(Objetos.instancia.camara.transform.position.x, 60, Objetos.instancia.camara.transform.position.z);              
                }
                else if (Configuracion.instancia.camaraModo == Configuracion.CamaraModos.Fija)
                {
                    Vector3 posicion = transform.position + camaraOffset;
                    posicion.x -= Configuracion.instancia.rotacionCamaraX + (transform.position.y - 1f) / 2;
                    posicion.y = 60;
                    posicion.z -= Configuracion.instancia.rotacionCamaraZ + (transform.position.y - 1f) / 2;

                    Objetos.instancia.camara.transform.position = posicion;
                }

                //------------------------------------

                Camera camara = Objetos.instancia.camara.GetComponent<Camera>();
                camara.orthographicSize = camaraZoom;

                camaraZoomInput = controles.Principal.CamaraZoom.ReadValue<float>();

                if (camaraZoomInput > 0)
                {
                    camaraZoomInput = 0.1f;
                }
                else if (camaraZoomInput < 0)
                {
                    camaraZoomInput = -0.1f;
                }
                else
                {
                    camaraZoomInput = 0;
                }
   
                camara.orthographicSize = Mathf.Clamp(camara.orthographicSize -= camaraZoomInput * (10f * camara.orthographicSize * .1f), Configuracion.instancia.zoomCerca, Configuracion.instancia.zoomLejos);
                camaraZoom = camara.orthographicSize;
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
            Destroy(gameObject);
            Configuracion.instancia.NuevoNivel(Configuracion.instancia.nivel += 1);
        }

        public void CamaraModoInput(InputAction.CallbackContext contexto)
        {
            if (Configuracion.instancia.poderMover == true)
            {
                if (contexto.phase == InputActionPhase.Performed)
                {
                    if (Configuracion.instancia.camaraModo == Configuracion.CamaraModos.Fija)
                    {
                        Configuracion.instancia.camaraModo = Configuracion.CamaraModos.Libre;
                    }
                    else
                    {
                        Configuracion.instancia.camaraModo = Configuracion.CamaraModos.Fija;
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

