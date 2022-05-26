using TMPro;
using UnityEngine;

namespace Idiomas
{
    public class IdiomasPrincipal : MonoBehaviour
    {
        [Header("Principal")]
        public TMP_Text nuevaPartida;
        public TMP_Text continuarPartida;
        public TMP_Text cargarPartida;
        public TMP_Text multijugador;
        public TMP_Text opciones;
        public TMP_Text personalizar;
        public TMP_Text salir;

        [Header("Cargando")]
        public TMP_Text cargando;

        [Header("Nueva Partida")]
        public TMP_Text volverNuevaPartida;

        [Header("Cargar Partida")]
        public TMP_Text volverCargarPartida;

        [Header("Lobby")]
        public TMP_Text volverLobby;
        public TMP_Text crearSala;

        [Header("Sala")]
        public TMP_Text dejarSala;
        public TMP_Text empezarPartida;

        [Header("Personalizar")]
        public TMP_Text volverPersonalizar;

        [Header("Opciones")]
        public TMP_Text volverOpciones;

        public static IdiomasPrincipal instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            nuevaPartida.text = Idiomas.instancia.CogerCadena("newGame");
            continuarPartida.text = Idiomas.instancia.CogerCadena("continueGame");
            cargarPartida.text = Idiomas.instancia.CogerCadena("loadGame");
            multijugador.text = Idiomas.instancia.CogerCadena("multiplayer");
            opciones.text = Idiomas.instancia.CogerCadena("options");
            personalizar.text = Idiomas.instancia.CogerCadena("customizeBall");
            salir.text = Idiomas.instancia.CogerCadena("exit");

            cargando.text = Idiomas.instancia.CogerCadena("loading");

            volverNuevaPartida.text = Idiomas.instancia.CogerCadena("back");

            volverCargarPartida.text = Idiomas.instancia.CogerCadena("back");

            volverLobby.text = Idiomas.instancia.CogerCadena("back");
            crearSala.text = Idiomas.instancia.CogerCadena("createRoom");

            dejarSala.text = Idiomas.instancia.CogerCadena("leaveRoom");
            empezarPartida.text = Idiomas.instancia.CogerCadena("startGame");

            volverPersonalizar.text = Idiomas.instancia.CogerCadena("back");

            volverOpciones.text = Idiomas.instancia.CogerCadena("back");
        }
    }
}
