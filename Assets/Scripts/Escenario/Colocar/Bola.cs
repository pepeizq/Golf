using Recursos;
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
                    if (Configuracion.instancia.aleatorio == true)
                    {
                        int perimetro = 5;
                        int proporcion = 4;
                        int intentos = 1000;
                        int i = 0;

                        while (i <= intentos)
                        {
                            int x = Random.Range(Escenario.instancia.limitesMapa + perimetro, Configuracion.instancia.tama�oX / proporcion);
                            int z = Random.Range(Escenario.instancia.limitesMapa + perimetro, Configuracion.instancia.tama�oZ / proporcion);

                            if (casillas[x, z] != null)
                            {
                                if (casillas[x, z].id == 0 && casillas[x, z].modificable == true)
                                {
                                    Vector3 posicion = casillas[x, z].prefab.gameObject.transform.position;
                                    InstanciarBola(posicion);
                                    casillas[x, z].modificable = false;
                                    break;
                                }
                            }

                            if (i == intentos)
                            {
                                i = 0;
                                proporcion -= 1;
                                perimetro -= 1;
                            }

                            i += 1;
                        }
                    }
                    else
                    {
                        InstanciarBola(Partida.Cargar.CargarBolaPosicion());
                    }                       
                }
            }
        }

        private void InstanciarBola(Vector3 posicion)
        {          
            GameObject bola = Instantiate(Objetos.instancia.bola);
            bola.transform.position = posicion;

            Vector3 posicion2 = bola.transform.position;

            if (Configuracion.instancia.camara == Configuracion.CamaraModos.Libre)
            {
                posicion2.x = posicion2.x - Configuracion.instancia.rotacionCamaraX;
                posicion2.z = posicion2.z - Configuracion.instancia.rotacionCamaraZ;
            }

            Objetos.instancia.camara.transform.position = posicion2;            
        }
    }
}