using UnityEngine;
using TMPro;

public class Tiempo : MonoBehaviour
{
    public TextMeshProUGUI textoGUI;
    private float contador = 0;

    void Update()
    {
        // Acumular el tiempo transcurrido
        contador += Time.deltaTime;

        // Calcular minutos y segundos exactos a partir del contador total
        int minutosActuales = Mathf.FloorToInt(contador / 60);
        int segundos = Mathf.FloorToInt(contador % 60);

        // Actualizar el texto con formato de dos dígitos (00:00)
        textoGUI.text = minutosActuales.ToString("00") + ":" + segundos.ToString("00");
    }
}
