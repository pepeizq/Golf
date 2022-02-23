using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    public class Movimiento : MonoBehaviour
    {
        public GameObject bola;
        public Camera camara;

        public float zoomCerca = 0.5f;
        public float zoomLejos = 25f;

        public int velocidad = 20;

        private bool arrastrando;

        private Vector2 movimientoInput;
        private float zoomInput;

        public static Movimiento instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Start()
        {

        }

        public void MovimientoInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                movimientoInput = contexto.ReadValue<Vector2>();
            }
            else if (contexto.phase == InputActionPhase.Canceled)
            {
                movimientoInput = Vector2.zero;
            }
        }

        public void ZoomInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed)
            {
                zoomInput = contexto.ReadValue<float>();
            }
        }

        public void FixedUpdate()
        {
            Movimiento2();
            ZoomArrastre();
        }

        private void Movimiento2()
        {
            if (movimientoInput.x > 0 && movimientoInput.y == 0)
            {
                camara.transform.Translate(new Vector3(velocidad * Time.deltaTime * 10, 0, 0));
            }
            else if (movimientoInput.x < 0 && movimientoInput.y == 0)
            {
                camara.transform.Translate(new Vector3(-velocidad * Time.deltaTime * 10, 0, 0));
            }
            else if (movimientoInput.x == 0 && movimientoInput.y > 0)
            {
                camara.transform.Translate(new Vector3(0, velocidad * Time.deltaTime * 10, 0));
            }
            else if (movimientoInput.x == 0 && movimientoInput.y < 0)
            {
                camara.transform.Translate(new Vector3(0, -velocidad * Time.deltaTime * 10, 0));
            }

            if (arrastrando == false)
            {
                camara.transform.position = new Vector3(camara.transform.position.x, 60, camara.transform.position.z);
            }
        }

        private void ZoomArrastre()
        {
            if (zoomInput > 0)
            {
                zoomInput = 0.1f;
            }
            else if (zoomInput < 0)
            {
                zoomInput = -0.1f;
            }
            else
            {
                zoomInput = 0;
            }

            camara.orthographicSize = Mathf.Clamp(camara.orthographicSize -= zoomInput *
                (10f * camara.orthographicSize * .1f), zoomCerca, zoomLejos);
        }
    }
}