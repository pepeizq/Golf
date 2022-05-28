using Recursos;
using System.Collections.Generic;
using UnityEngine;

namespace Partida
{
    public class Datos : MonoBehaviour
    {
        public List<Mesh> bolas;
        public List<Campo> campos;

        public static Datos instancia;

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