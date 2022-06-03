using Escenario;
using Partida;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Jugador
{
    public class TablaGolpes : MonoBehaviour
    {
        private bool cambiando = false;
        private bool mostrar = false;

        public static TablaGolpes instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Enseñar()
        {
            StartCoroutine(Enseñar2());
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
                Objetos.instancia.canvasTablaGolpes.gameObject.SetActive(true);
            }
            else
            {
                Objetos.instancia.canvasTablaGolpes.gameObject.SetActive(false);
            }

            if (Objetos.instancia.canvasTablaGolpes.isActiveAndEnabled == true)
            {
                foreach (Transform boton in Objetos.instancia.panelTablaGolpes.gameObject.transform)
                {
                    Destroy(boton.gameObject);
                }

                if (MultiPhoton.instancia.Conectado() == true)
                {
                    foreach (Player jugador2 in MultiPhoton.instancia.ListaJugadores())
                    {
                        GameObject panel = Instantiate(Objetos.instancia.prefabTablaGolpesJugador, new Vector3(0, 0, 0), Quaternion.identity);
                        panel.transform.SetParent(Objetos.instancia.panelTablaGolpes.gameObject.transform);

                        int j = 0;
                        while (j < panel.transform.childCount)
                        {
                            TextMeshProUGUI texto = panel.transform.GetChild(j).GetComponent<TextMeshProUGUI>();
                            texto.text = string.Empty;
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
                        }

                        TextMeshProUGUI textoTotal = panel.transform.GetChild(panel.transform.childCount - 1).GetComponent<TextMeshProUGUI>();
                        textoTotal.text = total.ToString();
                    }
                }
                else
                {
                    List<PartidaRegistro> registro = Unjugador.instancia.partida.registro;

                    if (registro.Count > 0)
                    {
                        GameObject panel = Instantiate(Objetos.instancia.prefabTablaGolpesJugador, new Vector3(0, 0, 0), Quaternion.identity);
                        panel.transform.SetParent(Objetos.instancia.panelTablaGolpes.gameObject.transform);

                        int j = 0;
                        while (j < panel.transform.childCount)
                        {
                            TextMeshProUGUI texto = panel.transform.GetChild(j).GetComponent<TextMeshProUGUI>();
                            texto.text = string.Empty;
                            j += 1;
                        }

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
                    }
                }
            }
        }
    }
}
