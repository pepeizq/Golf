using Escenario;
using Jugador;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Partida
{
    public class Guardar : MonoBehaviour
    {
        public static Guardar instancia;

        public void Awake()
        {
            instancia = this;
        }

        public static void GuardarForma(List<Vector2> casillas)
        {
            if (Multijugador.instancia.Conectado() == false)
            {
                if (casillas != null)
                {
                    if (casillas.Count > 0)
                    {
                        PartidaCoordenadas mordiscos = new PartidaCoordenadas();
                        VectorDos[] mordiscos2 = new VectorDos[casillas.Count];

                        int i = 0;
                        foreach (Vector2 vector in casillas)
                        {
                            mordiscos2[i] = new VectorDos(vector);

                            i += 1;
                        }

                        mordiscos.coordenada = mordiscos2;

                        string datos = JsonUtility.ToJson(mordiscos);
                        PlayerPrefs.SetString(Configuracion.instancia.numeroPartida.ToString() + "forma" + Configuracion.instancia.nivel.ToString(), datos);
                    }
                }
            }               
        }

        public static void GuardarMaestro(Vector3 posicion, float angulo, int golpes, float zoom, 
                                          DateTime fecha, int campo, int nivel, int numeroPartida, 
                                          List<Vector3> casillasIniciales, int tamañoX, int tamañoZ)
        {
            if (Multijugador.instancia.Conectado() == false)
            {
                VectorTres posicion2 = new VectorTres(posicion);

                PartidaMaestro bola = new PartidaMaestro
                {
                    posicion = posicion2,
                    angulo = angulo,
                    golpes = golpes,
                    zoom = zoom,
                    fecha = fecha.ToString(),
                    campo = campo,
                    nivel = nivel,
                    numeroPartida = numeroPartida
                };

                if (casillasIniciales != null)
                {
                    if (casillasIniciales.Count > 0)
                    {
                        PartidaEscenario escenario = new PartidaEscenario();
                        PartidaCasilla[] casillas = new PartidaCasilla[casillasIniciales.Count];

                        int i = 0;
                        foreach (Vector3 vector in casillasIniciales)
                        {
                            casillas[i].coordenadas = new VectorTres(vector);
                            i += 1;
                        }

                        escenario.casillas = casillas;

                        PartidaTamaño tamaño = new PartidaTamaño
                        {
                            tamañoEscenarioX = tamañoX,
                            tamañoEscenarioZ = tamañoZ
                        };

                        escenario.tamaño = tamaño;

                        bola.escenario = escenario;
                    }
                }

                string datos = JsonUtility.ToJson(bola);
                PlayerPrefs.SetString(numeroPartida.ToString() + "bola", datos);
                Unjugador.instancia.partida = bola;
            }
        }
       
        public static void GuardarHoyo(int casillaX, int casillaZ)
        {
            if (Multijugador.instancia.Conectado() == false)
            {
                PartidaHoyo hoyo = new PartidaHoyo
                {
                    casillaX = casillaX,
                    casillaZ = casillaZ
                };

                string datos = JsonUtility.ToJson(hoyo);
                PlayerPrefs.SetString(Configuracion.instancia.numeroPartida.ToString() + "hoyo" + Configuracion.instancia.nivel.ToString(), datos);
            }                
        }

        public static void GuardarMordiscos(List<Vector2> casillas)
        {
            if (Multijugador.instancia.Conectado() == false)
            {
                if (casillas != null)
                {
                    if (casillas.Count > 0)
                    {
                        PartidaCoordenadas mordiscos = new PartidaCoordenadas();
                        VectorDos[] mordiscos2 = new VectorDos[casillas.Count];

                        int i = 0;
                        foreach (Vector2 vector in casillas)
                        {
                            mordiscos2[i] = new VectorDos(vector);

                            i += 1;
                        }

                        mordiscos.coordenada = mordiscos2;

                        string datos = JsonUtility.ToJson(mordiscos);
                        PlayerPrefs.SetString(Configuracion.instancia.numeroPartida.ToString() + "mordiscos" + Configuracion.instancia.nivel.ToString(), datos);
                    }
                }
            }               
        }
    }
}