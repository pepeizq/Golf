using UnityEngine;

namespace Escenario.Colocar
{
    public class AnimacionHoyoBola : MonoBehaviour
    {
        private float pasos = 0f;
        private bool animacion = false;

        public static AnimacionHoyoBola instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Generar()
        {
            Configuracion.instancia.poderMover = false;
            animacion = true;
        }

        public void Update()
        {
            if (instancia.animacion == true)
            {
                Vector3 posicionBola = Jugador.Bola.instancia.ultimaPosicion;
                Vector3 posicionHoyo = Configuracion.instancia.posicionHoyo;
                GameObject camara = Jugador.Bola.instancia.transform.GetChild(0).gameObject;

                pasos += Time.deltaTime * 5;

                Vector3 posicionNueva = Vector3.MoveTowards(posicionHoyo, posicionBola, pasos);
                posicionNueva.x -= Configuracion.instancia.rotacionCamaraX;
                posicionNueva.y = Configuracion.instancia.rotacionCamaraY;
                posicionNueva.z -= Configuracion.instancia.rotacionCamaraZ;
                camara.transform.position = posicionNueva;

                if (Vector3.Distance(posicionHoyo, posicionBola) <= pasos)
                {
                    Configuracion.instancia.poderMover = true;
                    animacion = false;
                }
            }           
        }
    }
}