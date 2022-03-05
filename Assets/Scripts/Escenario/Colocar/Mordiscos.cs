using Recursos;
using System.Collections.Generic;
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
                if (Configuracion.instancia.aleatorio == true)
                {
                    List<Vector2> guardar = new List<Vector2>();
                    int i = 0;

                    while (i < instancia.intentos)
                    {
                        int azarX = Random.Range(Configuracion.instancia.tamañoX / 4, Configuracion.instancia.tamañoX / 4 * 3);
                        int azarZ = Random.Range(Configuracion.instancia.tamañoZ / 4, Configuracion.instancia.tamañoZ / 4 * 3);

                        for (int a = azarX - 2; a <= azarX + 2; a++)
                        {
                            for (int b = azarZ - 2; b <= azarZ + 2; b++)
                            {
                                InstanciarMordisco(casillas, a, b);
                                guardar.Add(new Vector2(a, b));
                            }
                        }

                        i += 1;
                    }

                    Partida.Guardar.GuardarMordiscos(guardar);
                }
                else
                {
                    List<Vector2> listado = Partida.Cargar.CargarMordiscos();

                    if (listado != null)
                    {
                        if (listado.Count > 0)
                        {
                            foreach (Vector2 vector in listado)
                            {
                                InstanciarMordisco(casillas, (int)vector.x, (int)vector.y);
                            }
                        }
                    }
                }
            }
        }

        private void InstanciarMordisco(Casilla[,] casillas, int x, int z)
        {
            if (casillas[x, z] != null)
            {
                if (casillas[x, z].modificable == true)
                {
                    Destroy(casillas[x, z].prefab);
                    casillas[x, z].modificable = false;
                }
            }
        }
    }
}

