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

        public void Generar(Casilla[,] casillas, float altura)
        {
            //Forma forma = null;
            int rango = 3;

            for (int x = 0; x < casillas.GetLength(0); x++)
            {
                for (int z = 0; z < casillas.GetLength(1); z++)
                {
                    if (casillas[x, z] == null)
                    {
                        bool poner = false;
                       
                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x - rango, z - rango);

                            if (poner == true)
                            {
                                //forma = casillas[x - rango, z - rango].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x - rango, z);

                            if (poner == true)
                            {
                                //forma = casillas[x - rango, z].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x, z - rango);

                            if (poner == true)
                            {
                                //forma = casillas[x, z - rango].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x + rango, z - rango);

                            if (poner == true)
                            {
                                //forma = casillas[x + rango, z - rango].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x - rango, z + rango);

                            if (poner == true)
                            {
                                //forma = casillas[x - rango, z + rango].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x, z + rango);

                            if (poner == true)
                            {
                                //forma = casillas[x, z + rango].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x + rango, z);

                            if (poner == true)
                            {
                                //forma = casillas[x + rango, z].isla;
                            }
                        }

                        if (poner == false)
                        {
                            poner = VerificarPoner(casillas, x + rango, z + rango);

                            if (poner == true)
                            {
                                //forma = casillas[x + rango, z + rango].isla;
                            }
                        }
              
                        if (poner == true)
                        {
                            //Casilla plano = new Casilla(forma.casillas[0].id, 0, new Vector3(x, altura, z));
                            //plano.isla = forma;
                            //Escenario.instancia.PonerCasilla(plano);
                        }
                    }
                }
            }
        }

        private bool VerificarPoner(Casilla[,] casillas, int x, int z)
        {
            if (Limites.Comprobar(x, 2, (int)Escenario.instancia.tamañoEscenario.x) == true && Limites.Comprobar(z, 2, (int)Escenario.instancia.tamañoEscenario.y) == true)
            {
                if (casillas[x, z] != null)
                {
                    if (casillas[x, z].posicion.y > 1f)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}