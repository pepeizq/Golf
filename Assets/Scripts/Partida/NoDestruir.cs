using UnityEngine;

namespace Partida
{
    public class NoDestruir : MonoBehaviour
    {
        public void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}