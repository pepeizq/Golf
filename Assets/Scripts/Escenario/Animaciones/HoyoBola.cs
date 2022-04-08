using Jugador;
using UnityEngine;

namespace Escenario.Animaciones
{
    public class HoyoBola : MonoBehaviour
    {
        private float pasos = 0f;
        private bool animacion = false;

        public static HoyoBola instancia;

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
            if (animacion == true)
            {
                Vector3 posicionBola = Bola.instancia.ultimaPosicion;
                Vector3 posicionHoyo = Configuracion.instancia.posicionHoyo;

                if (Multijugador.instancia.Conectado() == true)
                {
                    posicionHoyo.x = Configuracion.instancia.multiPosicionXHoyo;
                    posicionHoyo.z = Configuracion.instancia.multiPosicionZHoyo;
                }

                GameObject camara = Objetos.instancia.camara.gameObject;

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