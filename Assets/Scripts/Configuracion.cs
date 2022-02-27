using UnityEngine;

public class Configuracion : MonoBehaviour
{      
    [Header("Bola")]
    [Space(5)]  
    public float potenciaMaxima = 6f;
    public float anguloVelocidad = 100f;
    public float lineaLongitud = 2f;
    [Space(10)]
    public CamaraModos camara;
    public int velocidadLibre = 20;
    public float zoomCerca = 0.5f;
    public float zoomLejos = 25f;

    [Space(20)]

    [Header("Escenario")]
    [Space(5)]
    public bool aleatorio;
    public bool colores;
    public bool llano;
    public bool colocarBola;
    [Space(10)]
    public int tamañoX = 40;
    public int tamañoZ = 40;
    public int alturaMaxima = 3;

    public static Configuracion instancia;

    public void Awake()
    {
        instancia = this;
    }

    public enum CamaraModos { Libre, Fija }
}
