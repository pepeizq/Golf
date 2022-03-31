using Photon.Pun;

namespace Multijugador
{
    public class Conexiones : MonoBehaviourPunCallbacks
    {
        public static Conexiones instancia;

        public void Awake()
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }

        public void Start()
        {
         
        }

        public void Conectar()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        public void Desconectar()
        {
            PhotonNetwork.Disconnect();
        }

        public void UnirseLobby()
        {
            PhotonNetwork.JoinLobby();
        }

        public void CrearSala(string nombreSala)
        {
            PhotonNetwork.CreateRoom(nombreSala);
        }

        public void UnirseSala(string nombreSala)
        {
            PhotonNetwork.JoinRoom(nombreSala);
        }

        [PunRPC]
        public void CambiarEscena(string nombreEscena)
        {
            PhotonNetwork.LoadLevel(nombreEscena);
        }
    }
}