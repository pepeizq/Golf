using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using System.Collections.Generic;

namespace Canvas2
{
    public class MultiLobby : MonoBehaviourPunCallbacks
    {
        public RectTransform panelSalas;
        public GameObject prefabBotonSala;

        public TMP_InputField textoJugador;
        public TMP_InputField textoSala;
        public GameObject panel1;
        public GameObject panel2;
        public TextMeshProUGUI textoJugadores;
        public Button botonEmpezarPartida;

        public void Start()
        {


            panel2.SetActive(false);
        }

        public override void OnConnectedToMaster()
        {

        }

        public override void OnRoomListUpdate(List<RoomInfo> listaSalas)
        {
            foreach (RoomInfo sala in listaSalas)
            {
                GameObject boton = Instantiate(prefabBotonSala, new Vector3(0, 0, 0), Quaternion.identity);
                boton.transform.SetParent(panelSalas.gameObject.transform);

                TextMeshProUGUI texto = boton.GetComponentInChildren<TextMeshProUGUI>();
                texto.text = string.Format("{0} - Jugadores: {1}/{2}", sala.Name, sala.PlayerCount, sala.MaxPlayers);

                Button boton2 = boton.GetComponent<Button>();
                boton2.onClick.RemoveAllListeners();
                //boton2.onClick.AddListener(() => NuevaPartida(campo.id));
            }
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
                Multijugador.Conexiones.instancia.CrearSala(textoSala.text);

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
                Multijugador.Conexiones.instancia.UnirseSala(textoSala.text);

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
            Multijugador.Conexiones.instancia.photonView.RPC("CambiarEscena", RpcTarget.All, "Escenario");
        }
    }
}

