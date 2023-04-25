using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosNuevaPartida : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;
        public RectTransform panelCampos;

        [Header("Botones")]
        public Button botonVolver;

        [Header("Textos")]
        public TMP_Text volver;

        [Header("Prefabs")]
        public GameObject prefabBotonCampo;

        public static ObjetosNuevaPartida instancia;

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