using UnityEngine;
using UnityEngine.SceneManagement;  //Libreria para cambiar de escenas, cerrar juego, etc
using TMPro;                        //Libreria para referenciar objetos de Text Mesh Pro

public class GameManager : MonoBehaviour
{
    public int points;                      //Cantidad de puntos actuales del jugador
    public int winPoints;                   //Cantidad de puntos para ganar

    public TMP_Text pointsText;             //Referencia al texto de puntos actuales
    public GameObject winPanel;             //Referencia al panel de victoria


    // METODO START
    void Start()
    {
        points = 0;
    }

    // METODO UPDATE
    void Update()
    {
        pointsText.text = "Points: " + points.ToString();
        if (points >= winPoints)
        {
            winPanel.SetActive(true);
        }
    }

    // METODOS PERSONALIZADOS (son llamados desde los botones del menu)
    public void RestartGame(int sceneToLoad)
    {
        
        SceneManager.LoadScene(sceneToLoad);    //Carga la escena del mismo valor que sceneToLoad
    }

    public void QuitGame()
    {
        Application.Quit();                     //Cerrar el juego
    }
}
