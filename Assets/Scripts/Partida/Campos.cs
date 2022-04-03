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
            instancia = this;
            DontDestroyOnLoad(instancia);
        }
    }
}