using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Interfaz
{
    public class ObjetosTablaGolpes : MonoBehaviour
    {
        [Header("Canvas")]
        public Canvas canvas;

        [Header("Paneles")]
        public RectTransform panel;
        public RectTransform panelCabecera;
        public RectTransform panelGolpes;

        [Header("Prefabs")]
        public GameObject panelGolpe;

        public static ObjetosTablaGolpes instancia;

        public void Awake()
        {
            instancia = this;
        }
    }
}