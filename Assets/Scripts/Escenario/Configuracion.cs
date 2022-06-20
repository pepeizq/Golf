using Escenario.Colocar;
using Jugador;
using Partida;
using Photon.Pun;
using Recursos;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Escenario
{
    public class Configuracion : MonoBehaviourPunCallbacks
    {
        [Header("Partida")]
        [HideInInspector] public int numeroPartida = 0;
        [HideInInspector] public Campo campo;
        public Palos paloUsado;
        [HideInInspector] public bool partidaTerminada = false;

        [Header("Bola")]
        public float potenciaMaxima = 6f;
        public float rotacionVelocidad = 100f;
        public float lineaLongitud = 2f;
        public bool transparencias = true;

        [HideInInspector] public bool poderMover = true;

        [Header("Camara")]
        public int velocidadLibre = 20;
        public float zoomDefecto = 3.5f;
        public float zoomCerca = 0.5f;
        public float zoomLejos = 25f;

        [HideInInspector] public float rotacionCamaraX = 42f;
        [HideInInspector] public float rotacionCamaraY = 60f;
        [HideInInspector] public float rotacionCamaraZ = 42f;

        [Header("Escenario")]
        public bool aleatorio = true;
        public bool colores = false;
        public bool llano = true;
        [Space(10)]
        public bool formar = true;
        public bool bola = true;
        public bool hoyo = true;
        public bool mordiscos = true;
        public bool muros = true;

        [Header("Animaciones")]
        public bool animacionPresentacionHoyoBola = true;

        [HideInInspector] public int nivel = 0;
        [HideInInspector] public int tamañoX = 40;
        [HideInInspector] public int tamañoZ = 40;
        [HideInInspector] public float alturaMaxima = 2f;
        [HideInInspector] public HoyoFormas forma = HoyoFormas.SinTocar;

        [HideInInspector] public Vector3 posicionHoyo;
        [HideInInspector] public int posicionHoyoX;
        [HideInInspector] public int posicionHoyoZ;

        [Header("Unjugador")]
        public int tiempoEsperaNuevoNivelUnjugador = 5;

        [Header("Multijugador")]
        public int tiempoEsperaNuevoNivelMultijugador = 30;
        public int golpesExtraMultijugador = 10;
        [HideInInspector] public Jugador.Bola[] jugadores;
        [HideInInspector] public Vector3 multiPosicionBolaInicio;
        private int jugadoresDentro;      

        public static Configuracion instancia;

        public void Awake()
        {
            instancia = this;

            if (MultiPhoton.instancia.Conectado() == false)
            {
                nivel = Unjugador.instancia.partida.nivel;

                if (Unjugador.instancia.nuevaPartida == true)
                {
                    aleatorio = true;
                    numeroPartida = PlayerPrefs.GetInt("numeroPartida");
                    campo = Datos.instancia.campos[PlayerPrefs.GetInt(numeroPartida.ToString() + "campo")];
                }
                else
                {
                    aleatorio = false;
                    numeroPartida = Unjugador.instancia.partida.numeroPartida;
                    campo = Datos.instancia.campos[Unjugador.instancia.partida.campo];
                }
            }
            else
            {
                nivel = MultiPartida.instancia.nivel;
                aleatorio = true;
                campo = Datos.instancia.campos[MultiPartida.instancia.campo];
            }

            if (campo != null)
            {
                forma = campo.hoyos[nivel].forma;
            
                tamañoX = campo.hoyos[nivel].tamañoX;
                tamañoZ = campo.hoyos[nivel].tamañoZ;
           
                alturaMaxima = campo.hoyos[nivel].alturaMaxima;

                Mordiscos.instancia.intentos = campo.hoyos[nivel].intentosMordiscos;
            }
        }

        public void Start()
        {
            if (MultiPhoton.instancia.Conectado() == true)
            {
                jugadores = new Jugador.Bola[MultiPhoton.instancia.ListaJugadores().Length];
                photonView.RPC("MultijugadorSumarJugador", RpcTarget.AllBuffered);
            }

            Objetos.instancia.textoPartida.text = string.Format("Partida: {0}", numeroPartida.ToString());
            Objetos.instancia.textoHoyo.text = string.Format("Hoyo: {0}", (nivel + 1).ToString());
            Objetos.instancia.textoPalos.text = paloUsado.ToString();
        }

        [PunRPC]
        public void MultijugadorSumarJugador()
        {
            jugadoresDentro += 1;

            if (jugadoresDentro == MultiPhoton.instancia.ListaJugadores().Length)
            {
                Colocar.Bola.instancia.InstanciarBolaMulti(multiPosicionBolaInicio);
            }

            if (jugadoresDentro == MultiPhoton.instancia.Sala().PlayerCount)
            {

            }
        }

        [PunRPC]
        public void MultijugadorPosicionInicioBola(Vector3 posicion)
        {
            multiPosicionBolaInicio = posicion;
        }

        [PunRPC]
        public void MultijugadorRecargarEscena()
        {
            MultiPartida.instancia.nivel = MultiPartida.instancia.nivel += 1;
            SceneManager.LoadScene("Escenario");
        }

        [PunRPC]
        public void PartidaTerminada()
        {
            partidaTerminada = true;
            poderMover = false;

            Objetos.instancia.OcultarCanvas();        
            TablaGolpes.instancia.mostrar = true;
            Objetos.instancia.canvasTablaGolpes.gameObject.SetActive(true);
            Objetos.instancia.canvasPartidaTerminada.gameObject.SetActive(true);
        }

        public enum Palos { Madera, Hierro }
    }
}