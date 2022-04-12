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

        [Header("Mensaje")]
        public GameObject panelMensaje;
        public TextMeshProUGUI textoMensaje;

        [Header("Multijugador")]
        public GameObject panelTabla;
        public GameObject prefabTablaJugador;

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