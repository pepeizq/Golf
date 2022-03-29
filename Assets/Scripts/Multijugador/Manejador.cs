using Photon.Pun;

namespace Multijugador
{
    public class Manejador : MonoBehaviourPunCallbacks
    {
        public static Manejador instancia;

        public void Awake()
        {
            if (instancia != null && instancia != this)
            {
                gameObject.SetActive(false);
            }
            else
            {
                instancia = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        public void Start()
        {
            //PhotonNetwork.ConnectUsingSettings();
        }

        public void CrearSala(string nombreSala)
        {
            PhotonNetwork.CreateRoom(nombreSala);
        }

        public override void OnCreatedRoom()
        {
      
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