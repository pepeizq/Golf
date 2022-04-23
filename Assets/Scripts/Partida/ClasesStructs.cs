using System.Collections.Generic;
using UnityEngine;

namespace Partida
{
    [System.Serializable]
    public struct VectorDos
    {
        public float x;
        public float y;

        public VectorDos(Vector2 vector)
        {
            x = vector.x;
            y = vector.y;
        }

        public Vector2 ObtenerVector2()
        {
            return new Vector2(x, y);
        }
    }

    [System.Serializable]
    public struct VectorTres
    {
        public float x;
        public float y;
        public float z;

        public VectorTres(Vector3 vector)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
        }

        public Vector3 ObtenerVector3()
        {
            return new Vector3(x, y, z);
        }
    }

    //-----------------------------------------------------------------------

    [System.Serializable]
    public class PartidaMaestro
    {
        public VectorTres posicion;
        public float angulo;
        public int golpes;
        public float zoom;
        public string fecha;
        public int campo;
        public int nivel;
        public int numeroPartida;
        public PartidaEscenario escenario;
        public PartidaHoyo hoyo;
        public List<PartidaRegistro> registro;
    }

    //-----------------------------------------------------------------------

    [System.Serializable]
    public class PartidaEscenario 
    {
        public PartidaCasilla[] casillas;
        public PartidaTamaño tamaño;
    }

    [System.Serializable]
    public struct PartidaCasilla
    {
        public int idCasilla;
        public VectorTres coordenadas;
        public int rotacion;
        public int x;
        public int z;
    }
 
    [System.Serializable]
    public struct PartidaTamaño
    {
        public int tamañoEscenarioX;
        public int tamañoEscenarioZ;
    }

    //-----------------------------------------------------------------------

    [System.Serializable]
    public class PartidaHoyo
    {
        public int casillaX;
        public int casillaZ;
    }

    //-----------------------------------------------------------------------

    [System.Serializable]
    public class PartidaRegistro
    {
        public int hoyo;
        public int golpes;
    }

    //-----------------------------------------------------------------------

    [System.Serializable]
    public class PartidaCoordenadas
    {
        public VectorDos[] coordenada;
    }
}

