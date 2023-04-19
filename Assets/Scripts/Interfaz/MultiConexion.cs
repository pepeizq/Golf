using ExitGames.Client.Photon;
using Interfaz;
using Interfaz.Idiomas;
using Jugador;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace Principal
{
    public class MultiConexion : MonoBehaviourPunCallbacks
    {     
        public Canvas canvasLobby;

        private bool conectando;
        private float segundosSumar;
        private int segundosTemporal = 0;

        public static MultiConexion instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Update()
        {
            if (conectando == true)
            {
                segundosSumar += Time.deltaTime;
                int segundosSumar2 = (int)(segundosSumar % 60);

                if (segundosSumar2 > 10)
                {
                    MultiPhoton.instancia.Reconectar();
                }

                if (segundosSumar2 != segundosTemporal)
                {
                    segundosTemporal = segundosSumar2;

                    if (ObjetosMultiConexion.instancia.mensaje.text == Idiomas.instancia.CogerCadena("connecting") + " ..")
                    {
                        ObjetosMultiConexion.instancia.mensaje.text = Idiomas.instancia.CogerCadena("connecting") + " ...";
                    }
                    else
                    {
                        ObjetosMultiConexion.instancia.mensaje.text = Idiomas.instancia.CogerCadena("connecting") + " ..";
                    }      
                }
            }
        }

        public void Conectar()
        {
            if (MultiPhoton.instancia.Conectado() == false)
            {
                MultiPhoton.instancia.Conectar();

                ObjetosMultiConexion.instancia.mensaje.text = Idiomas.instancia.CogerCadena("connecting");

                if (ObjetosMultiConexion.instancia.panelBotones.activeSelf == true)
                {
                    ObjetosMultiConexion.instancia.panelBotones.SetActive(false);
                }

                conectando = true;
                segundosSumar = 0;
            }
            else
            {
                ConectadoaServidor();
            }
        }

        public override void OnErrorInfo(ErrorInfo error)
        {
            conectando = false;

            ObjetosMultiConexion.instancia.mensaje.text = error.Info;

            ObjetosMultiConexion.instancia.panelBotones.SetActive(true);
        }

        public override void OnConnectedToMaster()
        {
            ConectadoaServidor();
        }

        private void ConectadoaServidor()
        {
            conectando = false;

            Hashtable hash = new Hashtable
            {
                ["BolaColorRojo"] = Atributos.instancia.color.r,
                ["BolaColorVerde"] = Atributos.instancia.color.g,
                ["BolaColorAzul"] = Atributos.instancia.color.b,
                ["GolpesHoyo1"] = 0,
                ["GolpesHoyo2"] = 0,
                ["GolpesHoyo3"] = 0,
                ["GolpesHoyo4"] = 0,
                ["GolpesHoyo5"] = 0,
                ["GolpesHoyo6"] = 0,
                ["GolpesHoyo7"] = 0,
                ["GolpesHoyo8"] = 0,
                ["GolpesHoyo9"] = 0,
                ["GolpesHoyo10"] = 0,
                ["GolpesHoyo11"] = 0,
                ["GolpesHoyo12"] = 0,
                ["GolpesHoyo13"] = 0,
                ["GolpesHoyo14"] = 0,
                ["GolpesHoyo15"] = 0,
                ["GolpesHoyo16"] = 0,
                ["GolpesHoyo17"] = 0,
                ["GolpesHoyo18"] = 0,
                ["TerminadoHoyo1"] = false,
                ["TerminadoHoyo2"] = false,
                ["TerminadoHoyo3"] = false,
                ["TerminadoHoyo4"] = false,
                ["TerminadoHoyo5"] = false,
                ["TerminadoHoyo6"] = false,
                ["TerminadoHoyo7"] = false,
                ["TerminadoHoyo8"] = false,
                ["TerminadoHoyo9"] = false,
                ["TerminadoHoyo10"] = false,
                ["TerminadoHoyo11"] = false,
                ["TerminadoHoyo12"] = false,
                ["TerminadoHoyo13"] = false,
                ["TerminadoHoyo14"] = false,
                ["TerminadoHoyo15"] = false,
                ["TerminadoHoyo16"] = false,
                ["TerminadoHoyo17"] = false,
                ["TerminadoHoyo18"] = false
            };

            MultiPhoton.instancia.JugadorLocal().CustomProperties = hash;

            ObjetosMultiConexion.instancia.canvas.gameObject.SetActive(false);
            canvasLobby.gameObject.SetActive(true);

            if (MultiPhoton.instancia.EnLobby() == false)
            {
                MultiPhoton.instancia.UnirseLobby();
            }
        }

        public void VolverPrincipal()
        {
            ObjetosMultiConexion.instancia.canvas.gameObject.SetActive(false);
            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(true);
        }
    }
}
