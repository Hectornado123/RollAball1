using UnityEngine;

public class enemigo : MonoBehaviour
{
    public float velocidad;
 

    void Update()
    {
        if (transform.position.x > 12)
        {
            velocidad = -velocidad;
        }
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
        if (transform.position.x < -3)
        {
            velocidad = -velocidad;
        }
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
    }
}
