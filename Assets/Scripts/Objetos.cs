using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Objetos : MonoBehaviour
{
    public GameObject bola;
    public GameObject camara;

    [Space(20)]

    [Header("Canvas")]
    [Space(5)]
    public TextMeshProUGUI textoGolpes;
    public Slider sliderPotencia;

    public static Objetos instancia;

    public void Awake()
    {
        instancia = this;

        instancia.sliderPotencia.gameObject.SetActive(false);
    }
}