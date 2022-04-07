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
        public Canvas canvasPrincipal;
        public Canvas canvasLobby;
        public Canvas canvasSala;

        [Header("Lobby")]
        public RectTransform panelSalas;
        public GameObject prefabBotonSala;

        public TMP_InputField textoJugador;
        public TMP_InputField textoSala;

        [Header("Sala")]
        public RectTransform panelJugadores;
        public GameObject prefabJugador;

        public Button botonEmpezarPartida;

        public void VolverPrincipal()
        {
            canvasLobby.gameObject.SetActive(false);
            canvasPrincipal.gameObject.SetActive(true);

            Multijugador.Conexiones.instancia.Desconectar();
        }

        public override void OnRoomListUpdate(List<RoomInfo> listaSalas)
        {
            foreach (Transform sala in panelSalas.gameObject.transform)
            {
                Destroy(sala.gameObject);
            }
       
            foreach (RoomInfo sala in listaSalas)
            {
                GameObject boton = Instantiate(prefabBotonSala, new Vector3(0, 0, 0), Quaternion.identity);
                boton.transform.SetParent(panelSalas.gameObject.transform);
                boton.transform.localScale = Vector3.one;

                TextMeshProUGUI texto = boton.GetComponentInChildren<TextMeshProUGUI>();
                texto.text = string.Format("{0} - Jugadores: {1}/{2}", sala.Name, sala.PlayerCount, sala.MaxPlayers);

                Button boton2 = boton.GetComponent<Button>();
                boton2.onClick.RemoveAllListeners();
                boton2.onClick.AddListener(() => UnirseSala(sala.Name));
            }
        }

        public void CrearSala()
        {
            if (textoSala.text.Length == 0)
            {
                textoJugador.text = "testJugadorServidor-" + PhotonNetwork.LocalPlayer.UserId; 
                textoSala.text = "testSala"; 
            }

            if (textoSala.text.Length > 0)
            {
                Multijugador.Conexiones.instancia.CrearSala(textoSala.text);

                canvasLobby.gameObject.SetActive(false);
                canvasSala.gameObject.SetActive(true);
            }
        }

        public void UnirseSala(string nombreSala)
        {
            if (textoJugador.text.Length == 0)
            {
                textoJugador.text = "testJugador-" + PhotonNetwork.LocalPlayer.UserId;
            }

            if (nombreSala.Length > 0)
            {
                Multijugador.Conexiones.instancia.UnirseSala(nombreSala);

                canvasLobby.gameObject.SetActive(false);
                canvasSala.gameObject.SetActive(true);
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
            photonView.RPC("ActualizarSala", RpcTarget.All);
        }

        public override void OnDisconnected(DisconnectCause cause)
        {
          
        }

        public override void OnPlayerLeftRoom(Player jugador)
        {
            if (canvasSala != null)
            {
                if (canvasSala.isActiveAndEnabled == true)
                {
                    if (jugador.IsMasterClient == false)
                    {
                        ActualizarSala();
                    }
                    else
                    {
                        DejarSala();
                    }              
                }
            }     
            else
            {
                if (jugador.IsMasterClient == true)
                {
                    PhotonNetwork.LeaveRoom();
                    Multijugador.Conexiones.instancia.photonView.RPC("CambiarEscena", RpcTarget.All, "Principal");
                }
            }
        }

        [PunRPC]
        public void ActualizarSala()
        {
            foreach (Transform jugador in panelJugadores.gameObject.transform)
            {
                Destroy(jugador.gameObject);
            }

            foreach (Player jugador in PhotonNetwork.PlayerList)
            {
                GameObject boton = Instantiate(prefabJugador, new Vector3(0, 0, 0), Quaternion.identity);
                boton.transform.SetParent(panelJugadores.gameObject.transform);
                boton.transform.localScale = Vector3.one;

                TextMeshProUGUI texto = boton.GetComponentInChildren<TextMeshProUGUI>();
                texto.text = string.Format("{0}", jugador.NickName);
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

            canvasSala.gameObject.SetActive(false);
            canvasLobby.gameObject.SetActive(true);
        }

        public void EmpezarPartida()
        {
            botonEmpezarPartida.interactable = false;
            Multijugador.Conexiones.instancia.photonView.RPC("CambiarEscena", RpcTarget.All, "Escenario");
        }
    }
}

