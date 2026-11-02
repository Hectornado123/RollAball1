using UnityEngine;

public class Ascensor : MonoBehaviour
{

    float velocidad = 3;
  

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 20.35)
        {
            velocidad = -velocidad;
        }
        transform.Translate(0, velocidad * Time.deltaTime, 0);
        if (transform.position.y < -1.87)
        {
            velocidad = -velocidad;
        }
        transform.Translate(0, velocidad * Time.deltaTime, 0);
    }
}
