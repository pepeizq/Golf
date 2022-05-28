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

        public static MultiConexion instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Conectar()
        {
            MultiPhoton.instancia.Conectar();

            textoMensaje.text = Idiomas.Idiomas.instancia.CogerCadena("connecting");

            if (botones.activeSelf == true)
            {
                botones.SetActive(false);
            }
        }

        public override void OnErrorInfo(ErrorInfo error)
        {
            textoMensaje.text = error.Info;

            botones.SetActive(true);
        }

        public override void OnConnectedToMaster()
        {
            canvasConexion.gameObject.SetActive(false);
            canvasLobby.gameObject.SetActive(true);

            MultiPhoton.instancia.UnirseLobby();

            Hashtable hash = new Hashtable
            {
                ["BolaColorRojo"] = Atributos.instancia.color.r,
                ["BolaColorVerde"] = Atributos.instancia.color.g,
                ["BolaColorAzul"] = Atributos.instancia.color.b,
                ["BolaModelo"] = Atributos.instancia.modelo
            };

            PhotonNetwork.LocalPlayer.CustomProperties = hash;
        }

        public void VolverPrincipal()
        {
            canvasConexion.gameObject.SetActive(false);
            canvasMenu.gameObject.SetActive(true);
        }
    }
}
