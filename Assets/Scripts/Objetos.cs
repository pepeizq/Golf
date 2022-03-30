using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Objetos : MonoBehaviour
{
    public GameObject bola;
    public GameObject camara;

    [Header("Canvas Partida")]
    public Canvas canvasPartida;
    public TextMeshProUGUI textoPartida;
    public TextMeshProUGUI textoHoyo;
    public TextMeshProUGUI textoGolpes;
    public TextMeshProUGUI textoPalos;
    public Slider sliderPotencia;

    [Header("Canvas Menu")]
    public Canvas canvasMenu;

    public static Objetos instancia;

    public void Awake()
    {
        instancia = this;

        instancia.sliderPotencia.gameObject.SetActive(false);
    }
}