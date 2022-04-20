using Partida;
using UnityEngine;

namespace Jugador
{
    public class Unjugador : MonoBehaviour
    {
        public bool nuevaPartida;
        public PartidaMaestro partida;

        public static Unjugador instancia;

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
