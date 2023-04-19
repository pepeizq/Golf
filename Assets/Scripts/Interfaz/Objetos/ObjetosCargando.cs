using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosCargando : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;

        [Header("Textos")]
        public TMP_Text cargando;

        [Header("Sliders")]
        public Slider slider;

        public static ObjetosCargando instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            cargando.text = Idiomas.Idiomas.instancia.CogerCadena("loading");
        }
    }
}