using Escenario;
using Escenario.Animaciones;
using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    //https://www.youtube.com/watch?v=rHM9bDgT2zQ
    public class Bola : MonoBehaviourPunCallbacks, IPunObservable
    {
        [HideInInspector] public Player photonJugador;
        [HideInInspector] public int id;

        private float angulo = 0;
        private float potencia = 0;
        private float potenciaUltima = 0;
        private bool potenciaDecrecer = false;
        private int golpes = 0;

        [HideInInspector] public Vector3 ultimaPosicion;
        private LineRenderer linea;
        private Rigidbody cuerpo;

        private Vector3 camaraOffset;
        private Vector2 camaraMovimientoInput;
        private float camaraZoom;
        private float camaraZoomInput;
        private bool camaraVolver;
        private float camaraVolverPasos = 0f;

        private bool cambiarPalo = true;

        private Controles controles;

        public static Bola instancia;

        [PunRPC]
        public void Arranque(Player jugador)
        {
            photonJugador = jugador;
            id = jugador.ActorNumber;

            Configuracion.instancia.jugadores[id - 1] = this;

            if (photonView.IsMine == false)
            {
                cuerpo.isKinematic = true;
            }

            //----------------------------------------

            GameObject[] bolas = GameObject.FindGameObjectsWithTag("Player");

            foreach (Player jugador2 in PhotonNetwork.PlayerList)
            {
                UnityEngine.Color color2 = new UnityEngine.Color((float)jugador2.CustomProperties["BolaColorRojo"], (float)jugador2.CustomProperties["BolaColorVerde"], (float)jugador2.CustomProperties["BolaColorAzul"]);

                foreach (GameObject bola in bolas)
                {
                    int id = bola.transform.GetChild(0).gameObject.GetComponent<Bola>().id;

                    if (id == jugador2.ActorNumber)
                    {
                        Color.Cambiar(bola.gameObject, color2);
                    }
                }
            }

            //----------------------------------------
            
            if (bolas.Length != Multijugador.instancia.Sala().PlayerCount)
            {
                Objetos.instancia.panelMensaje.SetActive(true);
                Configuracion.instancia.poderMover = false;
            }
            else
            {
                Objetos.instancia.panelMensaje.SetActive(false);

                if (Configuracion.instancia.animacionHoyoBola == true)
                {
                    HoyoBola.instancia.Generar();
                }
                else
                {
                    Configuracion.instancia.poderMover = true;
                }
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
            ultimaPosicion = transform.parent.localPosition;
           
            //--------------------------------------------------------------------

            camaraZoom = Configuracion.instancia.zoomDefecto;
            angulo = 90;

            if (Multijugador.instancia.Conectado() == false)
            {
                if (Unjugador.instancia.nuevaPartida == false)
                {
                    camaraZoom = Partida.Cargar.CargarBola(Unjugador.instancia.partida.numeroPartida).zoom;
                    angulo = Partida.Cargar.CargarBola(Unjugador.instancia.partida.numeroPartida).angulo;
                    golpes = Partida.Cargar.CargarBola(Unjugador.instancia.partida.numeroPartida).golpes;
                }

                Color.Cambiar(gameObject, Atributos.instancia.color);
            }

            Objetos.instancia.textoGolpes.text = string.Format("Golpes: {0}", golpes.ToString());

            //--------------------------------------------------------------------

            if (Multijugador.instancia.Conectado() == false)
            {
                Partida.Guardar.GuardarMaestro(ultimaPosicion, angulo, golpes, camaraZoom, DateTime.Now, Configuracion.instancia.campo.id, Configuracion.instancia.nivel, Configuracion.instancia.numeroPartida);
            }            
        }

        public void Update()
        {
            bool jugadorAsignado = false;

            if (Multijugador.instancia.Conectado() == true)
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
                    ultimaPosicion = transform.parent.localPosition;
            
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

                            potenciaUltima = potencia;
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

                    //--------------------------------------------------------

                    if (controles.Principal.CambiarPalo.phase == InputActionPhase.Performed)
                    {
                        StartCoroutine(CambiarPalo());
                    }   
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

            if (Multijugador.instancia.Conectado() == true)
            {
                if (controles.Principal.EnseņarNombresMulti.phase == InputActionPhase.Performed)
                {
                    MultiNombres.instancia.Enseņar();
                }
            }
        }

        public void FixedUpdate()
        {
            bool jugadorAsignado = false;

            if (Multijugador.instancia.Conectado() == true)
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
                Camera camara = Objetos.instancia.camara.GetComponent<Camera>();

                camaraMovimientoInput = controles.Principal.CamaraLibreMovimiento.ReadValue<Vector2>();

                if (camaraMovimientoInput.x != 0 || camaraMovimientoInput.y != 0)
                {
                    if (camaraVolverPasos == 0f)
                    {
                        if (camaraMovimientoInput.x > 0 && camaraMovimientoInput.y == 0)
                        {
                            camara.transform.Translate(new Vector3(Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0, 0));
                        }
                        else if (camaraMovimientoInput.x < 0 && camaraMovimientoInput.y == 0)
                        {
                            camara.transform.Translate(new Vector3(-Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0, 0));
                        }
                        else if (camaraMovimientoInput.x == 0 && camaraMovimientoInput.y > 0)
                        {
                            camara.transform.Translate(new Vector3(0, Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0));
                        }
                        else if (camaraMovimientoInput.x == 0 && camaraMovimientoInput.y < 0)
                        {
                            camara.transform.Translate(new Vector3(0, -Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0));
                        }
                        else if (camaraMovimientoInput.x < 0 && camaraMovimientoInput.y < 0)
                        {
                            camara.transform.Translate(new Vector3(0, -Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0));
                            camara.transform.Translate(new Vector3(-Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0, 0));
                        }
                        else if (camaraMovimientoInput.x > 0 && camaraMovimientoInput.y < 0)
                        {
                            camara.transform.Translate(new Vector3(Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0, 0));
                            camara.transform.Translate(new Vector3(0, -Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0));
                        }
                        else if (camaraMovimientoInput.x > 0 && camaraMovimientoInput.y > 0)
                        {
                            camara.transform.Translate(new Vector3(Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0, 0));
                            camara.transform.Translate(new Vector3(0, Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0));
                        }
                        else if (camaraMovimientoInput.x < 0 && camaraMovimientoInput.y > 0)
                        {
                            camara.transform.Translate(new Vector3(-Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0, 0));
                            camara.transform.Translate(new Vector3(0, Configuracion.instancia.velocidadLibre * Time.deltaTime * 2, 0));
                        }

                        camara.transform.position = new Vector3(camara.transform.position.x, 60, camara.transform.position.z);
                        camaraVolver = true;
                    }                       
                }
                else
                {
                    if (camaraVolver == true)
                    {
                        Vector3 posicionBola = instancia.ultimaPosicion;

                        camaraVolverPasos += Time.deltaTime * 2;

                        Vector3 posicionNueva = Vector3.MoveTowards(camara.transform.position, posicionBola, camaraVolverPasos);
                        camara.transform.position = posicionNueva;

                        if (Vector3.Distance(camara.transform.position, posicionBola) <= camaraVolverPasos)
                        {
                            camaraVolverPasos = 0f;
                            camaraVolver = false;
                        }
                    }
                    else
                    {                       
                        Vector3 posicion = transform.position + camaraOffset;
                        posicion.x -= Configuracion.instancia.rotacionCamaraX + (transform.position.y - 1f) / 2;
                        posicion.y = 60;
                        posicion.z -= Configuracion.instancia.rotacionCamaraZ + (transform.position.y - 1f) / 2;

                        camara.transform.position = posicion;
                    }               
                }

                //------------------------------------
                
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

        private void OnCollisionEnter(Collision colision)
        {
            if (colision.gameObject.name.Contains("Bola"))
            {
                Physics.IgnoreCollision(GetComponent<Collider>(), colision.gameObject.GetComponent<Collider>(), true);
            }
        }

        private void OnCollisionExit(Collision colision)
        {
            if (colision.gameObject.name.Contains("Bola"))
            {
                //Physics.IgnoreCollision(GetComponent<Collider>(), colision.gameObject.GetComponent<Collider>(), false);
            }
        }

        IEnumerator TerminarHoyo()
        {            
            if (Multijugador.instancia.Conectado() == false)
            {
                yield return new WaitForSeconds(5);
                Destroy(gameObject);
                Configuracion.instancia.NuevoNivel(Configuracion.instancia.nivel += 1);
            }
            else
            {
                photonView.RPC("MultijugadorNuevoNivel", RpcTarget.All);
            }
        }

        IEnumerator CambiarPalo()
        {
            if (cambiarPalo == true)
            {
                cambiarPalo = false;

                if (Configuracion.instancia.palos == Configuracion.Palos.Madera)
                {
                    Configuracion.instancia.palos = Configuracion.Palos.Hierro;
                }
                else
                {
                    Configuracion.instancia.palos = Configuracion.Palos.Madera;
                }

                Objetos.instancia.textoPalos.text = Configuracion.instancia.palos.ToString();

                yield return new WaitForSeconds(0.5f);

                cambiarPalo = true;
            }         
        }

        public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo mensaje)
        {
            if (stream.IsWriting == true)
            {

            }
            else if (stream.IsReading == true)
            {

            }
        }
    }
}

