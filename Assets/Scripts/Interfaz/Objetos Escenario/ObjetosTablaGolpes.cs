using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosTablaGolpes : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;

        [Header("Textos")]
        public TMP_Text cargando2;

        [Header("Sliders")]
        public Slider slider;

        public static ObjetosTablaGolpes instancia;

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