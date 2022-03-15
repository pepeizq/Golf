using Partida;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Principal : MonoBehaviour
{
    private int numeroPartida = 0;

    public Canvas canvasMenu;
    public Button botonContinuarPartida;
    public Button botonCargarPartida;

    public Canvas canvasCargando;
    public Slider sliderCargando;

    public Canvas canvasCargarPartida;
    public RectTransform panelPartidas;
    public GameObject prefabBotonCargarPartida;

    private AsyncOperation cargando = null;

    public void Start()
    {
        numeroPartida = PlayerPrefs.GetInt("numeroPartida");

        if (numeroPartida == 0)
        {
            botonContinuarPartida.gameObject.SetActive(false);
            botonCargarPartida.gameObject.SetActive(false);
        }
        else
        {
            botonContinuarPartida.gameObject.SetActive(true);
            botonCargarPartida.gameObject.SetActive(true);
        }
    }

    public void Update()
    {
        if (cargando != null)
        {
            sliderCargando.value = Mathf.Clamp01(cargando.progress / 0.9f);
        }
    }

    public void NuevaPartida()
    {
        numeroPartida += 1;

        PlayerPrefs.SetInt("numeroPartida", numeroPartida);
        PlayerPrefs.SetInt(numeroPartida.ToString() + "nivel", 0);

        canvasMenu.gameObject.SetActive(false);
        canvasCargando.gameObject.SetActive(true);
        sliderCargando.value = 0;

        cargando = SceneManager.LoadSceneAsync("Escenario");
    }

    public void ContinuarPartida()
    {
        PlayerPrefs.SetString("continuarPartida", "si");

        canvasMenu.gameObject.SetActive(false);
        canvasCargando.gameObject.SetActive(true);
        sliderCargando.value = 0;

        cargando = SceneManager.LoadSceneAsync("Escenario");
    }

    public void CargarPartidaMostrar()
    {
        canvasMenu.gameObject.SetActive(false);
        canvasCargarPartida.gameObject.SetActive(true);

        foreach (Transform boton in panelPartidas.gameObject.transform)
        {
            Destroy(boton.gameObject);
        }

        int i = 0;
        while (i <= numeroPartida)
        {
            if (Cargar.CargarBola(i) != null)
            {
                PartidaMaestro partida = Cargar.CargarBola(i);

                GameObject boton = Instantiate(prefabBotonCargarPartida, new Vector3(0, 0, 0), Quaternion.identity);
                boton.transform.SetParent(panelPartidas.gameObject.transform);

                TextMeshProUGUI texto = boton.GetComponentInChildren<TextMeshProUGUI>();
                texto.text = string.Format("ID: {0} - Campo: {1} - Hoyo: {2} - {3}", partida.numeroPartida.ToString(), partida.campo.ToString(), (partida.hoyo + 1).ToString(), partida.fecha.ToString());

                Button boton2 = boton.GetComponent<Button>();
                boton2.onClick.RemoveAllListeners();
                boton2.onClick.AddListener(() => CargarPartida(partida.numeroPartida));
            }

            i += 1;
        }
    }

    private void CargarPartida(int id)
    {
        PlayerPrefs.SetString("continuarPartida", "si");
        PlayerPrefs.SetInt("numeroPartida", id);

        canvasCargarPartida.gameObject.SetActive(false);
        canvasCargando.gameObject.SetActive(true);
        sliderCargando.value = 0;

        cargando = SceneManager.LoadSceneAsync("Escenario");
    }

    public void CargarPartidaVolver()
    {
        int i = 0;
        foreach (Transform boton in panelPartidas.gameObject.transform)
        {
            i += 1;
        }

        if (i == 0)
        {
            botonContinuarPartida.gameObject.SetActive(false);
            botonCargarPartida.gameObject.SetActive(false);
        }

        canvasMenu.gameObject.SetActive(true);
        canvasCargarPartida.gameObject.SetActive(false);
    }
}
