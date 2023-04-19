using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosPrincipal : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panelIzquierda;
        public RectTransform panelDerecha;
        public RectTransform panelVersion;

        [Header("Botones")]
        public Button botonNuevaPartida;
        public Button botonContinuarPartida;
        public Button botonCargarPartida;
        public Button botonMultijugador;
        public Button botonOpciones;
        public Button botonSalir;
        public Button botonPersonalizar;

        [Header("Textos")]
        public TMP_Text nuevaPartida;
        public TMP_Text continuarPartida;
        public TMP_Text cargarPartida;
        public TMP_Text multijugador;
        public TMP_Text opciones;
        public TMP_Text salir;
        public TMP_Text personalizar;
        public TMP_Text version;

        public static ObjetosPrincipal instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            nuevaPartida.text = Idiomas.Idiomas.instancia.CogerCadena("newGame");
            continuarPartida.text = Idiomas.Idiomas.instancia.CogerCadena("continueGame");
            cargarPartida.text = Idiomas.Idiomas.instancia.CogerCadena("loadGame");
            multijugador.text = Idiomas.Idiomas.instancia.CogerCadena("multiplayer");
            opciones.text = Idiomas.Idiomas.instancia.CogerCadena("options");
            salir.text = Idiomas.Idiomas.instancia.CogerCadena("exit");
            personalizar.text = Idiomas.Idiomas.instancia.CogerCadena("customizeBall");
        }
    }
}
