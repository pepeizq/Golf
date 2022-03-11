using Recursos;
using UnityEngine;

namespace Escenario.Colocar
{
    public class Muros : MonoBehaviour
    {
        public static Muros instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Colocar(Casilla[,] casillas)
        {
            if (casillas != null)
            {
                if (Configuracion.instancia.campo.muros != null)
                {
                    int posicionHoyoX = Configuracion.instancia.posicionHoyoX;
                    int posicionHoyoZ = Configuracion.instancia.posicionHoyoZ;

                    if (casillas[posicionHoyoX, posicionHoyoZ + 2] != null)
                    {
                        if (casillas[posicionHoyoX, posicionHoyoZ + 2].id == 0 && casillas[posicionHoyoX, posicionHoyoZ + 2].modificable == true)
                        {
                            GameObject muro = Instantiate(Configuracion.instancia.campo.muros[0]);
                            Vector3 posicion = casillas[posicionHoyoX, posicionHoyoZ + 2].prefab.transform.position;
                            posicion.y -= 0.1f;
                            muro.transform.position = posicion;
                            casillas[posicionHoyoX, posicionHoyoZ + 2].modificable = false;
                        }
                    }
                }
            }
        }
    }
}