using UnityEngine;

namespace Escenario.Generacion
{
    public class Llano : MonoBehaviour
    {
        public static Llano instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Generar(Casilla[,] casillas, float altura, Casilla plano)
        {
            for (int x = 0; x < casillas.GetLength(0); x++)
            {
                for (int z = 0; z < casillas.GetLength(1); z++)
                {
                    if (casillas[x, z] == null)
                    {
                        Casilla plano2 = new Casilla(plano.id, 0, new Vector3(x, altura, z));
                        Escenario.instancia.PonerCasilla(plano2);
                    }
                }
            }
        }
    }
}