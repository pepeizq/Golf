using TMPro;
using UnityEngine;

namespace Interfaz
{
    public class ObjetosNuevoNivel : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;

        [Header("Textos")]
        public TMP_Text mensaje;

        public static ObjetosNuevoNivel instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            mensaje.text = Idiomas.Idiomas.instancia.CogerCadena("messageNewLevel");
        }
    }
}
