using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Canvas
{
    public class Partida : MonoBehaviour
    {
        public TextMeshProUGUI textoGolpes;
        public Slider sliderPotencia;

        public static Partida instancia;

        public void Awake()
        {
            instancia = this;

            instancia.sliderPotencia.gameObject.SetActive(false);
        }
    }
}