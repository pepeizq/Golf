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
                    int intentos = 10000;
                    int i = 0;

                    while (i < intentos)
                    {
                        int x = Random.Range(Configuracion.instancia.tamañoX / 2, Configuracion.instancia.tamañoX - 5);
                        int z = Random.Range(Configuracion.instancia.tamañoZ / 2, Configuracion.instancia.tamañoZ - 5);

                        if (casillas[x, z] != null)
                        {
                            if (casillas[x, z].id == 0)
                            {
                                GameObject hoyo = Instantiate(Objetos.instancia.hoyo);
                                Vector3 posicion = casillas[x, z].prefab.transform.position;
                                //posicion.y = posicion.y - 0f;
                                hoyo.transform.position = posicion;

                                Destroy(casillas[x, z].prefab);
                                casillas[x, z].prefab = hoyo;

                                break;
                            }
                        }
                        i += 1;
                    }
                }
            }
        }
    }
}