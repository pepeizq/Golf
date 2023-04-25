using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosPartida : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panelAbajo;

        [Header("Botones")]
        public Button botonMenu;

        [Header("Textos")]
        public TMP_Text menu;
        public TMP_Text partida;
        public TMP_Text hoyo;
        public TMP_Text golpes;
        public TMP_Text palos;

        [Header("Sliders")]
        public Slider sliderPotencia;

        public static ObjetosPartida instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            menu.text = Idiomas.Idiomas.instancia.CogerCadena("menu");
        }
    }
}
