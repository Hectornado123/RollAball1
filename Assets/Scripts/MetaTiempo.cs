
using UnityEngine;

public class MetaTiempo : MonoBehaviour
{
    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3;

    private float contador = 0;
    private bool metaAlcanzada = false;

    void Start()
    {
        
        estrella1.SetActive(false);
        estrella2.SetActive(false);
        estrella3.SetActive(false);
    }

    void Update()
    {
        
        if (!metaAlcanzada)
        {
            contador += Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !metaAlcanzada)
        {
            metaAlcanzada = true;

            
            if (contador >= 0)
            {
                estrella1.SetActive(true);
            }
            else
            {
                estrella1.SetActive(false);
            }

            
            if (contador < 300)
            {
                estrella2.SetActive(true);
            }
            else
            {
                estrella2.SetActive(false);
            }

           
            if (contador < 180)
            {
                estrella3.SetActive(true);
            }
            else
            {
                estrella3.SetActive(false);
            }
        }
    }
}
