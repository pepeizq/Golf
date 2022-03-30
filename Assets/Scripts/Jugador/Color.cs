using UnityEngine;

namespace Jugador
{
    public static class Color 
    {
        public static void Cambiar(GameObject bola, LineRenderer linea, UnityEngine.Color color)
        {
            Renderer renderer = bola.gameObject.GetComponent<Renderer>();
            renderer.material.shader = Shader.Find("HDRP/Lit");
            renderer.material.SetColor("_BaseColor", color);

            linea.material = new Material(Shader.Find("Sprites/Default"));
            Gradient gradiente = new Gradient();
            gradiente.SetKeys(
                new GradientColorKey[] { new GradientColorKey(color, 0.0f), new GradientColorKey(color, 1.0f) },
                new GradientAlphaKey[] { new GradientAlphaKey(0.5f, 0.0f), new GradientAlphaKey(0.5f, 1.0f) }
            );
            linea.colorGradient = gradiente;
        }
    }
}
