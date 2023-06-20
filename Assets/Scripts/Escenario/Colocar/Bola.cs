using Jugador;
using Partida;
using Photon.Pun;
using Recursos;
using UnityEngine;

namespace Escenario.Colocar
{
    public class Bola : MonoBehaviourPunCallbacks
    {
        public static Bola instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Colocar(Casilla[,] casillas, CampoTipo campoTipo)
        {
            bool buscarPosicion = true;

            if (MultiPhoton.instancia != null)
            {
                if (MultiPhoton.instancia.Conectado() == true && PhotonNetwork.IsMasterClient == false)
                {
                    buscarPosicion = false;
                }
            }

            if (buscarPosicion == true && Configuracion.instancia.bolaObjeto != null)
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
                            int x = Random.Range(Escenario.instancia.limitesMapa + perimetro, Configuracion.instancia.tamañoX / proporcion);
                            int z = Random.Range(Escenario.instancia.limitesMapa + perimetro, Configuracion.instancia.tamañoZ / proporcion);

                            if (casillas[x, z] != null)
                            {
                                if (casillas[x, z].id == 0 && casillas[x, z].modificable == true)
                                {
                                    Vector3 posicion = casillas[x, z].prefab.gameObject.transform.position;

                                    if (MultiPhoton.instancia != null)
                                    {
                                        if (MultiPhoton.instancia.Conectado() == false)
                                        {
                                            InstanciarBola(posicion, campoTipo);
                                        }
                                        else
                                        {
                                            if (MultiPhoton.instancia.Maestro() == true)
                                            {
                                                Configuracion.instancia.photonView.RPC("MultijugadorPosicionInicioBola", RpcTarget.All, posicion);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Unjugador.instancia == null)
                                        {
                                            InstanciarBola(posicion, campoTipo);
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
                        if (Unjugador.instancia != null)
                        {
                            InstanciarBola(Unjugador.instancia.partida.posicion.ObtenerVector3(), campoTipo);
                        }
                    }                       
                }
            }
        }

        public void InstanciarBola(Vector3 posicion, CampoTipo campoTipo)
        {
            GameObject bola = Instantiate(Configuracion.instancia.bolaObjeto);
            bola.transform.position = posicion;
            
            Vector3 posicion2 = bola.transform.position;
            Configuracion.instancia.camaraObjeto.transform.position = posicion2;

            //--------------------------------

            if (campoTipo == CampoTipo.Verde)
            {

            }
        }

        public void InstanciarBolaMulti(Vector3 posicion, CampoTipo campoTipo)
        {
            GameObject bola = PhotonNetwork.Instantiate("Prefabs/Prefab Bola", posicion, Quaternion.identity);
            Vector3 nuevaPosicion = Configuracion.instancia.multiPosicionBolaInicio;
            bola.transform.position = nuevaPosicion;

            Jugador.Bola bola2 = bola.transform.GetChild(0).gameObject.GetComponent<Jugador.Bola>();
            bola2.photonView.RPC("Arranque", RpcTarget.All, MultiPhoton.instancia.JugadorLocal());

            Configuracion.instancia.camaraObjeto.transform.position = bola.transform.position;

            //--------------------------------

            if (campoTipo == CampoTipo.Verde)
            {

            }
        }
    }
}