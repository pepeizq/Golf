using UnityEngine;

namespace Recursos
{
    [CreateAssetMenu(fileName = "Casilla", menuName = "Escenario/Casilla")]
    public class Casilla : ScriptableObject
    {
        public int id;
        public int idDebug;
        [HideInInspector] public int idColocacion;

        public GameObject prefab;       

        [HideInInspector] public Vector3 posicion;
        [HideInInspector] public int rotacion;
        [HideInInspector] public bool modificable = true;

        public Casilla(int ID, int Rotacion, Vector3 Posicion)
        {
            id = ID;
            rotacion = Rotacion;
            posicion = Posicion;
        }
    }
}