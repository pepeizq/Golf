using System.Collections.Generic;
using UnityEngine;

namespace Recursos
{
    [CreateAssetMenu(fileName = "Campo", menuName = "Campo/Configuracion")]
    public class Campo : ScriptableObject
    {
        public List<Casilla> casillas;
        public List<CampoHoyo> hoyos;

        [Header("Materiales")]
        public Material casillaClaroOpaco;
        public Material casillaClaroTransparente;
        public Material casillaOscuroOpaco;
        public Material casillaOscuroTransparente;

        [Header("Cosas")]
        public GameObject hoyo;
        public List<GameObject> muros;
    }
}