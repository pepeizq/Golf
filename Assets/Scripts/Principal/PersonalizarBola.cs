using Jugador;
using Partida;
using UnityEngine;
using UnityEngine.UI;

namespace Principal
{
    public class PersonalizarBola : MonoBehaviour
    {
        public Canvas canvasPrincipal;
        public Canvas canvasPersonalizar;

        public Slider sliderRojo;
        public Slider sliderVerde;
        public Slider sliderAzul;

        public GameObject bolaVistaPrevia;
        public GameObject bolaPrincipalVistaPrevia;

        public static PersonalizarBola instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void VolverPrincipal()
        {
            canvasPersonalizar.gameObject.SetActive(false);
            canvasPrincipal.gameObject.SetActive(true);
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

            MeshRenderer renderer = bolaPrincipalVistaPrevia.gameObject.GetComponent<MeshRenderer>();
            Material material = new Material(Shader.Find("HDRP/Lit"));
            material.SetColor("_BaseColor", colorNuevo);
            renderer.material = material;

            //--------------------------------

            sliderRojo.minValue = 0f;
            sliderRojo.maxValue = 1f;

            sliderVerde.minValue = 0f;
            sliderVerde.maxValue = 1f;

            sliderAzul.minValue = 0f;
            sliderAzul.maxValue = 1f;

            sliderRojo.value = colorNuevo.r;
            sliderVerde.value = colorNuevo.g;
            sliderAzul.value = colorNuevo.b;

            if (sliderRojo.value == 0f && sliderVerde.value == 0f && sliderAzul.value == 0f)
            {
                sliderRojo.value = 1f;
                sliderVerde.value = 1f;
                sliderAzul.value = 1f;
            }
        }

        public void CambiarColorRojo()
        {
            PlayerPrefs.SetFloat("jugadorColorRojo", sliderRojo.value);
            CambiarColor();
        }

        public void CambiarColorVerde()
        {
            PlayerPrefs.SetFloat("jugadorColorVerde", sliderVerde.value);
            CambiarColor();
        }

        public void CambiarColorAzul()
        {
            PlayerPrefs.SetFloat("jugadorColorAzul", sliderAzul.value);
            CambiarColor();
        }

        private void CambiarColor()
        {
            Color colorNuevo = new Color
            {
                r = sliderRojo.value,
                g = sliderVerde.value,
                b = sliderAzul.value
            };

            Atributos.instancia.color = colorNuevo;

            MeshRenderer renderer1 = bolaVistaPrevia.gameObject.GetComponent<MeshRenderer>();
            MeshRenderer renderer2 = bolaPrincipalVistaPrevia.gameObject.GetComponent<MeshRenderer>();

            Material material = new Material(Shader.Find("HDRP/Lit"));
            material.SetColor("_BaseColor", colorNuevo);

            renderer1.material = material;
            renderer2.material = material;
        }
    }
}
