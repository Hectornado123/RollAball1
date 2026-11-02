using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrigerMeta : MonoBehaviour
{
    public Image imagenUI; // Asigna la imagen desde el Inspector
    public Image imagenUI2;
    public Image imagenUI3;

    public int points2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("finish"))
        {

            Debug.Log("tienes" + points2);
            //SceneManager.LoadScene("nivel 2");
        }
        // Verificar si el objeto que entra es el jugador
        if (other.CompareTag("Player"))
        {
            if (imagenUI != null)
                imagenUI.enabled = true; // Mostrar imagen
        }

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Ocultar la imagen al inicio
        if (imagenUI != null)
        {
            imagenUI.enabled = false;
            imagenUI2.enabled = false;
            imagenUI3.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
