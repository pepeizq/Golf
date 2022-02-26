using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    //https://www.youtube.com/watch?v=DZEiMFBndco
    public class Bola : MonoBehaviour
    {
        public float potenciaMaxima = 10f;
        public float cambiarAnguloVelocidad = 200f;
        public float cambiarLineaLongitud = 2f;

        private float angulo = 0;
        private float potencia = 0;
        private bool potenciaDecrecer = false;
        private int golpes = 0;

        private bool permitirPotencia;
        private bool permitirRotarIzquierda;
        private bool permitirRotarDerecha;

        private LineRenderer linea;
        private Rigidbody cuerpo;

        public static Bola instancia;

        public void Awake()
        {
            instancia = this;

            instancia.cuerpo = GetComponent<Rigidbody>();
            instancia.cuerpo.maxAngularVelocity = 1000;
            instancia.linea = GetComponent<LineRenderer>();

            Canvas.Partida.instancia.sliderPotencia.maxValue = instancia.potenciaMaxima;
        }

        public void Update()
        {
            if (instancia.permitirPotencia == true)
            {
                if (instancia.potenciaDecrecer == false)
                {
                    if (instancia.potencia <= instancia.potenciaMaxima)
                    {
                        instancia.potencia += 0.1f;
                    }
                    else
                    {
                        instancia.potencia = instancia.potenciaMaxima;
                        instancia.potenciaDecrecer = true;
                    }
                }
                else if (instancia.potenciaDecrecer == true)
                {
                    if (instancia.potencia >= 0)
                    {
                        instancia.potencia -= 0.1f;
                    }
                    else
                    {
                        instancia.potencia = 0;
                        instancia.potenciaDecrecer = false;
                    }
                }
            }
            else
            {
                if (instancia.potencia != 0)
                {
                    instancia.cuerpo.AddForce(Quaternion.Euler(0, instancia.angulo, 0) * Vector3.forward * instancia.potencia, ForceMode.Impulse);
                    instancia.potencia = 0;

                    instancia.golpes += 1;
                    Canvas.Partida.instancia.textoGolpes.text = instancia.golpes.ToString();
                }
            }

            Canvas.Partida.instancia.sliderPotencia.value = instancia.potencia;

            if (instancia.potencia == 0)
            {
                Canvas.Partida.instancia.sliderPotencia.gameObject.SetActive(false);
            }
            else
            {
                Canvas.Partida.instancia.sliderPotencia.gameObject.SetActive(true);
            }

            //--------------------------------------------------------

            if (instancia.permitirRotarIzquierda == true)
            {
                instancia.angulo -= Time.deltaTime * instancia.cambiarAnguloVelocidad;
            }

            if (instancia.permitirRotarDerecha == true)
            {
                instancia.angulo += Time.deltaTime * instancia.cambiarAnguloVelocidad;
            }

            //--------------------------------------------------------

            instancia.linea.SetPosition(0, instancia.transform.position);
            instancia.linea.SetPosition(1, instancia.transform.position + Quaternion.Euler(0, instancia.angulo, 0) * Vector3.forward * instancia.cambiarLineaLongitud);
        }

        public void PotenciaInput(InputAction.CallbackContext contexto)
        {          
            if (contexto.phase == InputActionPhase.Performed)
            {
                instancia.permitirPotencia = true;
            }
            else if (contexto.phase == InputActionPhase.Canceled)
            {
                instancia.permitirPotencia = false;
            }
        }

        public void RotarIzquierdaInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                instancia.permitirRotarIzquierda = true;    
            }
            else if (contexto.phase == InputActionPhase.Canceled)
            {
                instancia.permitirRotarIzquierda = false;
            }
        }

        public void RotarDerechaInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                instancia.permitirRotarDerecha = true;
            }
            else if (contexto.phase == InputActionPhase.Canceled)
            {
                instancia.permitirRotarDerecha = false;
            }
        }
    }
}

