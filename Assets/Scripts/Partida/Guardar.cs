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

        public static void GuardarEscenario(List<Vector3> listado, int tama�oX, int tama�oZ)
        {
            if (listado != null)
            {
                if (listado.Count > 0)
                {
                    PartidaEscenario escenario = new PartidaEscenario();

                    PartidaCasilla[] casillas = new PartidaCasilla[listado.Count];

                    int i = 0;
                    foreach (Vector3 vector in listado)
                    {
                        casillas[i].coordenadas = new VectorTres(vector);
                        i += 1;
                    }

                    escenario.casillas = casillas;

                    PartidaTama�o tama�o = new PartidaTama�o
                    {
                        tama�oEscenarioX = tama�oX,
                        tama�oEscenarioZ = tama�oZ
                    };

                    escenario.tama�o = tama�o;

                    string datos = JsonUtility.ToJson(escenario);
                    PlayerPrefs.SetString(Configuracion.instancia.numeroPartida.ToString() + "escenario" + Configuracion.instancia.nivel.ToString(), datos);
                }
            }
        }

        public static void GuardarBola(Vector3 posicion, float angulo)
        {
            VectorTres posicion2 = new VectorTres(posicion);

            PartidaBola bola = new PartidaBola
            {
                posicion = posicion2,
                angulo = angulo
            };

            string datos = JsonUtility.ToJson(bola);
            PlayerPrefs.SetString(Configuracion.instancia.numeroPartida.ToString() + "bola" + Configuracion.instancia.nivel.ToString(), datos);
        }

        public static void GuardarHoyo(int casillaX, int casillaZ)
        {
            PartidaHoyo hoyo = new PartidaHoyo
            {
                casillaX = casillaX,
                casillaZ = casillaZ
            };

            string datos = JsonUtility.ToJson(hoyo);
            PlayerPrefs.SetString(Configuracion.instancia.numeroPartida.ToString() + "hoyo" + Configuracion.instancia.nivel.ToString(), datos);
        }

        public static void GuardarMordiscos(List<Vector2> casillas)
        {
            if (casillas != null)
            {
                if (casillas.Count > 0)
                {
                    PartidaMordiscos mordiscos = new PartidaMordiscos();
                    VectorDos[] mordiscos2 = new VectorDos[casillas.Count];

                    int i = 0;
                    foreach (Vector2 vector in casillas)
                    {
                        mordiscos2[i] = new VectorDos(vector);

                        i += 1;
                    }

                    mordiscos.mordiscos = mordiscos2;

                    string datos = JsonUtility.ToJson(mordiscos);
                    PlayerPrefs.SetString(Configuracion.instancia.numeroPartida.ToString() + "mordiscos" + Configuracion.instancia.nivel.ToString(), datos);
                }
            }
        }
    }
}