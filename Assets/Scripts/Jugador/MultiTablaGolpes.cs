using UnityEngine;

namespace Jugador
{
    public class MultiTablaGolpes : MonoBehaviour
    {
        public static MultiTablaGolpes instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Enseñar()
        {
            if (Escenario.Objetos.instancia.panelTabla.activeSelf == true)
            {

            }
        }
    }
}
