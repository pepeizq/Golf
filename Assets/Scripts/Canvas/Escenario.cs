using Escenario;
using Jugador;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace Canvas2
{
    public class Escenario : MonoBehaviour
    {
        private Controles controles;

        public void Awake()
        {
            controles = new Controles();
            controles.Principal.Enable();
        }

        public void Update()
        {
            if (controles != null)
            {
                if (controles.Principal.Ense�arMenu.phase == InputActionPhase.Performed)
                {
                    Ense�arMenu();
                }
            }         
        }

        public void Ense�arMenu()
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

