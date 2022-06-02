using Escenario;
using Partida;
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
                if (MultiPhoton.instancia.Conectado() == true)
                {

                }
                else
                {
                    foreach (Transform boton in Objetos.instancia.panelTablaGolpes.gameObject.transform)
                    {
                        Destroy(boton.gameObject);
                    }

                    List<PartidaRegistro> registro = Unjugador.instancia.partida.registro;

                    if (registro.Count > 0)
                    {
                        GameObject panel = Instantiate(Objetos.instancia.prefabTablaGolpesJugador, new Vector3(0, 0, 0), Quaternion.identity);
                        panel.transform.SetParent(Objetos.instancia.panelTablaGolpes.gameObject.transform);

                        int i = 0;
                        foreach (PartidaRegistro subregistro in registro)
                        {


                            TextMeshProUGUI texto = panel.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                            texto.text = string.Format("Hoyo: {0} - Golpes: {1}", subregistro.hoyo.ToString(), subregistro.golpes.ToString());
                        }
                    }
                }
            }
        }
    }
}
