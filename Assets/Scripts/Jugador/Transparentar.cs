using Escenario.Generacion;
using System.Collections.Generic;
using UnityEngine;

namespace Jugador
{
    public static class Transparentar 
    {
        public enum CasillasMaterial { Transparente, Opaco }

        public static void Casillas(Vector3 posicionBola, CasillasMaterial materialElegido)
        {
            if (Configuracion.instancia.transparencias == true && posicionBola != null)
            {
                int posicionBolaX = Mathf.RoundToInt(posicionBola.x);
                int posicionBolaZ = Mathf.RoundToInt(posicionBola.z);

                List<Vector2> posiciones = new List<Vector2>
                {
                    new Vector2(posicionBolaX, posicionBolaZ),
                    new Vector2(posicionBolaX - 1, posicionBolaZ),
                    new Vector2(posicionBolaX - 1, posicionBolaZ - 1),
                    new Vector2(posicionBolaX, posicionBolaZ - 1),
                    new Vector2(posicionBolaX + 1, posicionBolaZ - 1),
                    new Vector2(posicionBolaX + 1, posicionBolaZ),
                    new Vector2(posicionBolaX + 1, posicionBolaZ + 1),
                    new Vector2(posicionBolaX, posicionBolaZ + 1),
                    new Vector2(posicionBolaX - 1, posicionBolaZ + 1),
                    new Vector2(posicionBolaX, posicionBolaZ + 2),
                    new Vector2(posicionBolaX + 1, posicionBolaZ + 2),
                    new Vector2(posicionBolaX + 2, posicionBolaZ + 2),
                    new Vector2(posicionBolaX + 2, posicionBolaZ + 1),
                    new Vector2(posicionBolaX + 2, posicionBolaZ),
                    new Vector2(posicionBolaX + 2, posicionBolaZ - 1),
                    new Vector2(posicionBolaX + 2, posicionBolaZ - 2),
                    new Vector2(posicionBolaX + 1, posicionBolaZ - 2),
                    new Vector2(posicionBolaX, posicionBolaZ - 2),
                    new Vector2(posicionBolaX - 1, posicionBolaZ - 2),
                    new Vector2(posicionBolaX - 2, posicionBolaZ - 2),
                    new Vector2(posicionBolaX - 2, posicionBolaZ - 1),
                    new Vector2(posicionBolaX - 2, posicionBolaZ),
                    new Vector2(posicionBolaX - 2, posicionBolaZ + 1),
                    new Vector2(posicionBolaX - 2, posicionBolaZ + 2),
                    new Vector2(posicionBolaX - 1, posicionBolaZ + 2)
                };

                float posicionY = 1;

                if (Escenario.Escenario.instancia.casillasMapa[(int)posiciones[0].x, (int)posiciones[0].y] != null)
                {
                    posicionY = Escenario.Escenario.instancia.casillasMapa[(int)posiciones[0].x, (int)posiciones[0].y].prefab.gameObject.transform.localPosition.y;
                }

                foreach (Vector2 posicion in posiciones)
                {
                    if (Limites.Comprobar((int)posicion.x, 2, Configuracion.instancia.tamañoX) == true && Limites.Comprobar((int)posicion.y, 2, Configuracion.instancia.tamañoZ) == true)
                    {
                        if (Escenario.Escenario.instancia.casillasMapa[(int)posicion.x, (int)posicion.y] != null)
                        {
                            bool cambiar = true;

                            if (Escenario.Escenario.instancia.casillasMapa[(int)posicion.x, (int)posicion.y].prefab.gameObject.transform.localPosition.y == posicionY)
                            {
                                if (Escenario.Escenario.instancia.casillasMapa[(int)posicion.x, (int)posicion.y].id == 0)
                                {
                                    cambiar = false;
                                }
                            }
                            else if (Escenario.Escenario.instancia.casillasMapa[(int)posicion.x, (int)posicion.y].prefab.gameObject.transform.localPosition.y < posicionY)
                            {
                                cambiar = false;
                            }

                            if (cambiar == true)
                            {
                                Renderer renderer = Escenario.Escenario.instancia.casillasMapa[(int)posicion.x, (int)posicion.y].prefab.gameObject.GetComponent<Renderer>();

                                if (materialElegido == CasillasMaterial.Transparente)
                                {
                                    renderer.materials[0].CopyPropertiesFromMaterial(Configuracion.instancia.campo.casillaOscuroTransparente);
                                    renderer.materials[1].CopyPropertiesFromMaterial(Configuracion.instancia.campo.casillaClaroTransparente);
                                }
                                else if (materialElegido == CasillasMaterial.Opaco)
                                {
                                    renderer.materials[0].CopyPropertiesFromMaterial(Configuracion.instancia.campo.casillaOscuroOpaco);
                                    renderer.materials[1].CopyPropertiesFromMaterial(Configuracion.instancia.campo.casillaClaroOpaco);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

