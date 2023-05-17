using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosPartidaTerminada : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;

        [Header("Botones")]
        public Button botonVolver;

        [Header("Textos")]
        public TMP_Text volver;

        public static ObjetosPartidaTerminada instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            volver.text = Idiomas.Idiomas.instancia.CogerCadena("backMain");
        }
    }
}
