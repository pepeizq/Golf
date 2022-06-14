using UnityEngine;

namespace Partida
{
    public class MultiPartida : MonoBehaviour
    {
        public int campo = 0;
        public int nivel = 0;

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