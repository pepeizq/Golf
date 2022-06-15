using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Escenario
{
    public class Objetos : MonoBehaviour
    {
        public GameObject bola;
        public GameObject camara;

        [Header("Canvas")]
        public Canvas canvasPartida;
        public Canvas canvasMenu;
        public Canvas canvasCargando;
        public Canvas canvasTablaGolpes;
        public Canvas canvasNuevoNivel;
        public Canvas canvasPartidaTerminada;

        [Header("NuevoNivel")]
        public Slider sliderCargando;
        public TextMeshProUGUI textoSegundos;

        [Header("Multijugador")]
        public GameObject panelEsperandoJugadores;
        public TextMeshProUGUI textoEsperandoJugadores;

        [Header("Golpes")]
        public GameObject panelTablaCabecera;
        public GameObject panelTablaGolpes;
        public GameObject prefabTablaGolpesJugador;

        [Header("Jugador")]
        public TextMeshProUGUI textoPartida;
        public TextMeshProUGUI textoHoyo;
        public TextMeshProUGUI textoGolpes;
        public TextMeshProUGUI textoPalos;
        public Slider sliderPotencia;

        public static Objetos instancia;

        public void Awake()
        {
            instancia = this;

            instancia.sliderPotencia.gameObject.SetActive(false);
        }

        public void OcultarCanvas()
        {
            canvasPartida.gameObject.SetActive(false);
            canvasMenu.gameObject.SetActive(false);
            canvasCargando.gameObject.SetActive(false);
            canvasTablaGolpes.gameObject.SetActive(false);
            canvasNuevoNivel.gameObject.SetActive(false);
            canvasPartidaTerminada.gameObject.SetActive(false);
        }
    }
}