using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosMultiConexion : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;
        public GameObject panelBotones;

        [Header("Botones")]
        public Button botonReconectar;
        public Button botonVolver;

        [Header("Textos")]
        public TMP_Text reconectar;
        public TMP_Text volver;
        public TMP_Text mensaje;

        public static ObjetosMultiConexion instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            reconectar.text = Idiomas.Idiomas.instancia.CogerCadena("reconnect");
            volver.text = Idiomas.Idiomas.instancia.CogerCadena("back");
        }
    }
}
