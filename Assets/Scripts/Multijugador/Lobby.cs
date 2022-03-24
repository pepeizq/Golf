using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

namespace Multijugador
{
    public class Lobby : MonoBehaviourPunCallbacks
    {
        public Button botonMultijugador;
        public Button botonCrearSala;
        public Button botonUnirseSala;
        public TextMeshProUGUI textoJugadores;
        public Button botonEmpezarPartida;

        public void Start()
        {
            botonMultijugador.interactable = false;
        }

        public override void OnConnectedToMaster()
        {
            botonMultijugador.interactable = true;
        }

        public void CrearSala(TMP_InputField nombreSala)
        {
            Manejador.instancia.CrearSala(nombreSala.text);
        }

        public void UnirseSala(TMP_InputField nombreSala)
        {
            Manejador.instancia.UnirseSala(nombreSala.text);
        }

        public void CambiarNombreJugador(TMP_InputField nombreJugador)
        {
            PhotonNetwork.NickName = nombreJugador.text;
        }

        public override void OnJoinedRoom()
        {
            photonView.RPC("ActualizarLobby", RpcTarget.All);
        }

        public override void OnPlayerLeftRoom(Player jugador)
        {
            ActualizarLobby();
        }

        [PunRPC]
        public void ActualizarLobby()
        {
            textoJugadores.text = string.Empty;

            foreach (Player jugador in PhotonNetwork.PlayerList)
            {
                textoJugadores.text = textoJugadores.text + jugador.NickName + "\n";
            }

            if (PhotonNetwork.IsMasterClient == true)
            {
                botonEmpezarPartida.interactable = true;
            }
            else
            {
                botonEmpezarPartida.interactable = false;
            }
        }

        public void DejarSala()
        {
            PhotonNetwork.LeaveRoom();
        }

        public void EmpezarPartida()
        {
            Manejador.instancia.photonView.RPC("CambiarEscena", RpcTarget.All, "Escenario");
        }
    }
}

