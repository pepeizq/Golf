using TMPro;
using UnityEngine;

namespace Interfaz
{
    public class ObjetosPrincipal : MonoBehaviour
    {
        [Header("Textos")]
        public TMP_Text nuevaPartida;
        public TMP_Text continuarPartida;
        public TMP_Text cargarPartida;
        public TMP_Text multijugador;
        public TMP_Text opciones;
        public TMP_Text personalizar;
        public TMP_Text salir;

        public static ObjetosPrincipal instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {

        }
    }
}
