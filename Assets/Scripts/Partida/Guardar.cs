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

        public static void GuardarEscenario(List<Vector3> listado, int tamañoX, int tamañoZ)
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

                    PartidaTamaño tamaño = new PartidaTamaño
                    {
                        tamañoEscenarioX = tamañoX,
                        tamañoEscenarioZ = tamañoZ
                    };

                    escenario.tamaño = tamaño;

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
    }
}