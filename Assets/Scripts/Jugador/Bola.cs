using Escenario.Generacion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    //https://www.youtube.com/watch?v=rHM9bDgT2zQ
    public class Bola : MonoBehaviour
    {       
        private float angulo = 0;
        private float potencia = 0;
        private bool potenciaDecrecer = false;
        private int golpes = 0;

        private bool permitirPotencia;
        private bool permitirRotarIzquierda;
        private bool permitirRotarDerecha;

        private Vector3 ultimaPosicion;
        private LineRenderer linea;
        private Rigidbody cuerpo;

        private Vector3 camaraOffset;
        private Vector2 camaraMovimientoInput;
        private float camaraZoomInput;

        public static Bola instancia;

        public void Awake()
        {
            instancia = this;

            instancia.linea = GetComponent<LineRenderer>();
            instancia.cuerpo = GetComponent<Rigidbody>();
            instancia.cuerpo.maxAngularVelocity = 1000;
            
            Objetos.instancia.sliderPotencia.maxValue = Configuracion.instancia.potenciaMaxima;
        }

        public void Start()
        {
            instancia.camaraOffset = Objetos.instancia.camara.transform.position - instancia.transform.position;

            //--------------------------------------------------------------------

            instancia.angulo = 90;

            if (Configuracion.instancia.aleatorio == false)
            {
                instancia.angulo = Partida.Cargar.CargarBolaRotacion();
            }

            //--------------------------------------------------------------------

            Renderer renderer = instancia.GetComponent<Renderer>();
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
            Vector3 velocidad = instancia.cuerpo.velocity;

            if (velocidad.magnitude <= 0.001f)
            {
                instancia.cuerpo.velocity = Vector3.zero;
                instancia.cuerpo.angularVelocity = Vector3.zero;

                instancia.linea.enabled = true;
                instancia.ultimaPosicion = transform.localPosition;

                Partida.Guardar.GuardarBola(instancia.ultimaPosicion, instancia.angulo);
                CasillasCambiarMaterial(instancia.ultimaPosicion, instancia.angulo, CasillasMaterial.Transparente);

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

                instancia.linea.SetPosition(0, instancia.transform.position);
                instancia.linea.SetPosition(1, instancia.transform.position + Quaternion.Euler(0, instancia.angulo, 0) * Vector3.forward * (Configuracion.instancia.lineaLongitud + instancia.potencia / 4));           
            }
            else
            {
                instancia.linea.enabled = false;

                if (transform.localPosition.y <= -5f)
                {
                    transform.localPosition = instancia.ultimaPosicion;
                    instancia.cuerpo.velocity = Vector3.zero;
                    instancia.cuerpo.angularVelocity = Vector3.zero;
                }

                CasillasCambiarMaterial(instancia.ultimaPosicion, instancia.angulo, CasillasMaterial.Opaco);
            }
        }

        public void FixedUpdate()
        {
            if (Configuracion.instancia.camara == Configuracion.CamaraModos.Libre)
            {
                if (instancia.camaraMovimientoInput.x > 0 && instancia.camaraMovimientoInput.y == 0)
                {
                    Objetos.instancia.camara.transform.Translate(new Vector3(Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0, 0));
                }
                else if (instancia.camaraMovimientoInput.x < 0 && instancia.camaraMovimientoInput.y == 0)
                {
                    Objetos.instancia.camara.transform.Translate(new Vector3(-Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0, 0));
                }
                else if (instancia.camaraMovimientoInput.x == 0 && instancia.camaraMovimientoInput.y > 0)
                {
                    Objetos.instancia.camara.transform.Translate(new Vector3(0, Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0));
                }
                else if (instancia.camaraMovimientoInput.x == 0 && instancia.camaraMovimientoInput.y < 0)
                {
                    Objetos.instancia.camara.transform.Translate(new Vector3(0, -Configuracion.instancia.velocidadLibre * Time.deltaTime * 10, 0));
                }

                Objetos.instancia.camara.transform.position = new Vector3(Objetos.instancia.camara.transform.position.x, 60, Objetos.instancia.camara.transform.position.z);
            }
            else if (Configuracion.instancia.camara == Configuracion.CamaraModos.Fija)
            {
                Vector3 posicion = instancia.transform.position + instancia.camaraOffset;
                posicion.x -= 41.7f - (instancia.transform.position.y - 1f) / 2;
                posicion.y = 60;
                posicion.z -= 41.7f - (instancia.transform.position.y - 1f) / 2;
                Objetos.instancia.camara.transform.position = posicion;
            }

            //------------------------------------

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

            Camera objeto = Objetos.instancia.camara.GetComponent<Camera>();
            objeto.orthographicSize = Mathf.Clamp(objeto.orthographicSize -= instancia.camaraZoomInput * (10f * objeto.orthographicSize * .1f), Configuracion.instancia.zoomCerca, Configuracion.instancia.zoomLejos);
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
            if (contexto.phase == InputActionPhase.Performed)
            {
                instancia.permitirPotencia = true;
            }
            else if (contexto.phase == InputActionPhase.Canceled)
            {
                instancia.permitirPotencia = false;
            }
        }

        public void RotarIzquierdaInput(InputAction.CallbackContext contexto)
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

        public void RotarDerechaInput(InputAction.CallbackContext contexto)
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

        public void CamaraMovimientoInput(InputAction.CallbackContext contexto)
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

        public void CamaraZoomInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                instancia.camaraZoomInput = contexto.ReadValue<float>();
            }
        }

        public void CamaraModoInput(InputAction.CallbackContext contexto)
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

        public void CambiarPaloInput(InputAction.CallbackContext contexto)
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


        private enum CasillasMaterial { Transparente, Opaco }

        private void CasillasCambiarMaterial(Vector3 posicionBola, float anguloBola, CasillasMaterial materialElegido)
        {
            if (posicionBola != null)
            {
                bool borrar = false;
                List<Vector2> posiciones = new List<Vector2>();
                Debug.Log(anguloBola);
                if (materialElegido == CasillasMaterial.Transparente)
                {
                    posiciones.Add(new Vector2((int)posicionBola.x, (int)posicionBola.z));

                    if (anguloBola >= -20 && anguloBola <= 20)
                    {
                        posiciones.Add(new Vector2((int)posicionBola.x - 1, (int)posicionBola.z));
                        posiciones.Add(new Vector2((int)posicionBola.x + 1, (int)posicionBola.z));
                        posiciones.Add(new Vector2((int)posicionBola.x, (int)posicionBola.z + 1));
                        posiciones.Add(new Vector2((int)posicionBola.x - 1, (int)posicionBola.z + 1));
                        posiciones.Add(new Vector2((int)posicionBola.x + 1, (int)posicionBola.z + 1));
                        posiciones.Add(new Vector2((int)posicionBola.x, (int)posicionBola.z + 2));
                        posiciones.Add(new Vector2((int)posicionBola.x - 1, (int)posicionBola.z + 2));
                        posiciones.Add(new Vector2((int)posicionBola.x + 1, (int)posicionBola.z + 2));
                    }
                    else if (anguloBola >= 21 && anguloBola <= 75)
                    {
                        
                    }
                    else
                    {
                        borrar = true;
                    }
                }
                else if (materialElegido == CasillasMaterial.Opaco)
                {
                    borrar = true;
                }

                if (borrar == true)
                {
                    posiciones.Add(new Vector2((int)posicionBola.x, (int)posicionBola.z));
                    posiciones.Add(new Vector2((int)posicionBola.x - 1, (int)posicionBola.z));
                    posiciones.Add(new Vector2((int)posicionBola.x - 1, (int)posicionBola.z - 1));
                    posiciones.Add(new Vector2((int)posicionBola.x, (int)posicionBola.z - 1));
                    posiciones.Add(new Vector2((int)posicionBola.x + 1, (int)posicionBola.z - 1));
                    posiciones.Add(new Vector2((int)posicionBola.x + 1, (int)posicionBola.z));
                    posiciones.Add(new Vector2((int)posicionBola.x + 1, (int)posicionBola.z + 1));
                    posiciones.Add(new Vector2((int)posicionBola.x, (int)posicionBola.z + 1));
                    posiciones.Add(new Vector2((int)posicionBola.x - 1, (int)posicionBola.z + 1));
                    posiciones.Add(new Vector2((int)posicionBola.x, (int)posicionBola.z + 2));
                    posiciones.Add(new Vector2((int)posicionBola.x + 1, (int)posicionBola.z + 2));
                    posiciones.Add(new Vector2((int)posicionBola.x + 2, (int)posicionBola.z + 2));
                    posiciones.Add(new Vector2((int)posicionBola.x + 2, (int)posicionBola.z + 1));
                    posiciones.Add(new Vector2((int)posicionBola.x + 2, (int)posicionBola.z));
                    posiciones.Add(new Vector2((int)posicionBola.x + 2, (int)posicionBola.z - 1));
                    posiciones.Add(new Vector2((int)posicionBola.x + 2, (int)posicionBola.z - 2));
                    posiciones.Add(new Vector2((int)posicionBola.x + 1, (int)posicionBola.z - 2));
                    posiciones.Add(new Vector2((int)posicionBola.x, (int)posicionBola.z - 2));
                    posiciones.Add(new Vector2((int)posicionBola.x - 1, (int)posicionBola.z - 2));
                    posiciones.Add(new Vector2((int)posicionBola.x - 2, (int)posicionBola.z - 2));
                    posiciones.Add(new Vector2((int)posicionBola.x - 2, (int)posicionBola.z - 1));
                    posiciones.Add(new Vector2((int)posicionBola.x - 2, (int)posicionBola.z));
                    posiciones.Add(new Vector2((int)posicionBola.x - 2, (int)posicionBola.z + 1));
                    posiciones.Add(new Vector2((int)posicionBola.x - 2, (int)posicionBola.z + 2));
                    posiciones.Add(new Vector2((int)posicionBola.x - 1, (int)posicionBola.z + 2));
                }

                int posicionY = 1;
                
                //if (Escenario.Escenario.instancia.casillasMapa[(int)posiciones[0].x, (int)posiciones[0].y] != null)
                //{
                //    posicionY = (int)Escenario.Escenario.instancia.casillasMapa[(int)posiciones[0].x, (int)posiciones[0].y].prefab.gameObject.transform.localPosition.y;
                //}
                
                foreach (Vector2 posicion in posiciones)
                {
                    if (Limites.Comprobar((int)posicion.x, 2, Configuracion.instancia.tama�oX) == true && Limites.Comprobar((int)posicion.y, 2, Configuracion.instancia.tama�oZ) == true)
                    {
                        if (Escenario.Escenario.instancia.casillasMapa[(int)posicion.x, (int)posicion.y] != null)
                        {
                            bool cambiar = true;

                            //if ((int)Escenario.Escenario.instancia.casillasMapa[(int)posicion.x, (int)posicion.y].prefab.gameObject.transform.localPosition.y == posicionY)
                            //{
                            //    if (Escenario.Escenario.instancia.casillasMapa[(int)posicion.x, (int)posicion.y].id == 0)
                            //    {
                            //        cambiar = false;
                            //    }
                            //}
                            //else if ((int)Escenario.Escenario.instancia.casillasMapa[(int)posicion.x, (int)posicion.y].prefab.gameObject.transform.localPosition.y < posicionY)
                            //{
                            //    cambiar = false;
                            //}

                            if (cambiar == true)
                            {
                                Renderer renderer = Escenario.Escenario.instancia.casillasMapa[(int)posicion.x, (int)posicion.y].prefab.gameObject.GetComponent<Renderer>();

                                if (borrar == false)
                                {
                                    renderer.materials[0].CopyPropertiesFromMaterial(Configuracion.instancia.campo.casillaOscuroTransparente);
                                    renderer.materials[1].CopyPropertiesFromMaterial(Configuracion.instancia.campo.casillaClaroTransparente);
                                }
                                else if (borrar == true)
                                {
                                    renderer.materials[0].CopyPropertiesFromMaterial(Configuracion.instancia.campo.casillaOscuroOpaco);
                                    renderer.materials[1].CopyPropertiesFromMaterial(Configuracion.instancia.campo.casillaClaroOpaco);
                                }
                            }
                        }
                    }                                    
                }
            }            
        }
    }
}

