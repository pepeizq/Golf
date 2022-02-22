using Escenario.Generacion;
using Partida;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Escenario
{
    public class Escenario : MonoBehaviour
    {
        [Header("Opciones")]
        public bool debug;
        public bool aleatorio;
        public bool coloresGeneracion;
        public bool llano;

        [Header("Datos")]
        public int alturaMaxima = 3;
        public Vector2 tamañoEscenario = new Vector2(20, 20);

        public Casilla[] casillasFinal;
        public Casilla[] casillasDebug;

        [HideInInspector] public Casilla[,] casillasMapa = new Casilla[1, 1];
        [HideInInspector] public List<Vector3> casillasIniciales;
        [HideInInspector] public float casillasEscala = 0.5f;
        [HideInInspector] public int limitesMapa = 3;

        public static Escenario instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Start()
        {
            casillasMapa = new Casilla[(int)tamañoEscenario.x, (int)tamañoEscenario.y];
        
            if (aleatorio == true)
            {
                casillasIniciales = Vectores.instancia.GenerarCasillas(casillasMapa, tamañoEscenario, alturaMaxima, limitesMapa);
                CopiarDatos(casillasIniciales, (int)tamañoEscenario.x, (int)tamañoEscenario.y);
            }
            else
            {
                casillasIniciales = LeerDatos();
            }

            int k = 0;
            float altura = alturaMaxima;
            int tope = (int)alturaMaxima * 2;
            while (k < tope)
            {
                altura -= 0.5f;

                if (altura <= 1f)
                {
                    break;
                }
                
                try
                {          
                    GenerarNivel(altura);
                }
                catch (Exception fallo)
                {
                    Debug.Log(fallo);
                    k -= 1;
                }

                k += 1;
            }

            //----------------------------------------------------------

            if (llano == true)
            {
                Llano.instancia.Generar(casillasMapa, altura, casillasFinal[0]);
            }
        }

        public void Update()
        {

        }

        //------------------------------------------------------------------------------------------------------------------------------------

        private void GenerarNivel(float altura)
        {
            if (casillasIniciales != null)
            {
                if (casillasIniciales.Count > 0)
                {
                    foreach (Vector3 vector in casillasIniciales)
                    {
                        if (vector.y == altura)
                        {
                            PonerCasilla(new Casilla(0, 0, vector));
                        }
                    }
                }
            }

            foreach (Casilla subcasilla in casillasMapa)
            {
                if (subcasilla != null)
                {
                    int x = (int)subcasilla.posicion.x;
                    int z = (int)subcasilla.posicion.z;
                 
                    float y = subcasilla.posicion.y;
                    y = y - 0.5f;

                    if (y < 0.0f)
                    {
                        y = 0.0f;
                    }
                    
                    if ((y > 0) && (altura == subcasilla.posicion.y) && Limites.Comprobar(x, 2, (int)tamañoEscenario.x) == true && Limites.Comprobar(z, 2, (int)tamañoEscenario.y) == true)
                    {
                        if (casillasMapa[x - 1, z - 1] == null)
                        {
                            Colores.instancia.Casilla_Xmenos1_Zmenos1(x, y, z);
                        }

                        if (casillasMapa[x - 1, z + 1] == null)
                        {
                            Colores.instancia.Casilla_Xmenos1_Zmas1(x, y, z);
                        }

                        if (casillasMapa[x + 1, z - 1] == null)
                        {
                            Colores.instancia.Casilla_Xmas1_Zmenos1(x, y, z);
                        }

                        if (casillasMapa[x + 1, z + 1] == null)
                        {
                            Colores.instancia.Casilla_Xmas1_Zmas1(x, y, z);
                        }

                        if (casillasMapa[x, z - 1] == null)
                        {
                            Colores.instancia.Casilla_X0_Zmenos1(x, y, z);
                        }

                        if (casillasMapa[x - 1, z] == null)
                        {
                            Colores.instancia.Casilla_Xmenos1_Z0(x, y, z);
                        }

                        if (casillasMapa[x, z + 1] == null)
                        {
                            Colores.instancia.Casilla_X0_Zmas1(x, y, z);
                        }

                        if (casillasMapa[x + 1, z] == null)
                        {
                            Colores.instancia.Casilla_Xmas1_Z0(x, y, z);
                        }
                    }
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------

        public void PonerCasilla(Casilla casilla)
        {
            Casilla[] casillasFinal2;
            int id = casilla.id;
            int idDebug = casilla.idDebug;

            if (coloresGeneracion == false)
            {
                if (idDebug != 99)
                {
                    idDebug = id;
                }
                
                if (id != casillasDebug.Length - 1 && idDebug != 99)
                {
                    id = CalcularIDFinal(id);
                }

                if (debug == false)
                {
                    casillasFinal2 = casillasFinal;                 
                }
                else
                {
                    casillasFinal2 = casillasDebug;
                }
            }
            else
            {
                if (idDebug == 99)
                {
                    if (debug == false)
                    {
                        casillasFinal2 = casillasFinal;
                    }
                    else
                    {
                        casillasFinal2 = casillasDebug;
                    }
                }
                else
                {
                    casillasFinal2 = casillasDebug;
                    idDebug = id;
                }         
            }

            int x = (int)casilla.posicion.x;
            int z = (int)casilla.posicion.z;
       
            if (Limites.Comprobar(x, 3, (int)tamañoEscenario.x) == true && Limites.Comprobar(z, 3, (int)tamañoEscenario.y) == true)
            {
                if (casillasMapa[x, z] == null)
                {
                    Vector3 posicionFinal = casilla.posicion;
                 
                    GameObject casilla2 = Instantiate(casillasFinal2[id].prefab, posicionFinal, Quaternion.identity);
                    casilla2.gameObject.transform.Rotate(Vector3.up, casilla.rotacion, Space.World);

                    Casilla casilla3 = new Casilla(id, casilla.rotacion, casilla.posicion);
                    casilla3.id = id;
                    casilla3.idDebug = idDebug;
                    casilla3.prefab = casilla2;
                    casilla3.prefab.gameObject.layer = LayerMask.NameToLayer("Terreno");

                    casillasMapa[x, z] = casilla3;
                }
            }
        }

        public int CalcularIDFinal(int id)
        {
            if (id >= 5 && id <= 9)
            {
                id = id - 5;
            }
            else if (id >= 10 && id <= 14)
            {
                id = id - 10;
            }
            else if (id >= 15 && id <= 19)
            {
                id = id - 15;
            }
            else if (id >= 20 && id <= 24)
            {
                id = id - 20;
            }
            else if (id >= 25 && id <= 29)
            {
                id = id - 25;
            }
            else if (id >= 30 && id <= 34)
            {
                id = id - 30;
            }
            else if (id >= 34 && id <= 39)
            {
                id = id - 35;
            }
            else if (id >= 40 && id <= 44)
            {
                id = id - 35;
            }

            return id;
        }

        public bool ComprobarCasilla0(Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 0)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 0)
                                {
                                    return true;
                                }
                            }                            
                        }
                    }
                }
            }

            return false;
        }

        public bool ComprobarCasilla1(Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 1)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        public bool ComprobarCasilla2(Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 2)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 2)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        public bool ComprobarCasilla3(Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 3)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 3)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        public bool ComprobarVacio(Casilla casilla)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, 3) == true && ComprobarLimiteZ((int)casilla.posicion.z, 3) == true)
                {
                    if (casillasMapa[(int)casilla.posicion.x, (int)casilla.posicion.z] != null)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    
        private bool ComprobarLimiteX(int x, int ajuste)
        {
            if ((x - ajuste >= 0) && (x + ajuste <= tamañoEscenario.x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ComprobarLimiteZ(int z, int ajuste)
        {
            if ((z - ajuste >= 0) && (z + ajuste <= tamañoEscenario.y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CopiarDatos(List<Vector3> listado, int tamañoX, int tamañoZ)
        {
            if (listado != null)
            {
                if (listado.Count > 0)
                {
                    Datos partida = new Datos();

                    PartidaCasilla[] casillas = new PartidaCasilla[listado.Count];

                    int i = 0;
                    foreach (Vector3 vector in listado)
                    {
                        casillas[i].coordenadas = new VectorTres(vector);
                        i += 1;
                    }

                    partida.casillas = casillas;

                    PartidaEscenario escenario = new PartidaEscenario();
                    escenario.tamañoEscenarioX = tamañoX;
                    escenario.tamañoEscenarioZ = tamañoZ;

                    partida.escenario = escenario;

                    string datos = JsonUtility.ToJson(partida);
                    Debug.Log(datos);
                    PlayerPrefs.SetString("partida", datos);
                }
            }  
        }

        private List<Vector3> LeerDatos()
        {
            Datos partida = JsonUtility.FromJson<Datos>(PlayerPrefs.GetString("partida"));
            List<Vector3> listado = new List<Vector3>();
           
            foreach (PartidaCasilla casilla in partida.casillas)
            {
                Vector3 casilla2 = casilla.coordenadas.ObtenerVector3();
                listado.Add(casilla2);
            }

            return listado;
        }
    }
}

