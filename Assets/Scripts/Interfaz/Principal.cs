using Jugador;
using Partida;
using Principal;
using Recursos;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Interfaz
{
    public class Principal : MonoBehaviour
    {
        private int totalPartidas = 0;
        private List<PartidaMaestro> partidas = new List<PartidaMaestro>();

        private float segundosSumar;
        private int segundosTemporal = 1;

        private AsyncOperation cargando = null;

        public void Start()
        {
            totalPartidas = PlayerPrefs.GetInt("totalPartidas");

            Idiomas.Idiomas.instancia.CargarTraducciones(Idiomas.Idiomas.Escenas.Principal);

            int i = 0;
            while (i <= totalPartidas)
            {
                if (Cargar.CargarPartida(i) != null)
                {
                    PartidaMaestro partida = Cargar.CargarPartida(i);
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
                ObjetosPrincipal.instancia.botonContinuarPartida.gameObject.SetActive(false);
                ObjetosPrincipal.instancia.botonCargarPartida.gameObject.SetActive(false);
            }
            else
            {
                ObjetosPrincipal.instancia.botonContinuarPartida.gameObject.SetActive(true);
                ObjetosPrincipal.instancia.botonCargarPartida.gameObject.SetActive(true);
            }

            PersonalizarBola.instancia.Cargar();
            ObjetosPrincipal.instancia.version.text = Application.version;

            if (MultiPhoton.instancia.Conectado() == true)
            {
                MultiPhoton.instancia.Desconectar();
                ObjetosPrincipal.instancia.botonMultijugador.gameObject.SetActive(false);
            }
        }

        public void Update()
        {
            if (cargando != null)
            {
                ObjetosCargando.instancia.slider.value = Mathf.Clamp01(cargando.progress / 0.9f);
            }

            //-----------------------------------------------

            segundosSumar += Time.deltaTime;
            int segundosSumar2 = (int)(segundosSumar % 60);
          
            if (segundosSumar2 > segundosTemporal)
            {
                segundosTemporal = segundosSumar2;
             
                if (MultiPhoton.instancia.Conectado() == true)
                {
                    MultiPhoton.instancia.Desconectar();
                    ObjetosPrincipal.instancia.botonMultijugador.gameObject.SetActive(false);
                }
                else
                {
                    ObjetosPrincipal.instancia.botonMultijugador.gameObject.SetActive(true);
                }
            }
        }

        //------------------------------------------------------------------

        public void NuevaPartidaMostrar()
        {
            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(false);
            ObjetosNuevaPartida.instancia.canvas.gameObject.SetActive(true);

            foreach (Transform boton in ObjetosNuevaPartida.instancia.panelCampos.gameObject.transform)
            {
                Destroy(boton.gameObject);
            }

            foreach (Campo campo in Datos.instancia.campos)
            {
                GameObject boton = Instantiate(ObjetosNuevaPartida.instancia.prefabBotonCampo, new Vector3(0, 0, 0), Quaternion.identity);
                boton.transform.SetParent(ObjetosNuevaPartida.instancia.panelCampos.gameObject.transform);

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

            ObjetosNuevaPartida.instancia.canvas.gameObject.SetActive(false);
            ObjetosCargando.instancia.canvas.gameObject.SetActive(true);
            ObjetosCargando.instancia.slider.value = 0;

            cargando = SceneManager.LoadSceneAsync("Escenario");
        }

        public void NuevaPartidaVolver()
        {
            ObjetosNuevaPartida.instancia.canvas.gameObject.SetActive(false);
            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(true);
        }

        //------------------------------------------------------------------

        public void ContinuarPartida()
        {
            PartidaMaestro ultimaPartida = partidas[0];
            Unjugador.instancia.partida = ultimaPartida;
            Unjugador.instancia.nuevaPartida = false;

            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(false);
            ObjetosCargando.instancia.canvas.gameObject.SetActive(true);
            ObjetosCargando.instancia.slider.value = 0;

            cargando = SceneManager.LoadSceneAsync("Escenario");
        }

        //------------------------------------------------------------------

        public void CargarPartidaMostrar()
        {
            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(false);
            ObjetosCargarPartida.instancia.canvas.gameObject.SetActive(true);

            foreach (Transform boton in ObjetosCargarPartida.instancia.panelPartidas.gameObject.transform)
            {
                Destroy(boton.gameObject);
            }

            foreach (PartidaMaestro partida in partidas)
            {
                GameObject boton = Instantiate(ObjetosCargarPartida.instancia.prefabBotonCargarPartida, new Vector3(0, 0, 0), Quaternion.identity);
                boton.transform.SetParent(ObjetosCargarPartida.instancia.panelPartidas.gameObject.transform);
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

            ObjetosCargarPartida.instancia.canvas.gameObject.SetActive(false);
            ObjetosCargando.instancia.canvas.gameObject.SetActive(true);
            ObjetosCargando.instancia.slider.value = 0;

            cargando = SceneManager.LoadSceneAsync("Escenario");
        }

        public void CargarPartidaVolver()
        {
            int i = 0;
            foreach (Transform boton in ObjetosCargarPartida.instancia.panelPartidas.gameObject.transform)
            {
                i += 1;
            }

            if (i == 0)
            {
                ObjetosPrincipal.instancia.botonContinuarPartida.gameObject.SetActive(false);
                ObjetosPrincipal.instancia.botonCargarPartida.gameObject.SetActive(false);
            }

            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(true);
            ObjetosCargarPartida.instancia.canvas.gameObject.SetActive(false);
        }

        //------------------------------------------------------------------

        public void MultijugadorMostrar()
        {
            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(false);
            ObjetosMultiConexion.instancia.gameObject.SetActive(true);

            MultiConexion.instancia.Conectar();
        }

        //------------------------------------------------------------------

        public void PersonalizarMostrar()
        {
            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(false);
            ObjetosPersonalizarBola.instancia.canvas.gameObject.SetActive(true);
        }

        //------------------------------------------------------------------

        public void OpcionesMostrar()
        {
            ObjetosPrincipal.instancia.canvas.gameObject.SetActive(false);
            ObjetosOpciones.instancia.canvas.gameObject.SetActive(true);
        }

        //------------------------------------------------------------------

        public void Salir()
        {
            Application.Quit();
        }
    }
}