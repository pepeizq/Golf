using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace Multijugador
{
    public class Lobby : MonoBehaviourPunCallbacks
    {
        public Button botonMultijugador;
        public TMP_InputField textoJugador;
        public TMP_InputField textoSala;
        public GameObject panel1;
        public GameObject panel2;
        public TextMeshProUGUI textoJugadores;
        public Button botonEmpezarPartida;

        public void Start()
        {
            botonMultijugador.interactable = false;

            panel2.SetActive(false);
        }

        public override void OnConnectedToMaster()
        {
            botonMultijugador.interactable = true;
        }

        public void CrearSala()
        {
            if (textoSala.text.Length == 0)
            {
                textoJugador.text = "testJugador" + PhotonNetwork.LocalPlayer.UserId; 
                textoSala.text = "testSala"; 
            }

            if (textoSala.text.Length > 0)
            {
                Manejador.instancia.CrearSala(textoSala.text);

                panel1.SetActive(false);
                panel2.SetActive(true);
            }
        }

        public void UnirseSala()
        {
            if (textoSala.text.Length == 0)
            {
                textoJugador.text = "testJugador" + PhotonNetwork.LocalPlayer.UserId;
                textoSala.text = "testSala";
            }

            if (textoSala.text.Length > 0)
            {
                Manejador.instancia.UnirseSala(textoSala.text);

                panel1.SetActive(false);
                panel2.SetActive(true);
            }               
        }

        public void CambiarNombreJugador()
        {
            if (textoJugador.text.Length > 0)
            {
                PhotonNetwork.NickName = textoJugador.text;
            }            
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

            panel1.SetActive(true);
            panel2.SetActive(false);
        }

        public void EmpezarPartida()
        {
            botonEmpezarPartida.interactable = false;
            Manejador.instancia.photonView.RPC("CambiarEscena", RpcTarget.All, "Escenario");
        }
    }
}

