using UnityEngine;

public class movimientoplataforma : MonoBehaviour
{
    public float velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 20 )
        {
            velocidad = -velocidad;
        }
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
        if (transform.position.x < -20)
        {
            velocidad = -velocidad;
        }
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
    }   
}
