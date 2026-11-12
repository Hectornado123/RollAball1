using UnityEngine;

public class Enemigo2 : MonoBehaviour
{

    public float velocidad;

    void Update()
    {
        if (transform.position.x > 17.15)
        {
            velocidad = -velocidad;
        }
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
        if (transform.position.x < -8.5)
        {
            velocidad = -velocidad;
        }
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
    }
}
