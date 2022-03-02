using UnityEngine;
using UnityEngine.SceneManagement;

public class Configuracion : MonoBehaviour
{
    [Header("Partida")]
    public int numeroPartida = 0;

    [Space(20)]
    [Header("Bola")]
    public float potenciaMaxima = 6f;
    public float anguloVelocidad = 100f;
    public float lineaLongitud = 2f;

    [Space(20)]
    [Header("Camara")]
    public CamaraModos camara;
    public int velocidadLibre = 20;
    public float zoomCerca = 0.5f;
    public float zoomLejos = 25f;

    [Space(20)]
    [Header("Escenario")]
    public bool aleatorio;
    public bool colores;
    public bool llano;
    [Space(10)]
    public int nivel = 1;
    public int tamañoX = 40;
    public int tamañoZ = 40;
    public int alturaMaxima = 3;
    [Space(10)]
    public bool bola;
    public bool hoyo;
    public bool mordiscos;

    public static Configuracion instancia;

    public void Awake()
    {
        instancia = this;

        nivel = PlayerPrefs.GetInt(numeroPartida.ToString() + "nivel");

        tamañoX = tamañoX + nivel * 10;
        tamañoZ = tamañoZ + nivel * 2;

        alturaMaxima = alturaMaxima * (nivel / 4);

        if (tamañoX > 60)
        {
            Escenario.Colocar.Mordiscos.instancia.intentos = tamañoX / (tamañoX / 2);
        }
        else
        {
            Escenario.Colocar.Mordiscos.instancia.intentos = 0;
        }
    }

    public void Start()
    {

    }

    public void NuevoNivel(int nuevoNivel)
    {
        PlayerPrefs.SetInt(numeroPartida.ToString() + "nivel", nuevoNivel);
        SceneManager.LoadScene("Escenario");
    }

    public enum CamaraModos { Libre, Fija }
}
