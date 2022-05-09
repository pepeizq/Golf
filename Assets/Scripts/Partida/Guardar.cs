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

        public static void GuardarPartida(Vector3 posicionBola, float angulo, int golpes, float zoom)
        {
            if (Multijugador.instancia.Conectado() == false)
            {
                DateTime fecha = DateTime.Now;
                int campo = Configuracion.instancia.campo.id;
                int nivel = Configuracion.instancia.nivel;
                int numeroPartida = Configuracion.instancia.numeroPartida;
                List<Vector3> casillasIniciales = Escenario.Escenario.instancia.casillasIniciales;
                int tamañoX = Configuracion.instancia.tamañoX;
                int tamañoZ = Configuracion.instancia.tamañoZ;
                int hoyoCasillaX = Configuracion.instancia.posicionHoyoX;
                int hoyoCasillaZ = Configuracion.instancia.posicionHoyoZ;

                VectorTres posicionBola2 = new VectorTres(posicionBola);

                PartidaMaestro partida = new PartidaMaestro
                {
                    posicion = posicionBola2,
                    angulo = angulo,
                    golpes = golpes,
                    zoom = zoom,
                    fecha = fecha.ToString(),
                    campo = campo,
                    nivel = nivel,
                    numeroPartida = numeroPartida
                };

                //----------------------------

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

                        partida.escenario = escenario;
                    }
                }

                //----------------------------

                PartidaHoyo hoyo = new PartidaHoyo
                {
                    casillaX = hoyoCasillaX,
                    casillaZ = hoyoCasillaZ
                };

                partida.hoyo = hoyo;

                //----------------------------

                List<PartidaRegistro> registroHoyos = null;
                
                try
                {
                    registroHoyos = Cargar.CargarPartida(Unjugador.instancia.partida.numeroPartida).registro;
                }
                catch (Exception ex)
                {

                }           

                if (registroHoyos == null)
                {
                    registroHoyos = new List<PartidaRegistro>();
                }

                PartidaRegistro registro = new PartidaRegistro
                {
                    hoyo = nivel,
                    golpes = golpes
                };

                registroHoyos.Add(registro);

                partida.registro = registroHoyos;

                //----------------------------

                string datos = JsonUtility.ToJson(partida);
                PlayerPrefs.SetString(numeroPartida.ToString() + "bola", datos);
                Unjugador.instancia.partida = partida;
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