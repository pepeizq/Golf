using Photon.Pun;
using Recursos;
using UnityEngine;

namespace Escenario.Colocar
{
    public class Bola : MonoBehaviourPunCallbacks
    {
        [HideInInspector] public Vector3 posicionMultijugador;
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

                                    if (PhotonNetwork.IsConnected == false)
                                    {
                                        InstanciarBola(posicion);
                                    }
                                    else
                                    {
                                        if (PhotonNetwork.IsMasterClient == true)
                                        {
                                            Configuracion.instancia.photonView.RPC("MultijugadorPosicionInicioBola", RpcTarget.All, posicion);
                                        }                                           
                                    }
                                        
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
                        if (Configuracion.instancia.juegoModo == Configuracion.JuegoModo.UnJugador)
                        {
                            InstanciarBola(Partida.Cargar.CargarBolaPosicion());
                        }                            
                    }                       
                }
            }
        }

        public void InstanciarBola(Vector3 posicion)
        {          
            if (PhotonNetwork.IsConnected == false)
            {
                GameObject bola = Instantiate(Objetos.instancia.bola);
                bola.transform.position = posicion;

                Vector3 posicion2 = bola.transform.position;

                if (Configuracion.instancia.camara == Configuracion.CamaraModos.Libre)
                {
                    posicion2.x = posicion2.x - Configuracion.instancia.rotacionCamaraX;
                    posicion2.z = posicion2.z - Configuracion.instancia.rotacionCamaraZ;
                }

                Jugador.Bola.instancia.transform.GetChild(0).gameObject.transform.position = posicion2;
            }
            else
            {
                GameObject bola = PhotonNetwork.Instantiate("Prefab Bola", posicion, Quaternion.identity);
                bola.transform.position = Configuracion.instancia.posicionInicioBola;

                Jugador.Bola bola2 = bola.gameObject.GetComponent<Jugador.Bola>();
                bola2.photonView.RPC("Arranque", RpcTarget.All, PhotonNetwork.LocalPlayer);

                bola.transform.GetChild(0).gameObject.transform.position = bola.transform.position;
            }
        }

        [PunRPC]
        public void PosicionMultijugador(Vector3 posicion)
        {
            posicionMultijugador = posicion;
        }
    }
}