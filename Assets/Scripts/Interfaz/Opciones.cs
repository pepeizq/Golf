using UnityEngine;

namespace Interfaz
{
    public class Opciones : MonoBehaviour
    {
        public void VolverPrincipal()
        {
            ObjetosOpciones.instancia.canvas.gameObject.SetActive(false);
            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(true);
        }

        public void Start()
        {
            Idiomas.Idiomas.instancia.CargarDropdownOpciones(ObjetosOpciones.instancia.dpIdiomas);
        }
    }
}
