using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosMenu : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;

        [Header("Botones")]
        public Button botonVolverPartida;
        public Button botonVolverPrincipal;

        [Header("Textos")]
        public TMP_Text volverPartida;
        public TMP_Text volverPrincipal;

        public static ObjetosMenu instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            volverPartida.text = Idiomas.Idiomas.instancia.CogerCadena("backGame");
            volverPrincipal.text = Idiomas.Idiomas.instancia.CogerCadena("backMain");
        }
    }
}