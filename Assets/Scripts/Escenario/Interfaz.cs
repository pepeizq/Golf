using Jugador;
using Partida;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace Escenario
{
    public class Interfaz : MonoBehaviour
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
                if (controles.Principal.EnseņarMenu.phase == InputActionPhase.Performed)
                {
                    EnseņarMenu();
                }
            }         
        }

        public void EnseņarMenu()
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
            GameObject multijugador = GameObject.FindGameObjectWithTag("Multijugador");
            Destroy(multijugador);

            SceneManager.LoadScene("Principal");
        }
    }
}

