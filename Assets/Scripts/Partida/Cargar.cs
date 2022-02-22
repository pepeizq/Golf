using Escenario;
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

        public void CargarDatos()
        {
            Datos partida = JsonUtility.FromJson<Datos>(PlayerPrefs.GetString("Guardar"));

            //------------------------------------------------

            Casillas(partida);

        }


        private void Casillas(Datos partida)
        {
            Escenario.Escenario.instancia.casillasMapa = new Casilla[partida.escenario.tamañoEscenarioX, partida.escenario.tamañoEscenarioZ];

            int i = 0;
            while (i < partida.casillas.Length)
            {
                int idCasilla = partida.casillas[i].idCasilla;
                               
                if (idCasilla > -1)
                {                 
                    Vector3 posicionFinal = partida.casillas[i].coordenadas.ObtenerVector3();
                    int x = (int)posicionFinal.x;
                    int z = (int)posicionFinal.z;

                    GameObject casilla2 = Instantiate(Escenario.Escenario.instancia.casillasFinal[idCasilla].prefab, posicionFinal, Quaternion.identity);
                    casilla2.gameObject.transform.Rotate(Vector3.up, partida.casillas[i].rotacion, Space.World);
        
                    Casilla casilla3 = new Casilla(idCasilla, partida.casillas[i].rotacion, partida.casillas[i].coordenadas.ObtenerVector3());
                    casilla3.id = idCasilla;
                    casilla3.prefab = casilla2;
                    casilla3.prefab.gameObject.layer = LayerMask.NameToLayer("Terreno");

                    Escenario.Escenario.instancia.casillasMapa[x, z] = casilla3;
                }

                i += 1;
            }
        }
    }
}