using Photon.Pun;
using Photon.Realtime;

namespace Jugador
{
    public class Multijugador : MonoBehaviourPunCallbacks
    {
        public static Multijugador instancia;

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

        public void Conectar()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        public void Desconectar()
        {
            PhotonNetwork.LeaveLobby();
            PhotonNetwork.Disconnect();
        }

        public void UnirseLobby()
        {
            PhotonNetwork.JoinLobby();
        }

        public void CrearSala(string nombreSala)
        {
            RoomOptions opciones = new RoomOptions
            {
                MaxPlayers = 4,
                CleanupCacheOnLeave = true
            };

            PhotonNetwork.CreateRoom(nombreSala, opciones);
        }

        public void UnirseSala(string nombreSala)
        {
            PhotonNetwork.JoinRoom(nombreSala);
        }

        public Room Sala()
        {
            return PhotonNetwork.CurrentRoom;
        }

        [PunRPC]
        public void CambiarEscena(string nombreEscena)
        {
            PhotonNetwork.LoadLevel(nombreEscena);
        }
    }
}