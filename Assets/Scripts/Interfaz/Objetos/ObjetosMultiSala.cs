using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosMultiSala : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panelJugadores;

        [Header("Botones")]
        public Button botonEmpezarPartida;

        [Header("Textos")]
        public TMP_Text dejarSala;
        public TMP_Text empezarPartida;

        [Header("Prefabs")]
        public GameObject prefabJugador;

        public static ObjetosMultiSala instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            dejarSala.text = Idiomas.Idiomas.instancia.CogerCadena("leaveRoom");
            empezarPartida.text = Idiomas.Idiomas.instancia.CogerCadena("startGame");
        }
    }
}