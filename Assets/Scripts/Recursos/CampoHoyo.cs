using UnityEngine;

namespace Recursos
{
    [CreateAssetMenu(fileName = "Hoyo", menuName = "Campo/Hoyo")]
    public class CampoHoyo : ScriptableObject
    {
        public HoyoFormas forma;

        public int tamañoX;
        public int tamañoZ;

        public float alturaMaxima;

        public int intentosMordiscos;
    }

    public enum HoyoFormas { SinTocar, Jota33, Jota50, Jota66 }
}