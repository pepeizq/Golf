using Recursos;
using UnityEngine;

namespace Escenario.Colocar
{
    public class Hierba : MonoBehaviour
    {
        public static Hierba instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void PodarInicio(int x, int z, Casilla[,] casillas, CampoTipo campoTipo)
        {
            if (campoTipo == CampoTipo.Verde)
            {
                if (x > 0 && z > 0 && casillas != null)
                {
                    for (int i = x - 1; i <= x + 1; i += 1)
                    {
                        for (int j = z - 1; j <= z + 1; j += 1)
                        {
                            Podar(i, j, casillas);
                        }
                    }
                }
            }
        }

        public void PodarHoyo(int x, int z, Casilla[,] casillas, CampoTipo campoTipo)
        {
            if (campoTipo == CampoTipo.Verde)
            {
                if (x > 0 && z > 0 && casillas != null)
                {
                    for (int i = x - 2; i <= x + 2; i += 1)
                    {
                        for (int j = z - 2; j <= z + 2; j += 1)
                        {
                            Podar(i, j, casillas);
                        }
                    }
                }
            }
        }

        private void Podar(int x, int z, Casilla[,] casillas)
        {
            if (casillas[x, z].prefab != null)
            {
                if (casillas[x, z].prefab.transform.childCount > 1)
                {
                    GameObject hierbaBaja = casillas[x, z].prefab.transform.GetChild(1).gameObject;

                    if (hierbaBaja.name == "Hierba Baja" && hierbaBaja.activeSelf == false)
                    {
                        hierbaBaja.SetActive(true);

                        GameObject hierbaAlta = casillas[x, z].prefab.transform.GetChild(0).gameObject;

                        if (hierbaAlta.name == "Hierba Alta")
                        {
                            hierbaAlta.SetActive(false);
                        }
                    }
                }
            }
        }
    }
}
