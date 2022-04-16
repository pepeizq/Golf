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
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
