using UnityEngine;

namespace Partida
{
    [System.Serializable]
    public class Datos 
    {
        public PartidaCasilla[] casillas;
        public PartidaEscenario escenario;
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
    public struct PartidaEscenario
    {
        public int tamañoEscenarioX;
        public int tamañoEscenarioZ;
    }
}

