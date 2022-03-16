using UnityEngine;
using UnityEngine.SceneManagement;

namespace Canvas2
{
    public class Escenario : MonoBehaviour
    {
        public void EnseñarMenu()
        {
            Configuracion.instancia.poderMover = false;

            Objetos.instancia.canvasPartida.gameObject.SetActive(false);
            Objetos.instancia.canvasMenu.gameObject.SetActive(true);
        }

        public void VolverPartida()
        {
            Configuracion.instancia.poderMover = true;

            Objetos.instancia.canvasMenu.gameObject.SetActive(false);
            Objetos.instancia.canvasPartida.gameObject.SetActive(true);
        }

        public void CargarPrincipal()
        {
            SceneManager.LoadScene("Principal");
        }
    }
}

