using Partida;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace Jugador
{
    public class MultiPhoton : MonoBehaviourPunCallbacks
    {
        public static MultiPhoton instancia;

        public void Awake()
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }

        public void Start()
        {
         
        }

        public bool Conectado()
        {
            return PhotonNetwork.IsConnected;
        }

        public bool Maestro()
        {
            return PhotonNetwork.IsMasterClient;
        }

        public void Conectar()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        public void Desconectar()
        {
            PhotonNetwork.LeaveLobby();
            PhotonNetwork.Disconnect();
        }

        public void Reconectar()
        {
            PhotonNetwork.Reconnect();
        }

        public void UnirseLobby()
        {
            PhotonNetwork.JoinLobby();
        }

        public void SalirLobby()
        {
            PhotonNetwork.LeaveLobby();
        }

        public bool EnLobby()
        {
            return PhotonNetwork.InLobby;
        }

        public void CrearSala(string nombreSala)
        {
            RoomOptions opciones = new RoomOptions
            {
                MaxPlayers = 4,
                CleanupCacheOnLeave = true,
                BroadcastPropsChangeToAll = true
            };

            PhotonNetwork.CreateRoom(nombreSala, opciones);
        }

        public void UnirseSala(string nombreSala)
        {
            PhotonNetwork.JoinRoom(nombreSala);
        }

        public void DejarSala()
        {
            PhotonNetwork.LeaveRoom();
        }

        public Room Sala()
        {
            return PhotonNetwork.CurrentRoom;
        }

        [PunRPC]
        public void CambiarEscena(string nombreEscena)
        {
            PhotonNetwork.LoadLevel(nombreEscena);
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        public void DestruirObjeto(GameObject objeto)
        {
            PhotonNetwork.Destroy(objeto);
        }

        public Player[] ListaJugadores()
        {
            return PhotonNetwork.PlayerList;
        }

        public Player JugadorLocal()
        {
            return PhotonNetwork.LocalPlayer;
        }

        public string CogerPropiedades(Player jugador, string propiedad)
        {
            return jugador.CustomProperties[propiedad].ToString();
        }

        public void ActualizarPropiedades(Player jugador, string propiedad, int contenido)
        {
            jugador.CustomProperties[propiedad] = contenido;
            PhotonNetwork.SetPlayerCustomProperties(jugador.CustomProperties);
        }

        public void ActualizarPropiedades(Player jugador, string propiedad, bool contenido)
        {
            jugador.CustomProperties[propiedad] = contenido;
            PhotonNetwork.SetPlayerCustomProperties(jugador.CustomProperties);
        }

        [PunRPC]
        public void AsignarCampo(int campo)
        {
            MultiPartida.instancia.campo = campo;
        }
    }
}