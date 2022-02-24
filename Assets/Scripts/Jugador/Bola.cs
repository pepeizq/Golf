using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    //https://www.youtube.com/watch?v=uVL98ZaZxY8
    public class Bola : MonoBehaviour
    {
        public float cambiarAnguloVelocidad = 40f;
        public float cambiarLineaLongitud = 0.5f;

        private float angulo = 0;
        private float potencia = 0;

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
                instancia.potencia += 1;
            }
            else
            {
                if (instancia.potencia != 0)
                {
                    instancia.GetComponent<Rigidbody>().velocity = instancia.transform.forward * instancia.potencia;
                    instancia.potencia -= 2;
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

        public void RotarInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                //rotarInput = contexto.ReadValue<Vector2>();
            }
            else if (contexto.phase == InputActionPhase.Canceled)
            {
                //rotarInput = Vector2.zero;
            }
        }

        private void ActualizarLinea()
        {
            instancia.linea.SetPosition(0, instancia.transform.position);
            instancia.linea.SetPosition(1, instancia.transform.position + Quaternion.Euler(0, instancia.angulo, 0) * Vector3.forward * cambiarLineaLongitud);
        }
    }
}

