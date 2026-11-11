using UnityEngine;

public class Enemigo2 : MonoBehaviour
{

    public float velocidad;

    void Update()
    {
        if (transform.position.x > 31.7)
        {
            velocidad = -velocidad;
        }
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
        if (transform.position.x < 10)
        {
            velocidad = -velocidad;
        }
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
    }
}
