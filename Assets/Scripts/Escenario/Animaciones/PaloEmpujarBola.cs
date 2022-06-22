using Jugador;
using UnityEngine;

namespace Escenario.Animaciones
{
    public class PaloEmpujarBola : MonoBehaviour
    {
        private bool paloInstanciado = false;

        private GameObject paloGenerado;
        private GameObject bola;

        private float potencia;
        private float potenciaMaxima;
        private bool potenciaCambio;

        public static PaloEmpujarBola instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Generar(GameObject bolaOrigen, GameObject paloGenerar)
        {
            if (paloGenerado == null && paloInstanciado == false)
            {
                Configuracion.instancia.poderMover = false;

                paloGenerado = Instantiate(paloGenerar);
                paloInstanciado = true;

                bolaOrigen.transform.eulerAngles = new Vector3(0, bolaOrigen.transform.eulerAngles.y, 0);

                paloGenerado.transform.position = bolaOrigen.transform.position;
                paloGenerado.transform.SetParent(bolaOrigen.transform);

                paloGenerado.transform.localScale = new Vector3(50, 50, 50);

                float rotacion = bolaOrigen.gameObject.GetComponent<Bola>().rotacion;
                paloGenerado.transform.RotateAround(bolaOrigen.transform.position, Vector3.up, rotacion);

                bola = bolaOrigen;

                potencia = 0;
                potenciaMaxima = bola.gameObject.GetComponent<Bola>().potencia;
                potenciaCambio = false;
            }
        }

        public void Destruir()
        {
            if (paloGenerado != null)
            {
                Destroy(paloGenerado);
                paloInstanciado = false;
            }
        }

        public void Update()
        {
            if (paloGenerado != null && paloInstanciado == true)
            {
                if (potenciaCambio == false)
                {
                    potencia += 0.1f;
                }
                else
                {
                    potencia -= 0.3f;
                }

                if (potencia >= potenciaMaxima)
                {
                    potenciaCambio = true;
                }

                if (Configuracion.instancia.paloUsado == Configuracion.Palos.Madera)
                {
                    Vector3 nuevaPosicion = new Vector3(0, 0, 0);
                    nuevaPosicion.x = nuevaPosicion.x - 1f - potencia;
                    nuevaPosicion.y = nuevaPosicion.y + potencia;
                    paloGenerado.transform.localPosition = nuevaPosicion;

                    float rotacion = 2f;

                    if (rotacion > 90f)
                    {
                        rotacion = 90f;
                    }

                    if (potenciaCambio == true)
                    {
                        rotacion = -6f;
                    }

                    paloGenerado.transform.Rotate(rotacion, 0f, 0f, Space.Self);

                }
                else if (Configuracion.instancia.paloUsado == Configuracion.Palos.Hierro)
                {
                    Vector3 nuevaPosicion = new Vector3(0, 0, 0);
                    nuevaPosicion.x = nuevaPosicion.x - 1f - (potencia / 2);
                    paloGenerado.transform.localPosition = nuevaPosicion;
                }

                if (Vector3.Distance(paloGenerado.transform.position, bola.transform.position) <= 0.25f && potenciaCambio == true)
                {
                    Bola.instancia.EmpujarBola();
                    Destruir();
                    Configuracion.instancia.poderMover = true;
                }

            }
        }
    }
}
