using Jugador;
using UnityEngine;

namespace Escenario.Animaciones
{
    //https://forum.unity.com/threads/moving-an-object-in-circular-orbit.925796/

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
                paloGenerado.transform.position = bolaOrigen.transform.position;
                paloGenerado.transform.SetParent(bolaOrigen.transform);
                paloGenerado.transform.localScale = new Vector3(50, 50, 50);

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
                Debug.Log(paloGenerado.transform.InverseTransformPoint(bola.transform.position));

                float rotacion = bola.gameObject.GetComponent<Bola>().rotacion;

                Vector3 nuevaPosicion = bola.transform.position;


                nuevaPosicion.x = nuevaPosicion.x - rotacion / 100 - (bola.gameObject.GetComponent<Bola>().potencia / 5);
                nuevaPosicion.z = nuevaPosicion.z - rotacion / 100 - (bola.gameObject.GetComponent<Bola>().potencia / 5);

                //if (rotacion == 0)
                //{
                //    nuevaPosicion.x = nuevaPosicion.x - rotacion / 100 - (bola.gameObject.GetComponent<Bola>().potencia / 5);
                //    nuevaPosicion.z = nuevaPosicion.z - rotacion / 100 - (bola.gameObject.GetComponent<Bola>().potencia / 5);
                //}

                //if (rotacion == 45)
                //{
                //    nuevaPosicion.x = nuevaPosicion.x - 0.25f - (bola.gameObject.GetComponent<Bola>().potencia / 5);
                //    nuevaPosicion.z = nuevaPosicion.z - 0.25f - (bola.gameObject.GetComponent<Bola>().potencia / 5);
                //}

                //if (rotacion == 90)
                //{
                //    nuevaPosicion.x = nuevaPosicion.x - 0.25f - (bola.gameObject.GetComponent<Bola>().potencia / 5);
                //    nuevaPosicion.z = nuevaPosicion.z;
                //}

                //if (rotacion >= 0f && rotacion <= 90f)
                //{
                //    nuevaPosicion.x = nuevaPosicion.x - 0.25f - rotacion / 10;
                //    nuevaPosicion.z = nuevaPosicion.z - 0.25f - (bola.gameObject.GetComponent<Bola>().potencia / 5);
                //}
    
                //paloGenerado.transform.position = nuevaPosicion;

                paloGenerado.transform.RotateAround(bola.transform.position, bola.transform.up, 20 * Time.deltaTime);
            }
        }
    }
}
