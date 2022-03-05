using System.Collections.Generic;
using UnityEngine;

namespace Partida
{
    public class Cargar : MonoBehaviour
    {
        public static Cargar instancia;

        public void Awake()
        {
            instancia = this;
        }

        public static List<Vector3> CargarEscenario()
        {
            PartidaEscenario partida = JsonUtility.FromJson<PartidaEscenario>(PlayerPrefs.GetString(Configuracion.instancia.numeroPartida.ToString() + "escenario" + Configuracion.instancia.nivel.ToString()));
            List<Vector3> listado = new List<Vector3>();

            foreach (PartidaCasilla casilla in partida.casillas)
            {
                Vector3 casilla2 = casilla.coordenadas.ObtenerVector3();
                listado.Add(casilla2);
            }

            return listado;
        }

        public static Vector3 CargarBolaPosicion()
        {
            PartidaBola bola = JsonUtility.FromJson<PartidaBola>(PlayerPrefs.GetString(Configuracion.instancia.numeroPartida.ToString() + "bola" + Configuracion.instancia.nivel.ToString()));
            Vector3 posicion2 = bola.posicion.ObtenerVector3();
            return posicion2;
        }

        public static float CargarBolaRotacion()
        {
            PartidaBola bola = JsonUtility.FromJson<PartidaBola>(PlayerPrefs.GetString(Configuracion.instancia.numeroPartida.ToString() + "bola" + Configuracion.instancia.nivel.ToString()));
            return bola.angulo;
        }

        public static PartidaHoyo CargarHoyo()
        {
            return JsonUtility.FromJson<PartidaHoyo>(PlayerPrefs.GetString(Configuracion.instancia.numeroPartida.ToString() + "hoyo" + Configuracion.instancia.nivel.ToString()));
        }

        public static List<Vector2> CargarMordiscos()
        {
            PartidaMordiscos mordiscos = JsonUtility.FromJson<PartidaMordiscos>(PlayerPrefs.GetString(Configuracion.instancia.numeroPartida.ToString() + "mordiscos" + Configuracion.instancia.nivel.ToString()));
            
            if (mordiscos != null)
            {
                List<Vector2> listado = new List<Vector2>();

                foreach (VectorDos casilla in mordiscos.mordiscos)
                {
                    Vector2 casilla2 = casilla.ObtenerVector2();
                    listado.Add(casilla2);
                }

                return listado;
            }
            else
            {
                return null;
            }
        }
    }
}