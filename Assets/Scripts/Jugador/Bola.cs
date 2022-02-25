using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Jugador
{
    //https://www.youtube.com/watch?v=1rwchBV61ys
    public class Bola : MonoBehaviour
    {
        public float cambiarAnguloVelocidad = 200f;
        public float cambiarLineaLongitud = 0.5f;
        public Slider potenciaSlider;

        private float angulo = 0;
        private float potencia = 0;
        private float potenciaTiempo = 0;

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
        }

        public void Update()
        {
            if (instancia.permitirPotencia == true)
            {
                instancia.potencia += 0.2f;
            }
            else
            {
                if (instancia.potencia != 0)
                {
                    instancia.cuerpo.AddForce(Quaternion.Euler(0, instancia.angulo, 0) * Vector3.forward * instancia.potencia, ForceMode.Impulse);
                    instancia.potencia = 0;
                }
            }

            if (instancia.permitirRotarIzquierda == true)
            {
                instancia.angulo -= Time.deltaTime * instancia.cambiarAnguloVelocidad;
            }

            if (instancia.permitirRotarDerecha == true)
            {
                instancia.angulo += Time.deltaTime * instancia.cambiarAnguloVelocidad;
            }

            ActualizarLinea();
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

        private void ActualizarLinea()
        {
            instancia.linea.SetPosition(0, instancia.transform.position);
            instancia.linea.SetPosition(1, instancia.transform.position + Quaternion.Euler(0, instancia.angulo, 0) * Vector3.forward * instancia.cambiarLineaLongitud);
        }

        private void PotenciaSlider()
        {

        }
    }
}

