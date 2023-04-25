using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosOpciones : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;
        public RectTransform panelOpciones;

        [Header("Botones")]
        public Button botonVolver;

        [Header("Textos")]
        public TMP_Text volver;

        [Header("Dropdowns")]
        public TMP_Dropdown dpIdiomas;

        public static ObjetosOpciones instancia;

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