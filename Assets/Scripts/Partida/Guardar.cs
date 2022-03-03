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
                    Datos partida = new Datos();

                    PartidaCasilla[] casillas = new PartidaCasilla[listado.Count];

                    int i = 0;
                    foreach (Vector3 vector in listado)
                    {
                        casillas[i].coordenadas = new VectorTres(vector);
                        i += 1;
                    }

                    partida.casillas = casillas;

                    PartidaEscenario escenario = new PartidaEscenario();
                    escenario.tama�oEscenarioX = tama�oX;
                    escenario.tama�oEscenarioZ = tama�oZ;

                    partida.escenario = escenario;

                    string datos = JsonUtility.ToJson(partida);
                    PlayerPrefs.SetString(Configuracion.instancia.numeroPartida.ToString() + "escenario" + Configuracion.instancia.nivel.ToString(), datos);
                }
            }
        }
    }
}