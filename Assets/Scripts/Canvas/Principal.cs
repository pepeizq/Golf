using Partida;
using Recursos;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Canvas2
{
    public class Principal : MonoBehaviour
    {
        public List<Campo> campos;
        private int totalPartidas = 0;
        private List<PartidaMaestro> partidas = new List<PartidaMaestro>();

        [Header("Principal")]
        public Canvas canvasMenu;
        public Button botonContinuarPartida;
        public Button botonCargarPartida;

        [Header("Cargando")]
        public Canvas canvasCargando;
        public Slider sliderCargando;

        [Header("Nueva Partida")]
        public Canvas canvasNuevaPartida;
        public RectTransform panelCampos;
        public GameObject prefabBotonCampo;

        [Header("Cargar Partida")]
        public Canvas canvasCargarPartida;
        public RectTransform panelPartidas;
        public GameObject prefabBotonCargarPartida;

        private AsyncOperation cargando = null;

        public void Start()
        {
            totalPartidas = PlayerPrefs.GetInt("totalPartidas");

            int i = 0;
            while (i <= totalPartidas)
            {
                if (Cargar.CargarBola(i) != null)
                {
                    PartidaMaestro partida = Cargar.CargarBola(i);
                    partidas.Add(partida);
                }
                i += 1;
            }

            if (partidas.Count > 0)
            {
                partidas.Sort((i, j) => i.fecha.CompareTo(j.fecha));
            }
            
            if (partidas.Count == 0)
            {
                botonContinuarPartida.gameObject.SetActive(false);
                botonCargarPartida.gameObject.SetActive(false);
            }
            else
            {
                botonContinuarPartida.gameObject.SetActive(true);
                botonCargarPartida.gameObject.SetActive(true);
            }
        }

        public void Update()
        {
            if (cargando != null)
            {
                sliderCargando.value = Mathf.Clamp01(cargando.progress / 0.9f);
            }
        }

        //------------------------------------------------------------------

        public void NuevaPartidaMostrar()
        {
            canvasMenu.gameObject.SetActive(false);
            canvasNuevaPartida.gameObject.SetActive(true);

            foreach (Transform boton in panelCampos.gameObject.transform)
            {
                Destroy(boton.gameObject);
            }

            foreach (Campo campo in campos)
            {
                GameObject boton = Instantiate(prefabBotonCampo, new Vector3(0, 0, 0), Quaternion.identity);
                boton.transform.SetParent(panelCampos.gameObject.transform);

                TextMeshProUGUI texto = boton.GetComponentInChildren<TextMeshProUGUI>();
                texto.text = string.Format("ID: {0} - Hoyos: {1}", campo.id.ToString(), campo.hoyos.Count.ToString());

                Button boton2 = boton.GetComponent<Button>();
                boton2.onClick.RemoveAllListeners();
                boton2.onClick.AddListener(() => NuevaPartida(campo.id));
            }
        }

        private void NuevaPartida(int campo)
        {
            totalPartidas += 1;
            PlayerPrefs.SetInt("totalPartidas", totalPartidas);

            PlayerPrefs.SetInt("numeroPartida", totalPartidas);
            PlayerPrefs.SetInt(totalPartidas.ToString() + "campo", campo);

            canvasNuevaPartida.gameObject.SetActive(false);
            canvasCargando.gameObject.SetActive(true);
            sliderCargando.value = 0;

            cargando = SceneManager.LoadSceneAsync("Escenario");
        }

        public void NuevaPartidaVolver()
        {
            canvasNuevaPartida.gameObject.SetActive(false);
            canvasMenu.gameObject.SetActive(true);
        }

        //------------------------------------------------------------------

        public void ContinuarPartida()
        {
            PartidaMaestro ultimaPartida = partidas[partidas.Count - 1];

            PlayerPrefs.SetString("continuarPartida", "si");
            PlayerPrefs.SetInt("numeroPartida", ultimaPartida.numeroPartida);
            PlayerPrefs.SetInt(ultimaPartida.numeroPartida.ToString() + "campo", ultimaPartida.campo);

            canvasMenu.gameObject.SetActive(false);
            canvasCargando.gameObject.SetActive(true);
            sliderCargando.value = 0;

            cargando = SceneManager.LoadSceneAsync("Escenario");
        }

        //------------------------------------------------------------------

        public void CargarPartidaMostrar()
        {
            canvasMenu.gameObject.SetActive(false);
            canvasCargarPartida.gameObject.SetActive(true);

            foreach (Transform boton in panelPartidas.gameObject.transform)
            {
                Destroy(boton.gameObject);
            }

            foreach (PartidaMaestro partida in partidas)
            {
                GameObject boton = Instantiate(prefabBotonCargarPartida, new Vector3(0, 0, 0), Quaternion.identity);
                boton.transform.SetParent(panelPartidas.gameObject.transform);

                TextMeshProUGUI texto = boton.GetComponentInChildren<TextMeshProUGUI>();
                texto.text = string.Format("ID: {0} - Campo: {1} - Hoyo: {2} - {3}", partida.numeroPartida.ToString(), partida.campo.ToString(), (partida.hoyo + 1).ToString(), partida.fecha.ToString());

                Button boton2 = boton.GetComponent<Button>();
                boton2.onClick.RemoveAllListeners();
                boton2.onClick.AddListener(() => CargarPartida(partida.numeroPartida, partida.campo));
            }
        }

        private void CargarPartida(int id, int campo)
        {
            PlayerPrefs.SetString("continuarPartida", "si");
            PlayerPrefs.SetInt("numeroPartida", id);
            PlayerPrefs.SetInt(id.ToString() + "campo", campo);

            canvasCargarPartida.gameObject.SetActive(false);
            canvasCargando.gameObject.SetActive(true);
            sliderCargando.value = 0;

            cargando = SceneManager.LoadSceneAsync("Escenario");
        }

        public void CargarPartidaVolver()
        {
            int i = 0;
            foreach (Transform boton in panelPartidas.gameObject.transform)
            {
                i += 1;
            }

            if (i == 0)
            {
                botonContinuarPartida.gameObject.SetActive(false);
                botonCargarPartida.gameObject.SetActive(false);
            }

            canvasMenu.gameObject.SetActive(true);
            canvasCargarPartida.gameObject.SetActive(false);
        }
    }
}