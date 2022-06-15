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
                if (controles.Principal.EnseñarMenu.phase == InputActionPhase.Performed && Objetos.instancia.canvasPartidaTerminada.gameObject.activeSelf == false)
                {
                    EnseñarMenu();
                }
            }         
        }

        public void EnseñarMenu()
        {
            Configuracion.instancia.poderMover = false;

            Objetos.instancia.OcultarCanvas();
            Objetos.instancia.canvasMenu.gameObject.SetActive(true);
        }

        public void VolverPartida()
        {
            Configuracion.instancia.poderMover = true;

            Objetos.instancia.OcultarCanvas();
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

