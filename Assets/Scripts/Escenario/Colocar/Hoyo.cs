using Jugador;
using Partida;
using Photon.Pun;
using Recursos;
using UnityEngine;

namespace Escenario.Colocar
{
    public class Hoyo : MonoBehaviourPunCallbacks
    {
        public static Hoyo instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Colocar(Casilla[,] casillas, int tamañoX, int tamañoZ)
        {
            bool buscarPosicion = true;
      
            if (MultiPhoton.instancia.Conectado() == true && MultiPhoton.instancia.Maestro() == false)
            {
                buscarPosicion = false;
            }

            if (buscarPosicion == true && Configuracion.instancia.campo.hoyo != null)
            {
                if (casillas != null)
                {
                    if (Configuracion.instancia.aleatorio == true)
                    {
                        int perimetro = 5;
                        int proporcion = 3;
                        int intentos = 1000;
                        int i = 0;

                        while (i <= intentos)
                        {
                            int x = Random.Range(tamañoX / 2 + tamañoX / proporcion, tamañoX - perimetro - Escenario.instancia.limitesMapa);
                            int z = Random.Range(tamañoZ / 2 + tamañoZ / proporcion, tamañoZ - perimetro - Escenario.instancia.limitesMapa);

                            if (casillas[x, z] != null)
                            {
                                if (casillas[x, z].id == 0 && casillas[x, z].modificable == true)
                                {
                                    if (MultiPhoton.instancia.Conectado() == false)
                                    {
                                        InstanciarHoyo(casillas, x, z);
                                    }
                                    else
                                    {
                                        if (MultiPhoton.instancia.Maestro() == true)
                                        {
                                            int[] posiciones = new int[2];
                                            posiciones[0] = x;
                                            posiciones[1] = z;
                                        
                                            Configuracion.instancia.photonView.RPC("MultijugadorPosicionInicioHoyo", RpcTarget.All, posiciones);
                                        }

                                        InstanciarHoyo(casillas, x, z);
                                    }
       
                                    break;
                                }
                            }

                            if (i == intentos)
                            {
                                i = 0;
                                proporcion += 1;
                                perimetro -= 1;
                            }

                            i += 1;
                        }
                    }
                    else
                    {
                        PartidaHoyo hoyo = Cargar.CargarPartida(Unjugador.instancia.partida.numeroPartida).hoyo;
                        InstanciarHoyo(casillas, hoyo.casillaX, hoyo.casillaZ);
                    }                       
                }
            }
        }

  
        public void InstanciarHoyo(Casilla[,] casillas, int casillaX, int casillaZ)
        {
            if (MultiPhoton.instancia.Conectado() == false)
            {
                GameObject hoyo = Instantiate(Configuracion.instancia.campo.hoyo);
                hoyo.transform.position = casillas[casillaX, casillaZ].prefab.transform.position;
      
                Configuracion.instancia.posicionHoyo = hoyo.transform.localPosition;
                Configuracion.instancia.posicionHoyoX = casillaX;
                Configuracion.instancia.posicionHoyoZ = casillaZ;

                Destroy(casillas[casillaX, casillaZ].prefab);
                casillas[casillaX, casillaZ].prefab = hoyo;
                casillas[casillaX, casillaZ].modificable = false;
            }
            else
            {
                Vector3 posicion = casillas[Configuracion.instancia.multiPosicionXHoyo, Configuracion.instancia.multiPosicionZHoyo].posicion;
                GameObject hoyo = PhotonNetwork.Instantiate("Prefabs/Prefab Hoyo 1", posicion, Quaternion.identity);
           
                Configuracion.instancia.posicionHoyo = posicion;
                Configuracion.instancia.posicionHoyoX = Configuracion.instancia.multiPosicionXHoyo;
                Configuracion.instancia.posicionHoyoZ = Configuracion.instancia.multiPosicionZHoyo;

                PhotonNetwork.Destroy(casillas[casillaX, casillaZ].prefab);
                casillas[casillaX, casillaZ].prefab = hoyo;
                casillas[casillaX, casillaZ].modificable = false;
            }
        }
    }
}