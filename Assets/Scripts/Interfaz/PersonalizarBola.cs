using Jugador;
using UnityEngine;

namespace Interfaz
{
    public class PersonalizarBola : MonoBehaviour
    {
        public static PersonalizarBola instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void VolverPrincipal()
        {
            ObjetosPersonalizarBola.instancia.canvas.gameObject.SetActive(false);
            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(true);
        }

        public void Cargar()
        {
            Color colorNuevo = new Color
            {
                r = PlayerPrefs.GetFloat("jugadorColorRojo"),
                g = PlayerPrefs.GetFloat("jugadorColorVerde"),
                b = PlayerPrefs.GetFloat("jugadorColorAzul")
            };

            Atributos.instancia.color = colorNuevo;

            MeshRenderer renderer = ObjetosPersonalizarBola.instancia.bolaPrincipalVistaPrevia.gameObject.GetComponent<MeshRenderer>();
            Material material = new Material(Shader.Find("HDRP/Lit"));
            material.SetColor("_BaseColor", colorNuevo);
            renderer.material = material;

            //--------------------------------

            ObjetosPersonalizarBola.instancia.sliderRojo.minValue = 0f;
            ObjetosPersonalizarBola.instancia.sliderRojo.maxValue = 1f;

            ObjetosPersonalizarBola.instancia.sliderVerde.minValue = 0f;
            ObjetosPersonalizarBola.instancia.sliderVerde.maxValue = 1f;

            ObjetosPersonalizarBola.instancia.sliderAzul.minValue = 0f;
            ObjetosPersonalizarBola.instancia.sliderAzul.maxValue = 1f;

            ObjetosPersonalizarBola.instancia.sliderRojo.value = colorNuevo.r;
            ObjetosPersonalizarBola.instancia.sliderVerde.value = colorNuevo.g;
            ObjetosPersonalizarBola.instancia.sliderAzul.value = colorNuevo.b;

            if (ObjetosPersonalizarBola.instancia.sliderRojo.value == 0f && ObjetosPersonalizarBola.instancia.sliderVerde.value == 0f && ObjetosPersonalizarBola.instancia.sliderAzul.value == 0f)
            {
                ObjetosPersonalizarBola.instancia.sliderRojo.value = 1f;
                ObjetosPersonalizarBola.instancia.sliderVerde.value = 1f;
                ObjetosPersonalizarBola.instancia.sliderAzul.value = 1f;
            }
        }

        public void CambiarColorRojo()
        {
            PlayerPrefs.SetFloat("jugadorColorRojo", ObjetosPersonalizarBola.instancia.sliderRojo.value);
            CambiarColor();
        }

        public void CambiarColorVerde()
        {
            PlayerPrefs.SetFloat("jugadorColorVerde", ObjetosPersonalizarBola.instancia.sliderVerde.value);
            CambiarColor();
        }

        public void CambiarColorAzul()
        {
            PlayerPrefs.SetFloat("jugadorColorAzul", ObjetosPersonalizarBola.instancia.sliderAzul.value);
            CambiarColor();
        }

        private void CambiarColor()
        {
            Color colorNuevo = new Color
            {
                r = ObjetosPersonalizarBola.instancia.sliderRojo.value,
                g = ObjetosPersonalizarBola.instancia.sliderVerde.value,
                b = ObjetosPersonalizarBola.instancia.sliderAzul.value
            };

            Atributos.instancia.color = colorNuevo;

            MeshRenderer renderer1 = ObjetosPersonalizarBola.instancia.bolaVistaPrevia.gameObject.GetComponent<MeshRenderer>();
            MeshRenderer renderer2 = ObjetosPersonalizarBola.instancia.bolaPrincipalVistaPrevia.gameObject.GetComponent<MeshRenderer>();

            Material material = new Material(Shader.Find("HDRP/Lit"));
            material.SetColor("_BaseColor", colorNuevo);

            renderer1.material = material;
            renderer2.material = material;
        }
    }
}
