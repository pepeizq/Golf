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

        public void CargarAtributos()
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

            Atributos.instancia.modelo = PlayerPrefs.GetInt("jugadorBola");
            bolaPrincipalVistaPrevia.gameObject.GetComponent<MeshFilter>().mesh = Datos.instancia.bolas[PlayerPrefs.GetInt("jugadorBola")];
        }

        public void Iniciar()
        {
            sliderRojo.minValue = 0f;
            sliderRojo.maxValue = 1f;
            
            sliderVerde.minValue = 0f;
            sliderVerde.maxValue = 1f;
            
            sliderAzul.minValue = 0f;
            sliderAzul.maxValue = 1f;

            sliderRojo.value = PlayerPrefs.GetFloat("jugadorColorRojo");
            sliderVerde.value = PlayerPrefs.GetFloat("jugadorColorVerde");
            sliderAzul.value = PlayerPrefs.GetFloat("jugadorColorAzul");

            if (sliderRojo.value == 0f && sliderVerde.value == 0f && sliderAzul.value == 0f)
            {
                sliderRojo.value = 1f;
                sliderVerde.value = 1f;
                sliderAzul.value = 1f;
            }

            bolaVistaPrevia.gameObject.GetComponent<MeshFilter>().mesh = Datos.instancia.bolas[PlayerPrefs.GetInt("jugadorBola")];
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
            UnityEngine.Color colorNuevo = new UnityEngine.Color
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

        public void CambiarModelo(bool sumar)
        {
            int posicion = PlayerPrefs.GetInt("jugadorBola");

            if (sumar == true)
            {
                posicion += 1;

                if (posicion >= Datos.instancia.bolas.Count)
                {
                    posicion = 0;
                }
            }
            else
            {
                posicion -= 1;

                if (posicion < 0)
                {
                    posicion = Datos.instancia.bolas.Count - 1;
                }
            }

            Atributos.instancia.modelo = posicion;
            PlayerPrefs.SetInt("jugadorBola", posicion);

            bolaPrincipalVistaPrevia.gameObject.GetComponent<MeshFilter>().mesh = Datos.instancia.bolas[PlayerPrefs.GetInt("jugadorBola")];
            bolaVistaPrevia.gameObject.GetComponent<MeshFilter>().mesh = Datos.instancia.bolas[PlayerPrefs.GetInt("jugadorBola")];
        }
    }
}
