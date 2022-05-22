using Jugador;
using Partida;
using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Escenario
{
    public class NuevoNivel : MonoBehaviourPunCallbacks
    {
        private AsyncOperation cargando = null;

        public static NuevoNivel instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Update()
        {
            if (cargando != null)
            {
                Objetos.instancia.sliderCargando.value = Mathf.Clamp01(cargando.progress / 0.9f);
            }
        }

        public void UnJugador(int nuevoNivel)
        {
            if (nuevoNivel > Configuracion.instancia.campo.hoyos.Count)
            {
                SceneManager.LoadScene("Principal");
            }
            else
            {
                if (Unjugador.instancia.nuevaPartida == false)
                {
                    Unjugador.instancia.nuevaPartida = true;
                }

                Configuracion.instancia.aleatorio = true;
                Unjugador.instancia.partida.nivel = nuevoNivel;

                Objetos.instancia.canvasPartida.gameObject.SetActive(false);
                Objetos.instancia.canvasCargando.gameObject.SetActive(true);
                Objetos.instancia.sliderCargando.value = 0;

                cargando = SceneManager.LoadSceneAsync("Escenario");
            }
        }

        public void Multijugador()
        {
            MultiPartida.instancia.nivel = MultiPartida.instancia.nivel += 1;

            Objetos.instancia.canvasPartida.gameObject.SetActive(false);
            Objetos.instancia.canvasCargando.gameObject.SetActive(true);
            Objetos.instancia.sliderCargando.value = 0;

            cargando = SceneManager.LoadSceneAsync("Escenario");
        }
    }
}