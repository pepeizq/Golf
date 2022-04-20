using UnityEngine;

namespace Jugador
{
    public class Atributos : MonoBehaviour
    {
        public UnityEngine.Color color;

        public static Atributos instancia;

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

        public void Start()
        {
       
        }
    }
}
