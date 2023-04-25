using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosPersonalizarBola : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;

        [Header("Botones")]
        public Button botonVolver;

        [Header("Textos")]
        public TMP_Text volver;

        [Header("Sliders")]
        public Slider sliderRojo;
        public Slider sliderVerde;
        public Slider sliderAzul;

        [Header("Gameobjects")]
        public GameObject bolaVistaPrevia;
        public GameObject bolaPrincipalVistaPrevia;

        public static ObjetosPersonalizarBola instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            volver.text = Idiomas.Idiomas.instancia.CogerCadena("back");
        }
    }
}