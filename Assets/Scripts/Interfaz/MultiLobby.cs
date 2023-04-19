using Jugador;
using Partida;
using Photon.Pun;
using Photon.Realtime;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class MultiLobby : MonoBehaviourPunCallbacks
    {
        public void VolverPrincipal()
        {
            ObjetosMultiLobby.instancia.canvas.gameObject.SetActive(false);
            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(true);

            MultiPhoton.instancia.Desconectar();
        }

        public override void OnRoomListUpdate(List<RoomInfo> listaSalas)
        {
            foreach (Transform sala in ObjetosMultiLobby.instancia.panelSalas.gameObject.transform)
            {
                Destroy(sala.gameObject);
            }
       
            foreach (RoomInfo sala in listaSalas)
            {
                GameObject boton = Instantiate(ObjetosMultiLobby.instancia.prefabBotonSala, new Vector3(0, 0, 0), Quaternion.identity);
                boton.transform.SetParent(ObjetosMultiLobby.instancia.panelSalas.gameObject.transform);
                boton.transform.localScale = Vector3.one;

                TextMeshProUGUI texto = boton.GetComponentInChildren<TextMeshProUGUI>();
                texto.text = string.Format("{0} - " + Interfaz.Idiomas.Idiomas.instancia.CogerCadena("players") + ": {1}/{2}", sala.Name, sala.PlayerCount, sala.MaxPlayers);

                Button boton2 = boton.GetComponent<Button>();
                boton2.onClick.RemoveAllListeners();
                boton2.onClick.AddListener(() => UnirseSala(sala.Name));

                if (sala.IsOpen == false)
                {
                    texto.text = "* " + texto.text;
                    boton2.enabled = false;
                }
            }
        }

        public void CrearSala()
        {
            if (ObjetosMultiLobby.instancia.textoSala.text.Length == 0)
            {
                ObjetosMultiLobby.instancia.textoJugador.text = "testJugadorServidor";
                ObjetosMultiLobby.instancia.textoSala.text = "testSala"; 
            }

            if (ObjetosMultiLobby.instancia.textoSala.text.Length > 0)
            {
                MultiPhoton.instancia.CrearSala(ObjetosMultiLobby.instancia.textoSala.text);

                ObjetosMultiLobby.instancia.canvas.gameObject.SetActive(false);
                ObjetosMultiSala.instancia.canvas.gameObject.SetActive(true);
            }
        }

        public void UnirseSala(string nombreSala)
        {
            if (ObjetosMultiLobby.instancia.textoJugador.text.Length == 0)
            {
                ObjetosMultiLobby.instancia.textoJugador.text = "testJugador-" + PhotonNetwork.LocalPlayer.UserId;
            }

            if (nombreSala.Length > 0)
            {
                MultiPhoton.instancia.UnirseSala(nombreSala);

                ObjetosMultiLobby.instancia.canvas.gameObject.SetActive(false);
                ObjetosMultiSala.instancia.canvas.gameObject.SetActive(true);
            }               
        }

        public void CambiarNombreJugador()
        {
            if (ObjetosMultiLobby.instancia.textoJugador.text.Length > 0)
            {
                PhotonNetwork.NickName = ObjetosMultiLobby.instancia.textoJugador.text;
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
            if (ObjetosMultiSala.instancia.canvas != null)
            {
                if (ObjetosMultiSala.instancia.canvas.isActiveAndEnabled == true)
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
                    MultiPhoton.instancia.DejarSala();
                    MultiPhoton.instancia.photonView.RPC("CambiarEscena", RpcTarget.All, "Principal");
                }
            }
        }

        [PunRPC]
        public void ActualizarSala()
        {
            foreach (Transform jugador in ObjetosMultiSala.instancia.panelJugadores.gameObject.transform)
            {
                Destroy(jugador.gameObject);
            }

            foreach (Player jugador in MultiPhoton.instancia.ListaJugadores())
            {
                GameObject boton = Instantiate(ObjetosMultiSala.instancia.prefabJugador, new Vector3(0, 0, 0), Quaternion.identity);
                boton.transform.SetParent(ObjetosMultiSala.instancia.panelJugadores.gameObject.transform);
                boton.transform.localScale = Vector3.one;

                TextMeshProUGUI texto = boton.GetComponentInChildren<TextMeshProUGUI>();
                texto.text = string.Format("{0}", jugador.NickName);
            }

            if (MultiPhoton.instancia.Maestro() == true && MultiPhoton.instancia.ListaJugadores().Length >= 2)
            {
                ObjetosMultiSala.instancia.botonEmpezarPartida.interactable = true;
            }
            else
            {
                ObjetosMultiSala.instancia.botonEmpezarPartida.interactable = false;
            }
        }

        public void DejarSala()
        {
            MultiPhoton.instancia.DejarSala();

            ObjetosMultiSala.instancia.canvas.gameObject.SetActive(false);
            ObjetosMultiLobby.instancia.canvas.gameObject.SetActive(true);
        }

        public void EmpezarPartida()
        {
            MultiPhoton.instancia.photonView.RPC("AsignarCampo", RpcTarget.All, 0);
            MultiPartida.instancia.nivel = 0;

            ObjetosMultiSala.instancia.botonEmpezarPartida.interactable = false;
            MultiPhoton.instancia.photonView.RPC("CambiarEscena", RpcTarget.All, "Escenario");

            Room sala = MultiPhoton.instancia.Sala();
            sala.IsOpen = false;
        }
    }
}

