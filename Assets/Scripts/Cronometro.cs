using UnityEngine;
using TMPro;
public class Cronometro : MonoBehaviour
{

    public TextMeshProUGUI
    float contador = 300;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador = contador - Time.deltaTime;
        textoGUI.text = contador.ToString();

    }


}
