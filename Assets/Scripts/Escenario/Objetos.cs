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

        [Header("Cargando")]
        public Slider sliderCargando;

        [Header("Mensaje")]
        public GameObject panelMensaje;
        public TextMeshProUGUI textoMensaje;

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
    }
}