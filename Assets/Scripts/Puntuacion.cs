
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;
    public TextMeshProUGUI textoTiempo;
    public TextMeshProUGUI textoRango;

    public GameObject panelResultados;

    float contador = 300;
    bool terminado = false;

    void Start()
    {
        panelResultados.SetActive(false);
    }

    void Update()
    {
        if (terminado == false)
        {
            contador = contador - Time.deltaTime;

            if (contador < 0)
            {
                contador = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && terminado == false)
        {
            terminado = true;

            int minutos = Mathf.FloorToInt((300 - contador) / 60);

            int puntuacion = 100 - (minutos * 20);

            if (puntuacion < 0)
            {
                puntuacion = 0;
            }

            textoPuntuacion.text = "Puntuacion: " + puntuacion + " / 100";

            textoTiempo.text = "Tiempo restante: " + contador.ToString("F0") + " segundos";

            if (puntuacion < 20)
            {
                textoRango.text = "Rango: F";
            }
            else if (puntuacion < 40)
            {
                textoRango.text = "Rango: A";
            }
            else if (puntuacion < 80)
            {
                textoRango.text = "Rango: SS";
            }
            else
            {
                textoRango.text = "Rango: SS+";
            }

            panelResultados.SetActive(true);

            Time.timeScale = 0;
        }
    }
}
