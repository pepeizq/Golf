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
            Datos partida = JsonUtility.FromJson<Datos>(PlayerPrefs.GetString(Configuracion.instancia.numeroPartida.ToString() + "escenario" + Configuracion.instancia.nivel.ToString()));
            List<Vector3> listado = new List<Vector3>();

            foreach (PartidaCasilla casilla in partida.casillas)
            {
                Vector3 casilla2 = casilla.coordenadas.ObtenerVector3();
                listado.Add(casilla2);
            }

            return listado;
        }
    }
}