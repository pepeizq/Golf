using System.Collections;
using System.Xml;
using TMPro;
using UnityEngine;

namespace Interfaz.Idiomas
{
    public class Idiomas : MonoBehaviour
    {
        public TextAsset ficheroIdiomas;

        private Hashtable cadenas;

        public static Idiomas instancia;

        public void Awake()
        {
            if (instancia == null)
            {
                instancia = this;
                DontDestroyOnLoad(this);
            }
            else if (this != instancia)
            {
                Destroy(gameObject);
            }
        }

        public void CargarTraducciones(Escenas escena)
        {
            if (PlayerPrefs.GetString("idioma") == string.Empty)
            {
                DetectarIdioma();
            }
      
            CargarIdiomaXml(ficheroIdiomas, PlayerPrefs.GetString("idioma"));

            if (escena == Escenas.Principal)
            {
                ObjetosPrincipal.instancia.CargarTextos();
                ObjetosCargando.instancia.CargarTextos();
                ObjetosNuevaPartida.instancia.CargarTextos();
                ObjetosCargarPartida.instancia.CargarTextos();
                ObjetosMultiConexion.instancia.CargarTextos();
                ObjetosMultiLobby.instancia.CargarTextos();
                ObjetosMultiSala.instancia.CargarTextos();
                ObjetosPersonalizarBola.instancia.CargarTextos();
                ObjetosOpciones.instancia.CargarTextos();
            }
            else if (escena == Escenas.Escenario)
            {
                ObjetosEscenario.instancia.CargarTextos();
            }
        }

        public void CargarDropdownOpciones(TMP_Dropdown dp)
        {
            dp.options.Clear();

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(ficheroIdiomas.text);

            int i = 0;
            while (i < xml.ChildNodes.Count)
            {
                XmlNode nodo = xml.ChildNodes[i];

                int j = 0;
                while (j < nodo.ChildNodes.Count)
                {
                    XmlNode nodo2 = nodo.ChildNodes[j];
                    XmlElement elemento = xml.DocumentElement[nodo2.Name];

                    IEnumerator elemEnum = elemento.GetEnumerator();
                    while (elemEnum.MoveNext())
                    {
                        XmlElement xmlItem = (XmlElement)elemEnum.Current;

                        if (xmlItem.GetAttribute("name") == "language")
                        {
                            TMP_Dropdown.OptionData opcion = new TMP_Dropdown.OptionData();
                            opcion.text = xmlItem.InnerText;

                            dp.options.Add(opcion);
                        }
                    }

                    if (nodo2.Name == PlayerPrefs.GetString("idioma"))
                    {
                        dp.value = j;
                    }

                    j += 1;
                }
                i += 1;
            }
        }

        public void CambiarIdioma(TMP_Dropdown dp)
        {
            int seleccionado = dp.value;

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(ficheroIdiomas.text);

            int i = 0;
            while (i < xml.ChildNodes.Count)
            {
                XmlNode nodo = xml.ChildNodes[i];

                int j = 0;
                while (j < nodo.ChildNodes.Count)
                {
                    XmlNode nodo2 = nodo.ChildNodes[j];

                    if (j == seleccionado)
                    {
                        CargarIdiomaXml(ficheroIdiomas, nodo2.Name);
                        PlayerPrefs.SetString("idioma", nodo2.Name);
                        CargarTraducciones(0);
                    }

                    j += 1;
                }
                i += 1;
            }    
        }

        public void CargarIdiomaXml(TextAsset fichero, string idioma)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(fichero.text);

            cadenas = new Hashtable();
            XmlElement elemento = xml.DocumentElement[idioma];

            if (elemento != null)
            {
                IEnumerator elemEnum = elemento.GetEnumerator();
                while (elemEnum.MoveNext())
                {
                    XmlElement xmlItem = (XmlElement)elemEnum.Current;
                    cadenas.Add(xmlItem.GetAttribute("name"), xmlItem.InnerText);
                }
            }
        }

        public string CogerCadena(string clave)
        {
            if (cadenas != null)
            {
                if (cadenas.ContainsKey(clave))
                {
                    return (string)cadenas[clave];
                }
            }

            return null;
        }

        private void DetectarIdioma()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(ficheroIdiomas.text);

            int i = 0;
            while (i < xml.ChildNodes.Count)
            {
                XmlNode nodo = xml.ChildNodes[i];

                int j = 0;
                while (j < nodo.ChildNodes.Count)
                {
                    XmlNode nodo2 = nodo.ChildNodes[j];

                    if (nodo2.Name == Application.systemLanguage.ToString())
                    {
                        PlayerPrefs.SetString("idioma", nodo2.Name);
                    }

                    j += 1;
                }
                i += 1;
            }
         
            if (PlayerPrefs.GetString("idioma") == string.Empty)
            {
                PlayerPrefs.SetString("idioma", "English");
            }
        }

        public enum Escenas { Principal, Escenario }
    }
}
