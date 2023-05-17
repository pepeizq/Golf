using Interfaz;
using Jugador;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace Escenario
{
    public class Interfaz : MonoBehaviour
    {
        private Controles controles;

        public static Interfaz instancia;

        public void Awake()
        {
            instancia = this;

            controles = new Controles();
            controles.Principal.Enable();
        }

        public void Update()
        {
            if (controles != null)
            {
                if (Configuracion.instancia.poderMover == true)
                {
                    if (controles.Principal.EnseñarMenu.phase == InputActionPhase.Performed && ObjetosPartidaTerminada.instancia.canvas.gameObject.activeSelf == false)
                    {
                        EnseñarMenu();
                    }
                }               
            }         
        }

        public void EnseñarMenu()
        {
            Configuracion.instancia.poderMover = false;

            OcultarCanvas();
            ObjetosMenu.instancia.canvas.gameObject.SetActive(true);
        }

        public void VolverPartida()
        {
            Configuracion.instancia.poderMover = true;

            OcultarCanvas();
            ObjetosPartida.instancia.canvas.gameObject.SetActive(true);
        }

        public void CargarPrincipal()
        {
            GameObject multijugador = GameObject.FindGameObjectWithTag("Multijugador");
            Destroy(multijugador);

            SceneManager.LoadScene("Principal");
        }

        public void OcultarCanvas()
        {
            ObjetosPartida.instancia.canvas.gameObject.SetActive(false);
            ObjetosMenu.instancia.canvas.gameObject.SetActive(false);
            ObjetosCargandoEscenario.instancia.canvas.gameObject.SetActive(false);
            ObjetosTablaGolpes.instancia.canvas.gameObject.SetActive(false);
            ObjetosNuevoNivel.instancia.canvas.gameObject.SetActive(false);
            ObjetosPartidaTerminada.instancia.canvas.gameObject.SetActive(false);
        }
    }
}

