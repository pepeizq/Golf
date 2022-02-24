using UnityEngine;

namespace Escenario.Generacion
{
    public class ColocarBola : MonoBehaviour
    {
        public static ColocarBola instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Colocar(Casilla[,] casillas)
        {
            if (Jugador.Movimiento.instancia.bola != null)
            {
                if (casillas != null)
                {
                    int intentos = 100;
                    int i = 0;
                   
                    while (i < intentos)
                    {
                        int x = Random.Range(5, 20);
                        int z = Random.Range(5, 20);

                        if (casillas[x, z] != null)
                        {
                            if (casillas[x, z].id == 0)
                            {
                                Vector3 posicion = casillas[x, z].prefab.gameObject.transform.position;
                                posicion.y = posicion.y + 1f;

                                GameObject bola = Instantiate(Jugador.Movimiento.instancia.bola);
                                bola.transform.position = casillas[x, z].prefab.transform.position;

                                Vector3 posicion2 = bola.transform.position;
                                posicion2.x = posicion2.x - 45f;
                                posicion2.z = posicion2.z - 45f;

                                Jugador.Movimiento.instancia.camara.transform.position = posicion2;
                                
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