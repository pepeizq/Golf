using TMPro;
using UnityEngine;

namespace Idiomas
{
    public class IdiomasEscenario : MonoBehaviour
    {
        [Header("Menu")]
        public TMP_Text volverPartida;

        public static IdiomasEscenario instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            volverPartida.text = Idiomas.instancia.CogerCadena("backGame");
        }
    }
}
