using System;
using UnityEngine;

//[ExecuteInEditMode]
public class HierbaDesplazamientoCamara : MonoBehaviour
{  
    [SerializeField]
    private Camera camara;

    void Update()
    {
        Vector3 posicion = transform.position;

        if (camara != null)
        {
            posicion.x -= camara.orthographicSize;
            posicion.z -= camara.orthographicSize;

            Shader.SetGlobalVector("_DisplacementLocation", posicion);
            Shader.SetGlobalFloat("_DisplacementSize", camara.orthographicSize * 2f);
        }
    }
}
