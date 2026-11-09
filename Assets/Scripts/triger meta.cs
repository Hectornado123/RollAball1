using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrigerMeta : MonoBehaviour
{
    public Image imagenUI; // Asigna la imagen desde el Inspector
    public Image imagenUI2;
    public Image imagenUI3;

    public int points2;
    public bool Finish;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
<<<<<<< HEAD
           
=======
            //SceneManager.LoadScene("nivel 2");
>>>>>>> parent of 2376594 (PasarNivel)
        }
        // Verificar si el objeto que entra es el jugador
        if (other.CompareTag("Player"))
        {
            Debug.Log("Has llegado");
            Invoke("PasarEscena", 5);
            Finish = true;
        }

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

       
        Finish = false;
        points2 = 0;
        // Ocultar la imagen al inicio
        if (imagenUI != null)
        {
            imagenUI.enabled = false;
            imagenUI2.enabled = false;
            imagenUI3.enabled = false;
        }
    }
    private void Update()
    {
        if (Finish == true)
        {
            Debug.Log("tienes" + points2);
            if (imagenUI != null)
                imagenUI.enabled = true; // Mostrar imagen

            if (points2 >= 5)
            {
                imagenUI2.enabled = true;

            }
            if (points2 >= 8)
            {
                imagenUI3.enabled = true;

            }
        }
    }

}
