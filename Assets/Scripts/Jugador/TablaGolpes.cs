using Escenario;
using Interfaz;
using Partida;
using Photon.Realtime;
using Recursos;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Jugador
{
    public class TablaGolpes : MonoBehaviour
    {
        private bool cambiando = false;
        [HideInInspector] public bool mostrar = false;

        public static TablaGolpes instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Enseñar()
        {
            if (ObjetosPartidaTerminada.instancia.canvas.gameObject.activeSelf == false)
            {
                StartCoroutine(Enseñar2());
            }   
        }

        IEnumerator Enseñar2()
        {
            if (cambiando == false)
            {
                cambiando = true;

                if (mostrar == true)
                {
                    mostrar = false;
                }
                else
                {
                    mostrar = true;
                }

                yield return new WaitForSeconds(0.25f);

                cambiando = false;
            }
        }

        public void Update()
        {
            if (mostrar == true)
            {
                ObjetosTablaGolpes.instancia.canvas.gameObject.SetActive(true);
            }
            else
            {
                ObjetosTablaGolpes.instancia.canvas.gameObject.SetActive(false);
            }

            if (ObjetosTablaGolpes.instancia.canvas.isActiveAndEnabled == true)
            {
                int k = 0;

                foreach (Transform panel in ObjetosTablaGolpes.instancia.panelCabecera.gameObject.transform.GetChild(0))
                {
                    if (k > Configuracion.instancia.campo.hoyos.Count)
                    {
                        panel.gameObject.SetActive(false);
                    }
                    else
                    {
                        panel.gameObject.SetActive(true);
                    }

                    if (k == 0 && MultiPhoton.instancia.Conectado() == false)
                    {
                        panel.gameObject.SetActive(false);
                    }

                    if (k + 1 == ObjetosTablaGolpes.instancia.panelCabecera.gameObject.transform.GetChild(0).childCount)
                    {
                        panel.gameObject.SetActive(true);

                        TextMeshProUGUI textoTotal = panel.transform.GetComponent<TextMeshProUGUI>();
                        textoTotal.text = Interfaz.Idiomas.Idiomas.instancia.CogerCadena("total");
                    }

                    k += 1;
                }

                //-------------------------------------------------------------------------------

                foreach (Transform panel in ObjetosTablaGolpes.instancia.panelGolpes.gameObject.transform)
                {
                    Destroy(panel.gameObject);
                }

                if (MultiPhoton.instancia.Conectado() == true)
                {
                    RectTransform alturaCabecera = ObjetosTablaGolpes.instancia.panelCabecera.gameObject.GetComponent<RectTransform>();
                    alturaCabecera.sizeDelta = new Vector2(470 + Configuracion.instancia.campo.hoyos.Count * 65 + 120, 60);

                    RectTransform alturaGolpes = ObjetosTablaGolpes.instancia.panelGolpes.gameObject.GetComponent<RectTransform>();
                    alturaGolpes.sizeDelta = new Vector2(470 + Configuracion.instancia.campo.hoyos.Count * 65 + 120, MultiPhoton.instancia.ListaJugadores().Length * 60);

                    List<int> mayorGolpes = new List<int>();

                    foreach (CampoHoyo hoyo in Configuracion.instancia.campo.hoyos)
                    {
                        mayorGolpes.Add(0);
                    }

                    foreach (Player jugador2 in MultiPhoton.instancia.ListaJugadores())
                    {
                        int tope = Configuracion.instancia.nivel + 1;
                        int i = 0;
                        while (i < tope)
                        {
                            i += 1;

                            if (mayorGolpes[i - 1] < int.Parse(jugador2.CustomProperties["GolpesHoyo" + i.ToString()].ToString()))
                            {
                                mayorGolpes[i - 1] = int.Parse(jugador2.CustomProperties["GolpesHoyo" + i.ToString()].ToString());
                            }
                        }
                    }

                    foreach (Player jugador2 in MultiPhoton.instancia.ListaJugadores())
                    {
                        GameObject panel = Instantiate(ObjetosTablaGolpes.instancia.prefabTablaGolpesJugador, new Vector3(0, 0, 0), Quaternion.identity);
                        panel.transform.SetParent(ObjetosTablaGolpes.instancia.panelGolpes.gameObject.transform);

                        int j = 0;
                        while (j < panel.transform.childCount)
                        {
                            TextMeshProUGUI texto = panel.transform.GetChild(j).GetComponent<TextMeshProUGUI>();
                            texto.text = string.Empty;

                            if (j > Configuracion.instancia.campo.hoyos.Count)
                            {
                                texto.gameObject.SetActive(false);
                            }
                            
                            j += 1;
                        }

                        TextMeshProUGUI textoNombre = panel.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                        textoNombre.text = jugador2.NickName;

                        int tope = Configuracion.instancia.nivel + 1;
                        int total = 0;
                        int i = 0;

                        while (i < tope)
                        {
                            i += 1;

                            TextMeshProUGUI textoGolpes = panel.transform.GetChild(i).GetComponent<TextMeshProUGUI>();
                            textoGolpes.text = jugador2.CustomProperties["GolpesHoyo" + i.ToString()].ToString();

                            total = total + (int)jugador2.CustomProperties["GolpesHoyo" + i.ToString()];

                            bool enseñar = false;

                            if (bool.Parse(jugador2.CustomProperties["TerminadoHoyo" + i.ToString()].ToString()) == false && i <= Configuracion.instancia.nivel)
                            {
                                enseñar = true;
                            } 
                            else if (bool.Parse(jugador2.CustomProperties["TerminadoHoyo" + i.ToString()].ToString()) == false && Configuracion.instancia.partidaTerminada == true)
                            {
                                enseñar = true;
                            }

                            if (enseñar == true)
                            {
                                textoGolpes.text = (mayorGolpes[i - 1] + Configuracion.instancia.golpesExtraMultijugador).ToString();
                                total = total + mayorGolpes[i - 1] + Configuracion.instancia.golpesExtraMultijugador;
                            }
                        }

                        TextMeshProUGUI textoTotal = panel.transform.GetChild(panel.transform.childCount - 1).GetComponent<TextMeshProUGUI>();
                        textoTotal.text = total.ToString();
                        textoTotal.gameObject.SetActive(true);
                    }
                }
                else
                {
                    RectTransform alturaCabecera = ObjetosTablaGolpes.instancia.panelCabecera.gameObject.GetComponent<RectTransform>();
                    alturaCabecera.sizeDelta = new Vector2(Configuracion.instancia.campo.hoyos.Count * 65 + 120, 60);

                    RectTransform alturaGolpes = ObjetosTablaGolpes.instancia.panelGolpes.gameObject.GetComponent<RectTransform>();
                    alturaGolpes.sizeDelta = new Vector2(Configuracion.instancia.campo.hoyos.Count * 65 + 120, 60);

                    List<PartidaRegistro> registro = Unjugador.instancia.partida.registro;

                    if (registro.Count > 0)
                    {
                        GameObject panel = Instantiate(ObjetosTablaGolpes.instancia.prefabTablaGolpesJugador, new Vector3(0, 0, 0), Quaternion.identity);
                        panel.transform.SetParent(ObjetosTablaGolpes.instancia.panelGolpes.gameObject.transform);

                        int j = 0;
                        while (j < panel.transform.childCount)
                        {
                            TextMeshProUGUI texto = panel.transform.GetChild(j).GetComponent<TextMeshProUGUI>();
                            texto.text = string.Empty;

                            if (j > Configuracion.instancia.campo.hoyos.Count)
                            {
                                texto.gameObject.SetActive(false);
                            }

                            j += 1;
                        }

                        TextMeshProUGUI textoNombre = panel.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                        textoNombre.gameObject.SetActive(false);

                        int total = 0;
                        int i = 0;

                        foreach (PartidaRegistro subregistro in registro)
                        {
                            i += 1;

                            TextMeshProUGUI textoGolpes = panel.transform.GetChild(i).GetComponent<TextMeshProUGUI>();
                            textoGolpes.text = subregistro.golpes.ToString();

                            total = total + subregistro.golpes;
                        }

                        TextMeshProUGUI textoTotal = panel.transform.GetChild(panel.transform.childCount - 1).GetComponent<TextMeshProUGUI>();
                        textoTotal.text = total.ToString();
                        textoTotal.gameObject.SetActive(true);
                    }
                }
            }
        }
    }
}
