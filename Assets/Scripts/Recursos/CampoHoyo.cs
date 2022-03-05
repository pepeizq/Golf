using UnityEngine;

namespace Recursos
{
    [CreateAssetMenu(fileName = "Hoyo", menuName = "Campo/Hoyo")]
    public class CampoHoyo : ScriptableObject
    {
        public int tamañoX;
        public int tamañoZ;

        public float alturaMaxima;

        public int intentosMordiscos;
    }
}