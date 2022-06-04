using Photon.Realtime;
using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace Jugador
{
    public class MultiNombres : MonoBehaviour
    {
        private bool cambiando = false;
        private bool mostrar = false;

        public static MultiNombres instancia;

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
            if (MultiPhoton.instancia.Conectado() == true)
            {
                if (mostrar == true)
                {
                    GameObject[] bolas = GameObject.FindGameObjectsWithTag("Player");

                    foreach (Player jugador2 in MultiPhoton.instancia.ListaJugadores())
                    {
                        foreach (GameObject bola in bolas)
                        {
                            if (bola != null)
                            {
                                int id = bola.transform.GetChild(0).gameObject.GetComponent<Bola>().id;

                                if (id == jugador2.ActorNumber)
                                {
                                    GameObject objetoNombre = bola.transform.GetChild(1).gameObject;
                                    TextMeshPro textoNombre = bola.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>();

                                    Vector3 posicion = bola.transform.GetChild(0).gameObject.transform.position;
                                    posicion.y = objetoNombre.transform.position.y;
                                    objetoNombre.transform.position = posicion;

                                    if (jugador2.IsLocal == false)
                                    {
                                        objetoNombre.gameObject.SetActive(true);
                                        textoNombre.text = jugador2.NickName;
                                    }
                                    else
                                    {
                                        objetoNombre.gameObject.SetActive(false);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    GameObject[] bolas = GameObject.FindGameObjectsWithTag("Player");

                    foreach (GameObject bola in bolas)
                    {
                        if (bola != null)
                        {
                            if (bola.transform.childCount >= 1)
                            {
                                try
                                {
                                    if (bola.transform.GetChild(1).gameObject != null)
                                    {
                                        GameObject objetoNombre = bola.transform.GetChild(1).gameObject;

                                        if (objetoNombre.gameObject.activeSelf == true)
                                        {
                                            objetoNombre.gameObject.SetActive(false);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {

                                }                                           
                            }    
                        }
                    }
                }
            }                
        }
    }
}
