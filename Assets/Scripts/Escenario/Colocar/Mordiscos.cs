using UnityEngine;

namespace Escenario.Colocar
{
    public class Mordiscos : MonoBehaviour
    {
        [HideInInspector] public int intentos = 2;

        public static Mordiscos instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Colocar(Casilla[,] casillas)
        {
            if (casillas != null)
            {
                int i = 0;

                while (i < instancia.intentos)
                {
                    int azarX = Random.Range(Configuracion.instancia.tamañoX / 4, Configuracion.instancia.tamañoX / 4 * 3);
                    int azarZ = Random.Range(Configuracion.instancia.tamañoZ / 4, Configuracion.instancia.tamañoZ / 4 * 3);

                    for (int a = azarX - 2; a <= azarX + 2; a++)
                    {
                        for (int b = azarZ - 2; b <= azarZ + 2; b++)
                        {
                            if (casillas[a, b] != null)
                            {
                                if (casillas[a, b].modificable == true)
                                {
                                    Destroy(casillas[a, b].prefab);
                                    casillas[a, b].modificable = false;
                                }
                            }
                        }
                    }

                    i += 1;
                }                   
            }
        }
    }
}

