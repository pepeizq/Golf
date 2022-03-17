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
            instancia.animacion = true;
        }

        public void Update()
        {
            if (instancia.animacion == true)
            {
                Vector3 posicionBola = Jugador.Bola.instancia.ultimaPosicion;
                Vector3 posicionHoyo = Configuracion.instancia.posicionHoyo;
                GameObject camara = Jugador.Bola.instancia.transform.GetChild(0).gameObject;

                instancia.pasos += Time.deltaTime * 5;
             
                Vector3 posicionNueva = Vector3.MoveTowards(posicionHoyo, posicionBola, instancia.pasos);
                posicionNueva.x -= Configuracion.instancia.rotacionCamaraX;
                posicionNueva.y = Configuracion.instancia.rotacionCamaraY;
                posicionNueva.z -= Configuracion.instancia.rotacionCamaraZ;
                camara.transform.position = posicionNueva;

                if (Vector3.Distance(posicionHoyo, posicionBola) <= instancia.pasos)
                {             
                    Configuracion.instancia.poderMover = true;
                    instancia.animacion = false;                  
                }
            }           
        }
    }
}