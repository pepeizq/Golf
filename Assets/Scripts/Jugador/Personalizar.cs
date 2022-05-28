using Partida;
using UnityEngine;

namespace Jugador
{
    public static class Personalizar 
    {
        public static void Color(GameObject bola, Color color)
        {
            MeshRenderer renderer = new MeshRenderer();

            if (MultiPhoton.instancia.Conectado() == true)
            {
                renderer = bola.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>();
            }
            else
            {
                renderer = bola.gameObject.GetComponent<MeshRenderer>();
            }

            Material material = new Material(Shader.Find("HDRP/Lit"));
            material.SetColor("_BaseColor", color);
            renderer.material = material;

            LineRenderer linea = new LineRenderer();

            if (MultiPhoton.instancia.Conectado() == true)
            {
                linea = bola.transform.GetChild(0).gameObject.GetComponent<LineRenderer>();
            }
            else
            {
                linea = bola.gameObject.GetComponent<LineRenderer>();
            }

            linea.material = new Material(Shader.Find("Sprites/Default"));
            Gradient gradiente = new Gradient();
            gradiente.SetKeys(
                new GradientColorKey[] { new GradientColorKey(color, 0.0f), new GradientColorKey(color, 1.0f) },
                new GradientAlphaKey[] { new GradientAlphaKey(0.5f, 0.0f), new GradientAlphaKey(0.5f, 1.0f) }
            );
            linea.colorGradient = gradiente;
        }

        public static void Modelo(GameObject bola, int nuevoModelo)
        {
            if (MultiPhoton.instancia.Conectado() == true)
            {
                bola.transform.GetChild(0).gameObject.GetComponent<MeshFilter>().mesh = Datos.instancia.bolas[nuevoModelo];
            }
            else
            {
                bola.gameObject.GetComponent<MeshFilter>().mesh = Datos.instancia.bolas[nuevoModelo];
            } 
        }
    }
}
