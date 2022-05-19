using UnityEngine;

namespace Partida
{
    public class MultiPartida : MonoBehaviour
    {
        public int campo;
        public int nivel;

        public static MultiPartida instancia;

        public void Awake()
        {
            if (instancia == null)
            {
                instancia = this;
                DontDestroyOnLoad(this);
            }
            else if (this != instancia)
            {
                Destroy(gameObject);
            }
        }
    }
}