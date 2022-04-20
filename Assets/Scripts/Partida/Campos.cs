using Recursos;
using System.Collections.Generic;
using UnityEngine;

namespace Partida
{
    public class Campos : MonoBehaviour
    {
        public List<Campo> campos;

        public static Campos instancia;

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