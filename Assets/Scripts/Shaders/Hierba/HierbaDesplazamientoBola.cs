using UnityEngine;

[ExecuteInEditMode]
public class HierbaDesplazamientoBola : MonoBehaviour
{
    [SerializeField]
    private GameObject objetoDesplazamiento;

    [SerializeField]
    private LayerMask capaHierba;

    [SerializeField]
    private float distanciaMaxima = 2f;

    private MeshRenderer _displacementRenderer;
    private MaterialPropertyBlock _propertyBlock;

    private int _transparencyGuid;

    private Ray _cachedRay;

    private void Awake()
    {
        if (objetoDesplazamiento == null)
        {
            Debug.LogWarning("No Displacement Object has been set.");
        }           
        else
        {
            _propertyBlock = new MaterialPropertyBlock();

            _displacementRenderer = objetoDesplazamiento.GetComponent<MeshRenderer>();
            _displacementRenderer.GetPropertyBlock(_propertyBlock);

            _cachedRay = new Ray(this.transform.position, Vector3.down);

            _transparencyGuid = Shader.PropertyToID("_Transparency");
        }
    }

    private void Update()
    {
        _cachedRay.origin = this.transform.position;

#if UNITY_EDITOR
        Awake();
#endif

        if (Physics.Raycast(_cachedRay, out RaycastHit hit, distanciaMaxima, capaHierba))
        {
            _propertyBlock.SetFloat(_transparencyGuid, hit.distance / distanciaMaxima);
            _displacementRenderer.SetPropertyBlock(_propertyBlock);
        }
        else
        {
            _propertyBlock.SetFloat(_transparencyGuid, 1);
            _displacementRenderer.SetPropertyBlock(_propertyBlock);
        }

        //Fix X and Z rotations
        objetoDesplazamiento.transform.rotation = Quaternion.Euler(0f, objetoDesplazamiento.transform.rotation.eulerAngles.y, 0f);
    }
}
