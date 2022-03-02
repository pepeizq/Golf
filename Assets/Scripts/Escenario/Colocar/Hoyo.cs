using UnityEngine;

namespace Escenario.Colocar
{
    public class Hoyo : MonoBehaviour
    {
        public static Hoyo instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Colocar(Casilla[,] casillas)
        {
            if (Objetos.instancia.hoyo != null)
            {
                if (casillas != null)
                {
                    int intentos = 100;
                    int i = 0;

                    while (i < intentos)
                    {
                        int x = Random.Range(Configuracion.instancia.tama�oX / 2 + Configuracion.instancia.tama�oX / 3, Configuracion.instancia.tama�oX - 5 - Escenario.instancia.limitesMapa);
                        int z = Random.Range(Configuracion.instancia.tama�oZ / 2 + Configuracion.instancia.tama�oZ / 3, Configuracion.instancia.tama�oZ - 5 - Escenario.instancia.limitesMapa);

                        if (casillas[x, z] != null)
                        {
                            if (casillas[x, z].id == 0 && casillas[x, z].modificable == true)
                            {
                                GameObject hoyo = Instantiate(Objetos.instancia.hoyo);
                                hoyo.transform.position = casillas[x, z].prefab.transform.position;

                                Destroy(casillas[x, z].prefab);
                                casillas[x, z].prefab = hoyo;
                                casillas[x, z].modificable = false;
                                break;
                            }
                            else
                            {
                                i -= 1;
                            }
                        }
                        else
                        {
                            i -= 1;
                        }

                        i += 1;
                    }
                }
            }
        }
    }
}