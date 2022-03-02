using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Objetos : MonoBehaviour
{
    public GameObject bola;
    public GameObject hoyo;
    public GameObject camara;

    [Space(20)]
    [Header("Canvas")]
    public TextMeshProUGUI textoGolpes;
    public Slider sliderPotencia;

    public static Objetos instancia;

    public void Awake()
    {
        instancia = this;

        instancia.sliderPotencia.gameObject.SetActive(false);
    }
}