using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

  


    public void Iniciar()
    {
        Debug.Log("A");
        SceneManager.LoadScene("0");
    }

   

   

    public void Salir()
    {
        Debug.Log("Has cerrado el juego");
        Application.Quit();
    }
}
