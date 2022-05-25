using TMPro;
using UnityEngine;

namespace Principal
{
    public class Opciones : MonoBehaviour
    {
        public Canvas canvasPrincipal;
        public Canvas canvasOpciones;

        public TMP_Dropdown dpIdiomas;

        public void VolverPrincipal()
        {
            canvasOpciones.gameObject.SetActive(false);
            canvasPrincipal.gameObject.SetActive(true);
        }

        public void Start()
        {
            Idiomas.Idiomas.instancia.CargarDropdownOpciones(dpIdiomas);
        }
    }
}
