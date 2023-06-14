using UnityEngine;

//[ExecuteInEditMode]
public class HierbaDesplazamientoBola : MonoBehaviour
{
    [SerializeField]
    private GameObject objetoDesplazamiento;

    [SerializeField]
    private LayerMask capaHierba;

    [SerializeField]
    private float distanciaMaxima = 2f;

    private MeshRenderer desplazamientoRenderer;
    private MaterialPropertyBlock propiedadesBlock;

    private int transparenciaGuid;

    private Ray cacheadoRay;

    private void Awake()
    {
        if (objetoDesplazamiento != null)
        {
            propiedadesBlock = new MaterialPropertyBlock();

            desplazamientoRenderer = objetoDesplazamiento.GetComponent<MeshRenderer>();
            desplazamientoRenderer.GetPropertyBlock(propiedadesBlock);

            cacheadoRay = new Ray(this.transform.position, Vector3.down);

            transparenciaGuid = Shader.PropertyToID("_Transparency");
        }
    }

    private void Update()
    {
        cacheadoRay.origin = this.transform.position;

#if UNITY_EDITOR
        Awake();
#endif

        if (Physics.Raycast(cacheadoRay, out RaycastHit hit, distanciaMaxima, capaHierba))
        {
            propiedadesBlock.SetFloat(transparenciaGuid, hit.distance / distanciaMaxima);
            desplazamientoRenderer.SetPropertyBlock(propiedadesBlock);
        }
        else
        {
            propiedadesBlock.SetFloat(transparenciaGuid, 1f);
            desplazamientoRenderer.SetPropertyBlock(propiedadesBlock);
        }

        objetoDesplazamiento.transform.rotation = Quaternion.Euler(0f, objetoDesplazamiento.transform.rotation.eulerAngles.y, 0f);
    }
}
