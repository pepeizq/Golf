using TMPro;
using UnityEngine;

namespace Interfaz.Idiomas
{
    public class IdiomasPrincipal : MonoBehaviour
    {



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



            

            //---------------------------------------------------------------------





            volverPersonalizar.text = Idiomas.instancia.CogerCadena("back");

            volverOpciones.text = Idiomas.instancia.CogerCadena("back");
        }
    }
}
