using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosMultiLobby : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;
        public RectTransform panelSalas;

        [Header("Botones")]
        public Button botonVolver;
        public Button botonCrearSala;

        [Header("Textos")]
        public TMP_Text volver;
        public TMP_Text crearSala;

        [Header("Inputs")]
        public TMP_InputField textoJugador;
        public TMP_InputField textoSala;

        [Header("Prefabs")]
        public GameObject prefabBotonSala;

        public static ObjetosMultiLobby instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            volver.text = Idiomas.Idiomas.instancia.CogerCadena("back");
            crearSala.text = Idiomas.Idiomas.instancia.CogerCadena("createRoom");
        }
    }
}