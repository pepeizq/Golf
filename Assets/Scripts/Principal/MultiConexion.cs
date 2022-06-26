using ExitGames.Client.Photon;
using Jugador;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

namespace Principal
{
    public class MultiConexion : MonoBehaviourPunCallbacks
    {     
        public Canvas canvasMenu;
        public Canvas canvasConexion;
        public Canvas canvasLobby;

        public TextMeshProUGUI textoMensaje;
        public GameObject botones;

        private bool conectando;
        private float segundosSumar;

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

                }
            }
        }

        public void Conectar()
        {
            MultiPhoton.instancia.Conectar();

            textoMensaje.text = Idiomas.Idiomas.instancia.CogerCadena("connecting");

            if (botones.activeSelf == true)
            {
                botones.SetActive(false);
            }

            conectando = true;
            segundosSumar = 0;
        }

        public override void OnErrorInfo(ErrorInfo error)
        {
            conectando = false;

            textoMensaje.text = error.Info;

            botones.SetActive(true);
        }

        public override void OnConnectedToMaster()
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

            canvasConexion.gameObject.SetActive(false);
            canvasLobby.gameObject.SetActive(true);

            MultiPhoton.instancia.UnirseLobby();
        }

        public void VolverPrincipal()
        {
            canvasConexion.gameObject.SetActive(false);
            canvasMenu.gameObject.SetActive(true);
        }
    }
}
