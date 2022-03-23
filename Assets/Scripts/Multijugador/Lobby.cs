using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

namespace Multijugador
{
    public class Lobby : MonoBehaviourPunCallbacks
    {
        public Button botonMultijugador;
        public Button botonCrearSala;
        public Button botonUnirseSala;
        public TextMeshProUGUI textoJugadores;
        public Button botonEmpezarPartida;

        public void Start()
        {
            botonMultijugador.interactable = false;
        }

        public override void OnConnectedToMaster()
        {
            botonMultijugador.interactable = true;
        }

        public void CrearSala(TMP_InputField nombre)
        {

        }
    }
}

