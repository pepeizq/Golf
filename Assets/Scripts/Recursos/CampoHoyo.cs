using UnityEngine;

namespace Recursos
{
    [CreateAssetMenu(fileName = "Hoyo", menuName = "Campo/Hoyo")]
    public class CampoHoyo : ScriptableObject
    {
        public int tama�oX;
        public int tama�oZ;

        public float alturaMaxima;

        public int intentosMordiscos;
    }
}