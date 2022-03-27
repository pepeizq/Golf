using Escenario.Colocar;
using Photon.Pun;
using Recursos;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Configuracion : MonoBehaviourPunCallbacks
{
    [Header("Multijugador")]
    public float tiempoTerminar = 0f;
    [HideInInspector] public bool partidaTerminada = false;
    [HideInInspector] public Jugador.Bola[] jugadores;
    [HideInInspector] public Vector3 posicionInicioBola;
    private int jugadoresDentro;

    [Header("Partida")]
    [HideInInspector] public JuegoModo juegoModo;
    [HideInInspector] public int numeroPartida = 0;
    public List<Campo> campos;
    [HideInInspector] public Campo campo;
    public Palos palos;

    [Header("Bola")]
    public float potenciaMaxima = 6f;
    public float anguloVelocidad = 100f;
    public float lineaLongitud = 2f;
    public Color color;
    public bool transparencias = true;

    [HideInInspector] public bool poderMover = true;

    [Header("Camara")]
    public GameObject camaraObjeto;
    public CamaraModos camaraModo;
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

        if (PlayerPrefs.GetString("continuarPartida") == "si")
        {
            aleatorio = false;
            PlayerPrefs.SetString("continuarPartida", "no");
        }

        numeroPartida = PlayerPrefs.GetInt("numeroPartida");
        nivel = PlayerPrefs.GetInt(numeroPartida.ToString() + "nivel");
        campo = campos[PlayerPrefs.GetInt(numeroPartida.ToString() + "campo")];

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
        if (PhotonNetwork.IsConnected == true)
        {
            instancia.jugadores = new Jugador.Bola[PhotonNetwork.PlayerList.Length];
            instancia.photonView.RPC("MultijugadorSumarJugador", RpcTarget.AllBuffered);
        }

        Objetos.instancia.textoPartida.text = string.Format("Partida: {0}", numeroPartida.ToString());
        Objetos.instancia.textoHoyo.text = string.Format("Hoyo: {0}", (nivel + 1).ToString());
        Objetos.instancia.textoPalos.text = palos.ToString();
    }

    public void NuevoNivel(int nuevoNivel)
    {
        aleatorio = true;
        PlayerPrefs.SetInt(numeroPartida.ToString() + "nivel", nuevoNivel);
        SceneManager.LoadScene("Escenario");
    }

    [PunRPC]
    public void MultijugadorSumarJugador()
    {
        jugadoresDentro += 1;
  
        if (jugadoresDentro == PhotonNetwork.PlayerList.Length)
        {
            Bola.instancia.InstanciarBola(posicionInicioBola);  
        }
    }

    [PunRPC]
    public void MultijugadorPosicionInicioBola(Vector3 posicion)
    {
        posicionInicioBola = posicion;
    }

    public Jugador.Bola CogerBola(int idJugador)
    {
        foreach (var jugador in jugadores)
        {
            if (jugador.id == idJugador)
            {
                return jugador;
            }
        }

        return null;
    }

    public Jugador.Bola CogerBola(GameObject jugador)
    {
        foreach (var jugador2 in jugadores)
        {
            if (jugador2.gameObject == jugador)
            {
                return jugador2;
            }
        }

        return null;
    }

    public enum JuegoModo { UnJugador, MultiJugadorHost, MultiJugadorCliente }
    public enum CamaraModos { Libre, Fija }
    public enum Palos { Madera, Hierro }
}
