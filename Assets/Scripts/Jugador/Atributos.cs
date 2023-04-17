using UnityEngine;

namespace Jugador
{
    public class Atributos : MonoBehaviour
    {
        [Header("Bola")]
        public Color color;
        public int modelo;

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
