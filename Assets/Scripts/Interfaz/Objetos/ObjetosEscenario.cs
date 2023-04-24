using TMPro;
using UnityEngine;

namespace Interfaz
{
    public class ObjetosEscenario : MonoBehaviour
    {
        [Header("Textos")]
        public TMP_Text volverPartida;

        public static ObjetosEscenario instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            volverPartida.text = Idiomas.Idiomas.instancia.CogerCadena("backGame");
        }
    }
}
