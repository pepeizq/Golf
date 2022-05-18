using Escenario.Colocar;
using Jugador;
using Partida;
using Photon.Pun;
using Recursos;
using UnityEngine;

namespace Escenario
{
    public class Configuracion : MonoBehaviourPunCallbacks
    {
        [Header("Multijugador")]
        [HideInInspector] public float tiempoTerminar = 0f;
        [HideInInspector] public bool partidaTerminada = false;
        [HideInInspector] public Jugador.Bola[] jugadores;
        [HideInInspector] public Vector3 multiPosicionBolaInicio;
        [HideInInspector] public int multiPosicionXHoyo;
        [HideInInspector] public int multiPosicionZHoyo;
        private int jugadoresDentro;

        [Header("Partida")]
        [HideInInspector] public int numeroPartida = 0;
        [HideInInspector] public Campo campo;
        public Palos palos;

        [Header("Bola")]
        public float potenciaMaxima = 6f;
        public float anguloVelocidad = 100f;
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
        public bool animacionHoyoBola = true;

        [HideInInspector] public int nivel = 0;
        [HideInInspector] public int tamañoX = 40;
        [HideInInspector] public int tamañoZ = 40;
        [HideInInspector] public float alturaMaxima = 2f;
        [HideInInspector] public HoyoFormas forma = HoyoFormas.SinTocar;

        [HideInInspector] public Vector3 posicionHoyo;
        [HideInInspector] public int posicionHoyoX;
        [HideInInspector] public int posicionHoyoZ;

        public static Configuracion instancia;

        public void Awake()
        {
            instancia = this;

            if (Multijugador.instancia.Conectado() == false)
            {
                nivel = Unjugador.instancia.partida.nivel;

                if (Unjugador.instancia.nuevaPartida == true)
                {
                    aleatorio = true;
                    numeroPartida = PlayerPrefs.GetInt("numeroPartida");
                    campo = Campos.instancia.campos[PlayerPrefs.GetInt(numeroPartida.ToString() + "campo")];
                }
                else
                {
                    aleatorio = false;
                    numeroPartida = Unjugador.instancia.partida.numeroPartida;
                    campo = Campos.instancia.campos[Unjugador.instancia.partida.campo];
                }
            }
            else
            {
                nivel = 0;
                aleatorio = true;
                numeroPartida = 9999;

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
            if (Multijugador.instancia.Conectado() == true)
            {
                jugadores = new Jugador.Bola[PhotonNetwork.PlayerList.Length];
                photonView.RPC("MultijugadorSumarJugador", RpcTarget.AllBuffered);
            }

            Objetos.instancia.textoPartida.text = string.Format("Partida: {0}", numeroPartida.ToString());
            Objetos.instancia.textoHoyo.text = string.Format("Hoyo: {0}", (nivel + 1).ToString());
            Objetos.instancia.textoPalos.text = palos.ToString();
        }

        [PunRPC]
        public void MultijugadorSumarJugador()
        {
            jugadoresDentro += 1;

            if (jugadoresDentro == PhotonNetwork.PlayerList.Length)
            {
                Colocar.Bola.instancia.InstanciarBolaMulti(multiPosicionBolaInicio);
            }

            if (jugadoresDentro == Multijugador.instancia.Sala().PlayerCount)
            {

            }
        }

        [PunRPC]
        public void MultijugadorPosicionInicioBola(Vector3 posicion)
        {
            multiPosicionBolaInicio = posicion;
        }

        [PunRPC]
        public void MultijugadorPosicionInicioHoyo(int[] posiciones)
        {
            multiPosicionXHoyo = posiciones[0];
            multiPosicionZHoyo = posiciones[1];
        }

        public enum Palos { Madera, Hierro }
    }
}