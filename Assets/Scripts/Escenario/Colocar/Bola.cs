using UnityEngine;

namespace Escenario.Colocar
{
    public class Bola : MonoBehaviour
    {
        public static Bola instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Colocar(Casilla[,] casillas)
        {
            if (Objetos.instancia.bola != null)
            {
                if (casillas != null)
                {
                    int intentos = 10000;
                    int i = 0;
                   
                    while (i < intentos)
                    {
                        int x = Random.Range(5, Configuracion.instancia.tamañoX / 4);
                        int z = Random.Range(5, Configuracion.instancia.tamañoZ / 4);

                        if (casillas[x, z] != null)
                        {
                            if (casillas[x, z].id == 0)
                            {
                                Vector3 posicion = casillas[x, z].prefab.gameObject.transform.position;
                                posicion.y = posicion.y + 1f;

                                GameObject bola = Instantiate(Objetos.instancia.bola);
                                bola.transform.position = casillas[x, z].prefab.transform.position;

                                Vector3 posicion2 = bola.transform.position;

                                if (Configuracion.instancia.camara == Configuracion.CamaraModos.Libre)
                                {
                                    posicion2.x = posicion2.x - 40f;
                                    posicion2.z = posicion2.z - 40f;
                                }

                                Objetos.instancia.camara.transform.position = posicion2;
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