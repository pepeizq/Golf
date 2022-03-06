using Recursos;
using System.Collections.Generic;
using UnityEngine;

namespace Escenario.Colocar
{
    public class Forma : MonoBehaviour
    {
        public static Forma instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Formar(HoyoFormas forma, Casilla[,] casillas)
        {
            if (casillas != null)
            {
                if (Configuracion.instancia.aleatorio == true)
                {
                    if (forma == HoyoFormas.Jota50)
                    {
                        List<Vector2> guardar = new List<Vector2>();

                        int puntoX = (Configuracion.instancia.tamañoX - Escenario.instancia.limitesMapa * 2) / 2;
                        int puntoZ = (Configuracion.instancia.tamañoZ - Escenario.instancia.limitesMapa * 2) / 2;

                        for (int x = Escenario.instancia.limitesMapa; x <= puntoX; x++)
                        {
                            for (int z = puntoZ; z <= Configuracion.instancia.tamañoZ - Escenario.instancia.limitesMapa; z++)
                            {
                                InstanciarForma(casillas, x, z);
                                guardar.Add(new Vector2(x, z));
                            }
                        }

                        Partida.Guardar.GuardarForma(guardar);
                    }
                    else if (forma == HoyoFormas.Jota33)
                    {
                        List<Vector2> guardar = new List<Vector2>();

                        int puntoX = (Configuracion.instancia.tamañoX - Escenario.instancia.limitesMapa * 2) / 2;
                        int puntoZ = (Configuracion.instancia.tamañoZ - Escenario.instancia.limitesMapa * 2) / 3;
                  
                        for (int x = Escenario.instancia.limitesMapa; x <= puntoX; x++)
                        {
                            for (int z = puntoZ; z <= Configuracion.instancia.tamañoZ - Escenario.instancia.limitesMapa; z++)
                            {
                                InstanciarForma(casillas, x, z);
                                guardar.Add(new Vector2(x, z));
                            }
                        }

                        Partida.Guardar.GuardarForma(guardar);
                    }
                    else if (forma == HoyoFormas.Jota66)
                    {
                        List<Vector2> guardar = new List<Vector2>();

                        int puntoX = (Configuracion.instancia.tamañoX - Escenario.instancia.limitesMapa * 2) / 3;
                        int puntoZ = (Configuracion.instancia.tamañoZ - Escenario.instancia.limitesMapa * 2) / 2;

                        for (int x = Escenario.instancia.limitesMapa; x <= puntoX; x++)
                        {
                            for (int z = puntoZ; z <= Configuracion.instancia.tamañoZ - Escenario.instancia.limitesMapa; z++)
                            {
                                InstanciarForma(casillas, x, z);
                                guardar.Add(new Vector2(x, z));
                            }
                        }

                        Partida.Guardar.GuardarForma(guardar);
                    }
                }
                else
                {
                    if (forma != HoyoFormas.SinTocar)
                    {
                        List<Vector2> listado = Partida.Cargar.CargarForma();

                        if (listado != null)
                        {
                            if (listado.Count > 0)
                            {
                                foreach (Vector2 vector in listado)
                                {
                                    InstanciarForma(casillas, (int)vector.x, (int)vector.y);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void InstanciarForma(Casilla[,] casillas, int x, int z)
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
    
