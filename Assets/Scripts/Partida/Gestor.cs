using Escenario;
using UnityEngine;

namespace Partida
{
    public class Gestor : MonoBehaviour
    {
        public bool nuevaPartida;

        [HideInInspector] public Casilla[] casillas;

        public static Gestor instancia;

        public void Awake()
        {
            instancia = this;

            casillas = Resources.LoadAll<Casilla>("Casillas");
        }

        public void Start()
        {
            if (nuevaPartida == false)
            {
                //Cargar.instancia.CargarDatos();
            }
        }

    }
}

