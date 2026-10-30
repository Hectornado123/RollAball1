using UnityEngine;
using TMPro;

public class Vidas : MonoBehaviour
{
    public int videishons;
    
    public TextMeshProUGUI contadorVidas;

    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy")) {
            Debug.Log(contadorVidas.text);
        }
    }
}

