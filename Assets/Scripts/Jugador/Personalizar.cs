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
                //bola.transform.GetChild(0).gameObject.GetComponent<MeshFilter>().mesh = Datos.instancia.bolas[nuevoModelo].gameObject.GetComponent<MeshFilter>().mesh;
            }
            else
            {

                //bola.gameObject.GetComponent<MeshFilter>().mesh = Datos.instancia.bolas[nuevoModelo];

                //Mesh nuevaBola = Datos.instancia.bolas[nuevoModelo];
                //Debug.Log(Datos.instancia.bolas[nuevoModelo].triangles);
                //nuevaBola.vertices = bola.gameObject.GetComponent<MeshFilter>().mesh.vertices;
                //nuevaBola.triangles = Datos.instancia.bolas[nuevoModelo].triangles;
                //nuevaBola.normals = bola.gameObject.GetComponent<MeshFilter>().mesh.normals;
                //nuevaBola.uv = bola.gameObject.GetComponent<MeshFilter>().mesh.uv;

                //bola.gameObject.GetComponent<MeshFilter>().sharedMesh = Datos.instancia.bolas[nuevoModelo].gameObject.GetComponent<MeshFilter>().sharedMesh;
                Mesh nuevaBola = Datos.instancia.bolas[nuevoModelo].gameObject.GetComponent<MeshFilter>().sharedMesh;
                //nuevaBola.Clear();
                

                bola.gameObject.GetComponent<MeshFilter>().sharedMesh = nuevaBola;
            } 
        }
    }
}
