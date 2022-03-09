using Escenario.Colocar;
using Recursos;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Configuracion : MonoBehaviour
{
    [Header("Partida")]
    public int numeroPartida = 0;
    public Campo campo;
    public Palos palos;

    [Space(20)]
    [Header("Bola")]
    public float potenciaMaxima = 6f;
    public float anguloVelocidad = 100f;
    public float lineaLongitud = 2f;
    public Color color;

    [Space(20)]
    [Header("Camara")]
    public CamaraModos camara;
    public int velocidadLibre = 20;
    public float zoomCerca = 0.5f;
    public float zoomLejos = 25f;

    [Space(20)]
    [Header("Escenario")]
    public bool aleatorio = true;
    public bool colores = false;
    public bool llano = true;
    [Space(10)]
    public bool formar = true;
    public bool bola = true;
    public bool hoyo = true;
    public bool mordiscos = true;

    [HideInInspector] public int nivel = 0;
    [HideInInspector] public int tamañoX = 40;
    [HideInInspector] public int tamañoZ = 40;
    [HideInInspector] public float alturaMaxima = 2f;
    [HideInInspector] public HoyoFormas forma = HoyoFormas.SinTocar;

    public static Configuracion instancia;

    public void Awake()
    {
        instancia = this;

        nivel = PlayerPrefs.GetInt(numeroPartida.ToString() + "nivel");

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
        Objetos.instancia.textoHoyo.text = string.Format("Hoyo: {0}", nivel.ToString());
        Objetos.instancia.textoGolpes.text = "Golpes: 0";
        Objetos.instancia.textoPalos.text = palos.ToString();
    }

    public void NuevoNivel(int nuevoNivel)
    {
        aleatorio = true;
        PlayerPrefs.SetInt(numeroPartida.ToString() + "nivel", nuevoNivel);
        SceneManager.LoadScene("Escenario");
    }

    public enum CamaraModos { Libre, Fija }
    public enum Palos { Madera, Hierro }
}
