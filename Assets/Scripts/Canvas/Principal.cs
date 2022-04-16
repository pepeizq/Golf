using Jugador;
using Partida;
using Recursos;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Canvas2
{
    public class Principal : MonoBehaviour
    {
        private int totalPartidas = 0;
        private List<PartidaMaestro> partidas = new List<PartidaMaestro>();

        [Header("Principal")]
        public Canvas canvasMenu;
        public Button botonContinuarPartida;
        public Button botonCargarPartida;
        public TMP_Dropdown dropdownColor;

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

        [Header("Multijugador")]
        public Canvas canvasConexion;

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
                partidas.Sort((i, j) => Convert.ToDateTime(j.fecha).CompareTo(Convert.ToDateTime(i.fecha)));
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

            //----------------------------------------

            dropdownColor.ClearOptions();

            List<string> opciones = new List<string>();
            opciones.Add("Rojo");
            opciones.Add("Verde");
            opciones.Add("Azul");

            dropdownColor.AddOptions(opciones);
            dropdownColor.value = PlayerPrefs.GetInt("colorJugador");
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

            foreach (Campo campo in Campos.instancia.campos)
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

            Unjugador.instancia.nuevaPartida = true;

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
            Unjugador.instancia.partida = ultimaPartida;
            Unjugador.instancia.nuevaPartida = false;

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
                boton.transform.localScale = Vector3.one;

                TextMeshProUGUI texto = boton.GetComponentInChildren<TextMeshProUGUI>();
                texto.text = string.Format("ID: {0} - Campo: {1} - Hoyo: {2} - {3}", partida.numeroPartida.ToString(), partida.campo.ToString(), (partida.nivel + 1).ToString(), partida.fecha.ToString());

                Button boton2 = boton.GetComponent<Button>();
                boton2.onClick.RemoveAllListeners();
                boton2.onClick.AddListener(() => CargarPartida(partida));
            }
        }

        private void CargarPartida(PartidaMaestro partida)
        {
            Unjugador.instancia.partida = partida;
            Unjugador.instancia.nuevaPartida = false;

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

        //------------------------------------------------------------------

        public void MultijugadorMostrar()
        {
            canvasMenu.gameObject.SetActive(false);
            canvasConexion.gameObject.SetActive(true);

            MultiConexion.instancia.Conectar();
        }

        //------------------------------------------------------------------

        public void CambiarColorJugador()
        {
            if (dropdownColor.value == 0)
            {
                Atributos.instancia.color = UnityEngine.Color.red;
            }
            else if (dropdownColor.value == 1)
            {
                Atributos.instancia.color = UnityEngine.Color.green;
            }
            else if (dropdownColor.value == 2)
            {
                Atributos.instancia.color = UnityEngine.Color.blue;
            }

            PlayerPrefs.SetInt("colorJugador", dropdownColor.value);
        }
    }
}