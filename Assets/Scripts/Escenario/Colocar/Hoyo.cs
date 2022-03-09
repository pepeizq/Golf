using Partida;
using Recursos;
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
                    if (Configuracion.instancia.aleatorio == true)
                    {
                        int proporcion = 3;
                        int intentos = 1000;
                        int i = 0;

                        while (i < intentos)
                        {
                            int x = Random.Range(Configuracion.instancia.tama�oX / 2 + Configuracion.instancia.tama�oX / proporcion, Configuracion.instancia.tama�oX - 2 - Escenario.instancia.limitesMapa);
                            int z = Random.Range(Configuracion.instancia.tama�oZ / 2 + Configuracion.instancia.tama�oZ / proporcion, Configuracion.instancia.tama�oZ - 2 - Escenario.instancia.limitesMapa);

                            if (casillas[x, z] != null)
                            {
                                if (casillas[x, z].id == 0 && casillas[x, z].modificable == true)
                                {
                                    InstanciarHoyo(casillas, x, z);
                                    Guardar.GuardarHoyo(x, z);
                                    break;
                                }
                            }

                            i += 1;

                            if (i == intentos)
                            {
                                i = 0;
                                proporcion += 1;
                            }
                        }
                    }
                    else
                    {
                        PartidaHoyo hoyo = Cargar.CargarHoyo();
                        InstanciarHoyo(casillas, hoyo.casillaX, hoyo.casillaZ);
                    }                       
                }
            }
        }

        private void InstanciarHoyo(Casilla[,] casillas, int casillaX, int casillaZ)
        {
            GameObject hoyo = Instantiate(Objetos.instancia.hoyo);
            hoyo.transform.position = casillas[casillaX, casillaZ].prefab.transform.position;

            Destroy(casillas[casillaX, casillaZ].prefab);
            casillas[casillaX, casillaZ].prefab = hoyo;
            casillas[casillaX, casillaZ].modificable = false;
        }
    }
}