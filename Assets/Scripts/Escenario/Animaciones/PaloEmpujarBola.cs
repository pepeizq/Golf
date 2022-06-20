using Jugador;
using UnityEngine;

namespace Escenario.Animaciones
{
    public class PaloEmpujarBola : MonoBehaviour
    {
        private GameObject paloGenerado;
        private GameObject bola;

        public static PaloEmpujarBola instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Generar(GameObject bolaOrigen, GameObject paloGenerar)
        {
            if (paloGenerado == null)
            {
                paloGenerado = Instantiate(paloGenerar);

                bolaOrigen.transform.eulerAngles = new Vector3(0, bolaOrigen.transform.eulerAngles.y, 0);

                paloGenerado.transform.position = bolaOrigen.transform.position;
                paloGenerado.transform.SetParent(bolaOrigen.transform);
                paloGenerado.transform.localScale = new Vector3(50, 50, 50);

                float rotacion = bolaOrigen.gameObject.GetComponent<Bola>().rotacion;
                paloGenerado.transform.RotateAround(bolaOrigen.transform.position, Vector3.up, rotacion);

                bola = bolaOrigen;
            }

        }

        public void Destruir()
        {
            if (paloGenerado != null)
            {
                Destroy(paloGenerado);
            }
        }

        public void Update()
        {
            if (paloGenerado != null)
            {
                if (Configuracion.instancia.paloUsado == Configuracion.Palos.Madera)
                {

                }
                else if (Configuracion.instancia.paloUsado == Configuracion.Palos.Hierro)
                {

                }


                Vector3 nuevaPosicion = new Vector3(0, 0, 0);
                nuevaPosicion.x = nuevaPosicion.x - 0.5f - (bola.gameObject.GetComponent<Bola>().potencia / 2);
                paloGenerado.transform.localPosition = nuevaPosicion;



            }
        }
    }
}
