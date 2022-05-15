using UnityEngine;

namespace Elementos
{
    public class HoyoPalo : MonoBehaviour
    {
        private bool animacionArriba = false;
        private bool animacionAbajo = false;
        private bool topeArriba = false;
        private bool topeAbajo = true;

        private Vector3 posicionPalo;
        private Vector3 posicionPaloElevada;

        private float alturaMaxima = 2f;
        private float pasos = 0f;
        private float velocidadPasos = 2f;

        private GameObject bola;

        private void OnTriggerEnter(Collider colision)
        {
            if (colision.gameObject.name.Contains("Bola"))
            {
                bola = colision.gameObject;

                if (topeArriba == false && topeAbajo == true)
                {
                    pasos = 0f;
                    animacionArriba = true;
                }             
            }
        }

        public void Start()
        {
            posicionPalo = gameObject.transform.position;

            posicionPaloElevada = posicionPalo;
            posicionPaloElevada.y = posicionPaloElevada.y + alturaMaxima;
        }

        public void Update()
        {
            if (animacionArriba == true)
            {
                pasos += Time.deltaTime * velocidadPasos;

                Vector3 posicionNueva = Vector3.MoveTowards(posicionPalo, posicionPaloElevada, pasos);
                gameObject.transform.position = posicionNueva;

                if (Vector3.Distance(posicionPalo, posicionPaloElevada) <= pasos)
                {
                    animacionArriba = false;
                }
            }

            if (bola != null)
            {
                if (animacionArriba == false)
                {
                    if (Vector3.Distance(gameObject.transform.position, bola.transform.position) > 5f)
                    {
                        pasos = 0f;
                        animacionAbajo = true;
                    }
                }
            }

            if (animacionAbajo == true)
            { 
                pasos += Time.deltaTime * velocidadPasos;
              
                Vector3 posicionNueva = Vector3.MoveTowards(gameObject.transform.position, posicionPalo, pasos);
                gameObject.transform.position = posicionNueva;

                if (Vector3.Distance(gameObject.transform.position, posicionPalo) <= pasos)
                {
                    animacionAbajo = false;
                }
            }
        }
    }
}

