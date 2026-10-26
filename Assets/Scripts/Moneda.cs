using System;
using TMPro;
using UnityEngine;

public class Moneda : MonoBehaviour
{
   float velocidad=1;

    public int contador;

    public TMP_Text textoUI;


    void Update()
    {
        transform.Rotate(velocidad, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Leemos textoUI y lo transformamos a Entero
        contador = Convert.ToInt32(textoUI.text);
        contador = contador + 1;

        //Cambiamos contador a string y se lo asignamos al textoUI
        textoUI.text = contador.ToString();
        Debug.Log("Points: " + contador );
        Destroy(gameObject);
    }
}
