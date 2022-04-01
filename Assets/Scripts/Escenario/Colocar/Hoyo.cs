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

        public void Colocar(Casilla[,] casillas)
        {
            bool buscarPosicion = true;

            if (PhotonNetwork.IsConnected == true && PhotonNetwork.IsMasterClient == false)
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
                            int x = Random.Range(Configuracion.instancia.tamañoX / 2 + Configuracion.instancia.tamañoX / proporcion, Configuracion.instancia.tamañoX - perimetro - Escenario.instancia.limitesMapa);
                            int z = Random.Range(Configuracion.instancia.tamañoZ / 2 + Configuracion.instancia.tamañoZ / proporcion, Configuracion.instancia.tamañoZ - perimetro - Escenario.instancia.limitesMapa);

                            if (casillas[x, z] != null)
                            {
                                if (casillas[x, z].id == 0 && casillas[x, z].modificable == true)
                                {
                                    if (PhotonNetwork.IsConnected == false)
                                    {
                                        InstanciarHoyo(casillas, x, z);
                                    }
                                    else
                                    {
                                        if (PhotonNetwork.IsMasterClient == true)
                                        {
                                            int[] posiciones = new int[2];
                                            posiciones[0] = x;
                                            posiciones[1] = z;
                                        
                                            Configuracion.instancia.photonView.RPC("MultijugadorPosicionInicioHoyo", RpcTarget.All, posiciones);
                                        }

                                        InstanciarHoyo(casillas, x, z);
                                    }

                                    Guardar.GuardarHoyo(x, z);
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
                        PartidaHoyo hoyo = Cargar.CargarHoyo();
                        InstanciarHoyo(casillas, hoyo.casillaX, hoyo.casillaZ);
                    }                       
                }
            }
        }

  
        public void InstanciarHoyo(Casilla[,] casillas, int casillaX, int casillaZ)
        {
            if (PhotonNetwork.IsConnected == false)
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
           
                Configuracion.instancia.posicionHoyo = hoyo.transform.localPosition;
                Configuracion.instancia.posicionHoyoX = Configuracion.instancia.multiPosicionXHoyo;
                Configuracion.instancia.posicionHoyoZ = Configuracion.instancia.multiPosicionZHoyo;

                PhotonNetwork.Destroy(casillas[casillaX, casillaZ].prefab);
                casillas[casillaX, casillaZ].prefab = hoyo;
                casillas[casillaX, casillaZ].modificable = false;
            }
        }
    }
}