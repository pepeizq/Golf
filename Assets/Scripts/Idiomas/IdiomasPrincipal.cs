using TMPro;
using UnityEngine;

namespace Idiomas
{
    public class IdiomasPrincipal : MonoBehaviour
    {
        public TMP_Text menuPrincipalNuevaPartida;

        public static IdiomasPrincipal instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void CargarTextos()
        {
            menuPrincipalNuevaPartida.text = Idiomas.instancia.CogerCadena("newGame");
        }
    }
}
