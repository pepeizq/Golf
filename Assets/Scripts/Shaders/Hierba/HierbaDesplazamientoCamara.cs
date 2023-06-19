using UnityEngine;

public class HierbaDesplazamientoCamara : MonoBehaviour
{  
    void Update()
    {
        Camera camara = this.gameObject.GetComponent<Camera>();

        Vector3 posicion = this.transform.position;

        if (camara != null)
        {
            posicion.x -= camara.orthographicSize;
            posicion.z -= camara.orthographicSize;

            Shader.SetGlobalVector("_DisplacementLocation", posicion);
            Shader.SetGlobalFloat("_DisplacementSize", camara.orthographicSize * 2f);
        }
    }
}
