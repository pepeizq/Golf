using Jugador;
using Partida;
using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Escenario
{
    public class NuevoNivel : MonoBehaviourPunCallbacks
    {
        private int segundosTope;
        private float segundosRestar = 0f;

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

            if (Objetos.instancia.canvasNuevoNivel.gameObject.activeSelf == true)
            {
                segundosRestar += Time.deltaTime;
                int segundosRestar2 = (int)(segundosRestar % 60);
                int segundosFinal = segundosTope - segundosRestar2;

                Objetos.instancia.textoSegundos.text = segundosFinal.ToString();
            }
        }

        public void MensajeEspera(int segundos)
        {
            if (segundos > 0)
            {
                segundosTope = segundos;
                segundosRestar = 0f;

                Objetos.instancia.canvasNuevoNivel.gameObject.SetActive(true);
            }
        }

        public void UnJugador(int nuevoNivel)
        {
            Objetos.instancia.canvasNuevoNivel.gameObject.SetActive(false);

            if (nuevoNivel > Configuracion.instancia.campo.hoyos.Count)
            {
                GameObject multijugador = GameObject.FindGameObjectWithTag("Multijugador");
                Destroy(multijugador);

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
            Objetos.instancia.canvasNuevoNivel.gameObject.SetActive(false);

            if (MultiPartida.instancia.nivel + 1 > Configuracion.instancia.campo.hoyos.Count)
            {
                GameObject multijugador = GameObject.FindGameObjectWithTag("Multijugador");
                Destroy(multijugador);

                SceneManager.LoadScene("Principal");
            }
            else
            {
                MultiPartida.instancia.nivel = MultiPartida.instancia.nivel += 1;

                MultiPhoton.instancia.CambiarEscenaSincronizado("Escenario");
            }
        }
    }
}