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
                        int intentos = 100;
                        int i = 0;

                        while (i < intentos)
                        {
                            int x = Random.Range(Escenario.instancia.limitesMapa + 5, Configuracion.instancia.tamañoX / 4);
                            int z = Random.Range(Escenario.instancia.limitesMapa + 5, Configuracion.instancia.tamañoZ / 4);

                            if (casillas[x, z] != null)
                            {
                                if (casillas[x, z].id == 0 && casillas[x, z].modificable == true)
                                {
                                    Vector3 posicion = casillas[x, z].prefab.gameObject.transform.position;
                                    InstanciarBola(posicion);
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
                                i += 1;
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
                posicion2.x = posicion2.x - 41.7f;
                posicion2.z = posicion2.z - 41.7f;
            }

            Objetos.instancia.camara.transform.position = posicion2;            
        }
    }
}