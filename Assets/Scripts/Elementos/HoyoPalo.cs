using System.Collections;
using UnityEngine;

namespace Elementos
{
    public class HoyoPalo : MonoBehaviour
    {
        private void OnTriggerEnter(Collider colision)
        {
            if (colision.gameObject.name.Contains("Bola"))
            {
                StartCoroutine(Terminar());
            }
        }

        IEnumerator Terminar()
        {
            yield return new WaitForSeconds(1);
            Destroy(gameObject);
        }
    }
}

