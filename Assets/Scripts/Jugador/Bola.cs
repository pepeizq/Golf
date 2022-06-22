using Escenario;
using Escenario.Animaciones;
using Partida;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    //https://www.youtube.com/watch?v=rHM9bDgT2zQ
    public class Bola : MonoBehaviourPunCallbacks, IPunObservable
    {
        [HideInInspector] public Player photonJugador;
        [HideInInspector] public int id;

        [HideInInspector] public float rotacion = 0;
        [HideInInspector] public float potencia = 0;
        private bool potenciaDecrecer = false;
        private int golpes = 0;

        [HideInInspector] public Vector3 ultimaPosicionBola;
        private Vector3 ultimaPosicionCuerpo;
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

        public GameObject paloMadera;
        public GameObject paloHierro;

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

            foreach (Player jugador2 in MultiPhoton.instancia.ListaJugadores())
            {            
                Color colorBola = new Color((float)jugador2.CustomProperties["BolaColorRojo"], (float)jugador2.CustomProperties["BolaColorVerde"], (float)jugador2.CustomProperties["BolaColorAzul"]);

                foreach (GameObject bola in bolas)
                {
                    int id = bola.transform.GetChild(0).gameObject.GetComponent<Bola>().id;

                    if (id == jugador2.ActorNumber)
                    {
                        Personalizar.Color(bola.gameObject, colorBola);
                    }
                }
            }

            //----------------------------------------
            
            if (bolas.Length != MultiPhoton.instancia.Sala().PlayerCount)
            {
                Objetos.instancia.panelEsperandoJugadores.SetActive(true);
                Objetos.instancia.textoEsperandoJugadores.text = string.Format("{0} ({1}/{2})", Idiomas.Idiomas.instancia.CogerCadena("waitingPlayers"), bolas.Length, MultiPhoton.instancia.Sala().PlayerCount);

                Camera camara = Objetos.instancia.camara.GetComponent<Camera>();
                camara.transform.position = new Vector3(camara.transform.position.x, 60, camara.transform.position.z);

                Configuracion.instancia.poderMover = false;
            }
            else
            {
                Objetos.instancia.panelEsperandoJugadores.SetActive(false);

                if (Configuracion.instancia.presentacionHoyoBola == true)
                {
                    PresentacionHoyoBola.instancia.Generar();
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
            ultimaPosicionBola = transform.parent.localPosition + cuerpo.transform.localPosition;
            ultimaPosicionCuerpo = cuerpo.transform.localPosition;

            //--------------------------------------------------------------------

            camaraZoom = Configuracion.instancia.zoomDefecto;
            rotacion = 90;

            if (MultiPhoton.instancia.Conectado() == false)
            {
                if (Unjugador.instancia.nuevaPartida == false)
                {
                    camaraZoom = Cargar.CargarPartida(Unjugador.instancia.partida.numeroPartida).zoom;
                    rotacion = Cargar.CargarPartida(Unjugador.instancia.partida.numeroPartida).rotacion;
                    golpes = Cargar.CargarPartida(Unjugador.instancia.partida.numeroPartida).golpes;
                }

                Personalizar.Color(gameObject, Atributos.instancia.color);

                Guardar.GuardarPartida(ultimaPosicionBola, rotacion, golpes, camaraZoom);
            }

            Objetos.instancia.textoGolpes.text = string.Format("Golpes: {0}", golpes.ToString());       
        }

        public void Update()
        {
            bool jugadorAsignado = false;

            if (MultiPhoton.instancia.Conectado() == true)
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

                if (velocidad.magnitude <= 0.005f)
                {
                    cuerpo.velocity = Vector3.zero;
                    cuerpo.angularVelocity = Vector3.zero;
                        
                    linea.enabled = true;
                    ultimaPosicionBola = transform.parent.localPosition + cuerpo.transform.localPosition;
                    ultimaPosicionCuerpo = cuerpo.transform.localPosition;

                    Guardar.GuardarPartida(ultimaPosicionBola, rotacion, golpes, camaraZoom);
                    Transparentar.Casillas(ultimaPosicionBola, Transparentar.CasillasMaterial.Transparente);

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
                            if (Configuracion.instancia.paloEmpujarBola == true)
                            {
                                if (Configuracion.instancia.paloUsado == Configuracion.Palos.Madera)
                                {
                                    PaloEmpujarBola.instancia.Generar(gameObject, paloMadera);
                                }
                                else if (Configuracion.instancia.paloUsado == Configuracion.Palos.Hierro)
                                {
                                    PaloEmpujarBola.instancia.Generar(gameObject, paloHierro);
                                }
                            }
                            else
                            {
                                EmpujarBola();
                            }
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
                        rotacion -= Time.deltaTime * Configuracion.instancia.rotacionVelocidad;
                        transform.RotateAround(transform.position, Vector3.up, - Time.deltaTime * Configuracion.instancia.rotacionVelocidad);
                    }

                    if (controles.Principal.BolaRotarDerecha.phase == InputActionPhase.Performed)
                    {
                        rotacion += Time.deltaTime * Configuracion.instancia.rotacionVelocidad;
                        transform.RotateAround(transform.position, Vector3.up, Time.deltaTime * Configuracion.instancia.rotacionVelocidad);
                    }

                    if (rotacion > 360 || rotacion < -360)
                    {
                        rotacion = 0;
                    }

                    //--------------------------------------------------------

                    linea.SetPosition(0, gameObject.transform.position);
                    linea.SetPosition(1, gameObject.transform.position + Quaternion.Euler(0, rotacion, 0) * Vector3.forward * (Configuracion.instancia.lineaLongitud + potencia / 4));                   

                    //--------------------------------------------------------

                    if (controles.Principal.CambiarPalo.phase == InputActionPhase.Performed)
                    {
                        StartCoroutine(CambiarPalo());
                    }   
                }
                else
                {
                    linea.enabled = false;

                    if (transform.localPosition.y <= -5f)
                    {
                        transform.localPosition = ultimaPosicionCuerpo;
                        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
                        cuerpo.velocity = Vector3.zero;
                        cuerpo.angularVelocity = Vector3.zero;
                    }

                    Transparentar.Casillas(ultimaPosicionBola, Transparentar.CasillasMaterial.Opaco);
                }
            }     
            else
            {
                linea.enabled = false;
            }

            //-----------------------------------------------------------

            if (MultiPhoton.instancia.Conectado() == true)
            {
                if (controles.Principal.EnseñarNombresMulti.phase == InputActionPhase.Performed)
                {
                    MultiNombres.instancia.Enseñar();
                }
            }

            if (controles.Principal.EnseñarTablaGolpes.phase == InputActionPhase.Performed)
            {
                TablaGolpes.instancia.Enseñar();
            }
        }

        public void FixedUpdate()
        {
            bool jugadorAsignado = false;

            if (MultiPhoton.instancia.Conectado() == true)
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
                        Vector3 posicionBola = ultimaPosicionBola;

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

        public void EmpujarBola()
        {
            if (Configuracion.instancia.paloUsado == Configuracion.Palos.Madera)
            {
                cuerpo.AddForce(Quaternion.Euler(0, rotacion, 0) * Vector3.up * (potencia * 2), ForceMode.Impulse);
                cuerpo.AddForce(Quaternion.Euler(0, rotacion, 0) * Vector3.forward * (potencia * 2), ForceMode.Impulse);
            }
            else
            {
                cuerpo.AddForce(Quaternion.Euler(0, rotacion, 0) * Vector3.forward * potencia, ForceMode.Impulse);
            }

            potencia = 0;

            golpes += 1;
            Objetos.instancia.textoGolpes.text = string.Format("Golpes: {0}", golpes.ToString());

            if (MultiPhoton.instancia.Conectado() == true)
            {
                MultiPhoton.instancia.ActualizarPropiedades(photonJugador, "GolpesHoyo" + (Configuracion.instancia.nivel + 1), golpes);
            }
        }

        private void OnTriggerEnter(Collider colision)
        {
            if (colision.gameObject.name == "FondoHoyo")
            {
                if (MultiPhoton.instancia.Conectado() == true && photonView.IsMine == true)
                {
                    MultiPhoton.instancia.ActualizarPropiedades(photonJugador, "TerminadoHoyo" + (Configuracion.instancia.nivel + 1), true);
                }

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
                if (MultiPhoton.instancia.Conectado() == true && photonView.IsMine == true)
                {
                    MultiPhoton.instancia.ActualizarPropiedades(photonJugador, "TerminadoHoyo" + (Configuracion.instancia.nivel + 1), false);
                }

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
            if (MultiPhoton.instancia.Conectado() == false)
            {
                NuevoNivel.instancia.MensajeEspera(Configuracion.instancia.tiempoEsperaNuevoNivelUnjugador);
                yield return new WaitForSeconds(Configuracion.instancia.tiempoEsperaNuevoNivelUnjugador);
                Guardar.GuardarPartida(ultimaPosicionBola, rotacion, golpes, camaraZoom);          
                NuevoNivel.instancia.UnJugador(Configuracion.instancia.nivel += 1);
                Destroy(gameObject);
            }
            else
            {
                if (Objetos.instancia.canvasNuevoNivel.isActiveAndEnabled == false)
                {
                    NuevoNivel.instancia.MensajeEspera(Configuracion.instancia.tiempoEsperaNuevoNivelMultijugador);
                    yield return new WaitForSeconds(Configuracion.instancia.tiempoEsperaNuevoNivelMultijugador);
                    NuevoNivel.instancia.Multijugador();
                    Destroy(gameObject);
                }               
            }
        }

        IEnumerator CambiarPalo()
        {
            if (cambiarPalo == true)
            {
                cambiarPalo = false;

                if (Configuracion.instancia.paloUsado == Configuracion.Palos.Madera)
                {
                    Configuracion.instancia.paloUsado = Configuracion.Palos.Hierro;
                }
                else
                {
                    Configuracion.instancia.paloUsado = Configuracion.Palos.Madera;
                }

                Objetos.instancia.textoPalos.text = Configuracion.instancia.paloUsado.ToString();

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

