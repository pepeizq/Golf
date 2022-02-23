using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    public class Bola : MonoBehaviour
    {
        private Vector2 rotarInput;
        private float yAng = 0;

        private float potencia = 0;
        private bool permitirPotencia;

        public static Bola instancia;

        public void Awake()
        {
            instancia = this;
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
                    instancia.potencia -= 1;
                }
            }
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
                rotarInput = contexto.ReadValue<Vector2>();
            }
            else if (contexto.phase == InputActionPhase.Canceled)
            {
                rotarInput = Vector2.zero;
            }
        }

        private void OnMouseDown()
        {

        }
    }
}

