using Unity.Netcode;
using UnityEngine;

namespace Jugador
{
    //https://docs-multiplayer.unity3d.com/docs/tutorials/helloworld/helloworldtwo
    //https://github.com/DapperDino/Unity-Multiplayer-Tutorials/tree/main/Assets/Tutorials

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

        //[ServerRpc]
        //public void GenerarBolaServidor(NetworkObject prefab, Vector3 posicion)
        //{
        //    NetworkObject bola = Instantiate(prefab, posicion, Quaternion.identity);
        //    bola.SpawnWithOwnership(OwnerClientId);
        //}

    }
}

