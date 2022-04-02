using UnityEngine;

namespace Jugador
{
    public class Atributos : MonoBehaviour
    {
        public UnityEngine.Color color;

        public static Atributos instancia;

        public void Awake()
        {
            instancia = this;
            DontDestroyOnLoad(instancia);
        }
    }
}
