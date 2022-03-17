using Unity.Netcode;
using UnityEngine;

namespace Jugador
{
    //https://docs-multiplayer.unity3d.com/docs/tutorials/helloworld/helloworldtwo
    public class Multijugador : NetworkBehaviour
    {
        public static Multijugador instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Servidor()
        {
            NetworkManager.Singleton.StartServer();
        }

        public void Hospedador()
        {
            NetworkManager.Singleton.StartHost();
        }

        public void Cliente()
        {
            NetworkManager.Singleton.StartClient();
        }
    }
}

