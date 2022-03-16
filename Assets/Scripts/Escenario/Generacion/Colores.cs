using Recursos;
using UnityEngine;

namespace Escenario.Generacion
{
    public class Colores : MonoBehaviour
    {
        public static Colores instancia;

        public void Awake()
        {
            instancia = this;
        }

        //Verde             esquina 2 rotacion 180
        //Gris              esquina 2 rotacion 270
        //Marron Claro      esquina 2 rotacion 90 
        //Morado            esquina 2 rotacion 0

        //Rojo              rampa 1 rotacion 90
        //Marron Oscuro     rampa 1 rotacion 180
        //Blanco            rampa 1 rotacion 270
        //Amarillo          rampa 1 rotacion 0

        //-----------------------------------------------------------------------

        //Verde - esquina2rotacion180
        public void Casilla_Xmenos1_Zmenos1(int x, float y, int z)
        {
            Casilla rampas4rotacion90 = new Casilla(4, 90, new Vector3(x - 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z - 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z - 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x - 2, z]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y - 0.5f, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z - 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }

            //---------------------------------------

            Casilla plano = new Casilla(0, 0, new Vector3(x - 1, y + 0.5f, z - 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(3, 90, new Vector3(x - 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Casilla esquina3rotacion270 = new Casilla(3, 270, new Vector3(x - 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Casilla esquina3rotacion180 = new Casilla(3, 180, new Vector3(x - 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla rampa1rotacion90 = new Casilla(1, 90, new Vector3(x - 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }

            //---------------------------------------

            Casilla rampa1rotacion180 = new Casilla(1, 180, new Vector3(x - 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }

            //---------------------------------------

            Casilla esquina2rotacion180 = new Casilla(2, 180, new Vector3(x - 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion180);
            }
        }

        //Gris - esquina2rotacion270
        public void Casilla_Xmenos1_Zmas1(int x, float y, int z)
        {
            Casilla rampas4rotacion0 = new Casilla(39, 0, new Vector3(x - 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 2], y, 90) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 2], y, 90) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x - 2, z]) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y - 0.5f, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 2], y, 90) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x - 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x - 2, z]) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z + 2], y - 0.5f, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x - 2, z]) == true && Escenario.instancia.ComprobarCasilla3(Escenario.instancia.casillasMapa[x, z + 2], y - 0.5f, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }

            //---------------------------------------

            Casilla plano = new Casilla(35, 0, new Vector3(x - 1, y + 0.5f, z + 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion180 = new Casilla(38, 180, new Vector3(x - 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla esquina3rotacion0 = new Casilla(38, 0, new Vector3(x - 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(38, 270, new Vector3(x - 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Casilla rampa1rotacion270 = new Casilla(36, 270, new Vector3(x - 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }

            //---------------------------------------

            Casilla rampa1rotacion180 = new Casilla(36, 180, new Vector3(x - 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }

            //---------------------------------------

            Casilla esquina2rotacion270 = new Casilla(37, 270, new Vector3(x - 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion270);
            }
        }

        //Marron Claro - esquina2rotacion90 
        public void Casilla_Xmas1_Zmenos1(int x, float y, int z)
        {
            Casilla plano = new Casilla(30, 0, new Vector3(x + 1, y + 0.5f, z - 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion180 = new Casilla(33, 180, new Vector3(x + 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z - 2]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla esquina3rotacion0 = new Casilla(33, 0, new Vector3(x + 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(33, 90, new Vector3(x + 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla rampa1rotacion0 = new Casilla(31, 0, new Vector3(x + 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }

            //---------------------------------------

            Casilla rampa1rotacion90 = new Casilla(31, 90, new Vector3(x + 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }

            //---------------------------------------

            Casilla esquina2rotacion90 = new Casilla(32, 90, new Vector3(x + 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion90);
            }
        }

        //Morado - esquina2rotacion0
        public void Casilla_Xmas1_Zmas1(int x, float y, int z)
        {
            Casilla plano = new Casilla(25, 0, new Vector3(x + 1, y + 0.5f, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z + 1]) == false && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z + 2]) == false)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z + 1]) == false)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z + 1]) == false && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z + 2]) == false)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion0 = new Casilla(28, 0, new Vector3(x + 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z]) == false && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z]) == false && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(28, 90, new Vector3(x + 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z + 1]) == false && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z + 2]) == false)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z + 2]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z]) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z]) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z + 1]) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Casilla esquina3rotacion270 = new Casilla(28, 270, new Vector3(x + 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z + 2]) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla3(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Casilla rampa1rotacion270 = new Casilla(26, 270, new Vector3(x + 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }

            //---------------------------------------

            Casilla rampa1rotacion0 = new Casilla(26, 0, new Vector3(x + 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }

            //---------------------------------------

            Casilla esquina2rotacion0 = new Casilla(27, 0, new Vector3(x + 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina2rotacion0);
            }
        }

        //Rojo - rampa1rotacion90
        public void Casilla_X0_Zmenos1(int x, float y, int z)
        {
            Casilla plano = new Casilla(20, 0, new Vector3(x, y + 0.5f, z - 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(23, 90, new Vector3(x, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Casilla esquina3rotacion180 = new Casilla(23, 180, new Vector3(x, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla rampa1rotacion90 = new Casilla(21, 90, new Vector3(x, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion90);
            }
        }

        //Marron Oscuro - rampa1rotacion180
        public void Casilla_Xmenos1_Z0(int x, float y, int z)
        {
            Casilla plano = new Casilla(5, 0, new Vector3(x - 1, y + 0.5f, z));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion270 = new Casilla(8, 270, new Vector3(x - 1, y, z));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Casilla esquina3rotacion180 = new Casilla(8, 180, new Vector3(x - 1, y, z));

            if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla rampa1rotacion180 = new Casilla(6, 180, new Vector3(x - 1, y, z));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion180);
            }
        }

        //Blanco - rampa1rotacion270
        public void Casilla_X0_Zmas1(int x, float y, int z)
        {
            Casilla plano = new Casilla(10, 0, new Vector3(x, y + 0.5f, z + 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion0 = new Casilla(13, 0, new Vector3(x, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x - 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Casilla esquina3rotacion270 = new Casilla(13, 270, new Vector3(x, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 2], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Casilla rampa1rotacion270 = new Casilla(11, 270, new Vector3(x, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion270);
            }
        }

        //Amarillo - rampa1rotacion0
        public void Casilla_Xmas1_Z0(int x, float y, int z)
        {
            Casilla plano = new Casilla(15, 0, new Vector3(x + 1, y + 0.5f, z));

            if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z]) == false)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion0 = new Casilla(18, 0, new Vector3(x + 1, y, z));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 1], y, 270) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z - 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(18, 90, new Vector3(x + 1, y, z));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 180) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 1, z + 1], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Casilla rampa1rotacion0 = new Casilla(16, 0, new Vector3(x + 1, y, z));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla1(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true)
            {
                Escenario.instancia.PonerCasilla(rampa1rotacion0);
            }
        }

        //-----------------------------------------------------------------------

        public void PonerRampas4MarronClaro(int x, float y, int z)
        {
            Casilla rampas4rotacion0 = new Casilla(34, 0, new Vector3(x + 1, y, z - 1));

            if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 270) == true && ComprobarRampas4MarronClaro(x, y, z) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && ComprobarRampas4MarronClaro(x, y, z) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 90) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 270) == true && ComprobarRampas4MarronClaro(x, y, z) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z - 2], y, 0) == true && ComprobarRampas4MarronClaro(x, y, z) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion0);
            }
        }

        public void PonerRampas4Morado(int x, float y, int z)
        {
            Casilla rampas4rotacion90 = new Casilla(29, 90, new Vector3(x + 1, y, z + 1));

            if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && ComprobarRampas4Morado(x, y, z) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && ComprobarRampas4Morado(x, y, z) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla2(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 180) == true && ComprobarRampas4Morado(x, y, z) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
            else if (Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x, z], y, 0) == true && Escenario.instancia.ComprobarCasilla0(Escenario.instancia.casillasMapa[x + 2, z + 2], y, 0) == true && ComprobarRampas4Morado(x, y, z) == true)
            {
                Escenario.instancia.PonerCasilla(rampas4rotacion90);
            }
        }

        private bool ComprobarRampas4Morado(int x, float y, int z)
        {
            if (Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z]) == true &&
                Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z]) == true &&
                Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z + 1]) == true &&
                Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z + 1]) == true &&
                Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z + 2]) == true &&
                Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z + 2]) == true)
            {
                return true;
            }

            return false;
        }

        private bool ComprobarRampas4MarronClaro(int x, float y, int z)
        {
            if (Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z]) == true &&
                Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z]) == true &&
                Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 2, z - 1]) == true &&
                Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z - 1]) == true &&
                Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x, z - 2]) == true &&
                Escenario.instancia.ComprobarVacio(Escenario.instancia.casillasMapa[x + 1, z - 2]) == true)
            {
                return true;
            }

            return false;
        }
    }
}