using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Escenario.Generacion
{
    public class Vectores : MonoBehaviour
    {
        public static Vectores instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void GenerarCasillas(Casilla[,] casillas, Vector2 extension, int alturaMaxima, int limitesMapa)
        {
            List<Vector3> listado = new List<Vector3>();

            int montañasGenerar = (int)extension.x / 10 * (int)extension.y / 10;
            int intentosGeneracion = montañasGenerar;

            int i = 1;
            while (i <= intentosGeneracion)
            {
                float alturaCasilla = (int)Random.Range(3, alturaMaxima);

                int posicionX = (int)Random.Range(0 + limitesMapa, (int)0 + (int)extension.x - limitesMapa);
                int posicionZ = (int)Random.Range(0 + limitesMapa, (int)0 + (int)extension.y - limitesMapa);

                bool añadir = true;

                foreach (Casilla casilla in casillas)
                {
                    if (casilla != null)
                    {
                        if (Enumerable.Range((int)(casilla.posicion.x - alturaCasilla), (int)(casilla.posicion.x + alturaCasilla)).Contains(posicionX))
                        {
                            if (Enumerable.Range((int)(casilla.posicion.z - alturaCasilla), (int)(casilla.posicion.z + alturaCasilla)).Contains(posicionZ))
                            {
                                añadir = false;

                                if (intentosGeneracion >= 0)
                                {
                                    intentosGeneracion -= 1;
                                    i -= 1;
                                }
                            }
                        }
                    }
                }

                if (Limites.Comprobar(posicionX, 2, (int)Escenario.instancia.tamañoEscenario.x) == false || Limites.Comprobar(posicionZ, 2, (int)Escenario.instancia.tamañoEscenario.y) == false)
                {
                    añadir = false;
                }

                if (añadir == true)
                {
                    listado.Add(new Vector3(posicionX, alturaCasilla, posicionZ));

                    int desplazamiento = 0;
                    while (alturaCasilla >= 1)
                    {
                        int planos = (int)Random.Range(0, 4 + desplazamiento);

                        if (desplazamiento > 0)
                        {
                            int j = 0;
                            while (j <= planos)
                            {
                                int x = 0;
                                int z = 0;

                                int azar = (int)Random.Range(0, 12);

                                if (azar == 1)
                                {
                                    x = 1 + (int)(desplazamiento * 2);
                                    z = 1 + (int)(desplazamiento * 2);
                                }
                                else if (azar == 2)
                                {
                                    x = 1 + (int)(desplazamiento * 2);
                                    z = -1 - (int)(desplazamiento * 2);
                                }
                                else if (azar == 3)
                                {
                                    x = -1 - (int)(desplazamiento * 2);
                                    z = 1 + (int)(desplazamiento * 2);
                                }
                                else if (azar == 4)
                                {
                                    x = -1 - (int)(desplazamiento * 2);
                                    z = -1 - (int)(desplazamiento * 2);
                                }
                                else if (azar == 5 || azar == 6)
                                {
                                    x = 2 + (int)(desplazamiento * 2);
                                    z = Random.Range(-desplazamiento, desplazamiento);
                                }
                                else if (azar == 7 || azar == 8)
                                {
                                    x = -2 - (int)(desplazamiento * 2);
                                    z = Random.Range(-desplazamiento, desplazamiento);
                                }
                                else if (azar == 9 || azar == 10)
                                {
                                    x = Random.Range(-desplazamiento, desplazamiento);
                                    z = 2 + (int)(desplazamiento * 2);
                                }
                                else if (azar == 11 || azar == 12)
                                {
                                    x = Random.Range(-desplazamiento, desplazamiento);
                                    z = -2 - (int)(desplazamiento * 2);
                                }

                                if (azar > 0)
                                {
                                    if (alturaCasilla == 1.5f || alturaCasilla == 2f)
                                    {
                                        for (int origenX = posicionX + x - 1; origenX < posicionX + x + 2; origenX++)
                                        {
                                            for (int origenZ = posicionZ + z - 1; origenZ < posicionZ + z + 2; origenZ++)
                                            {
                                                if (Limites.Comprobar(origenX, 2, (int)extension.x) == true && Limites.Comprobar(origenZ, 2, (int)extension.y) == true)
                                                {
                                                    if (casillas[origenX, origenZ] == null)
                                                    {
                                                        listado.Add(new Vector3(origenX, alturaCasilla, origenZ));
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (alturaCasilla == 1f)
                                    {
                                        for (int origenX = posicionX + x - 2; origenX < posicionX + x + 3; origenX++)
                                        {
                                            for (int origenZ = posicionZ + z - 2; origenZ < posicionZ + z + 3; origenZ++)
                                            {
                                                if (Limites.Comprobar(origenX, 2, (int)extension.x) == true && Limites.Comprobar(origenZ, 2, (int)extension.y) == true)
                                                {
                                                    if (casillas[origenX, origenZ] == null)
                                                    {
                                                        listado.Add(new Vector3(origenX, alturaCasilla, origenZ));
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Limites.Comprobar(posicionX + x, 2, (int)extension.x) == true && Limites.Comprobar(posicionZ + z, 2, (int)extension.y) == true)
                                        {
                                            listado.Add(new Vector3(posicionX + x, alturaCasilla, posicionZ + z));
                                        }
                                    }
                                }

                                j += 1;
                            }
                        }

                        alturaCasilla -= 0.5f;
                        desplazamiento += 1;
                    }
                }

                i += 1;
            }
        }
    }
}