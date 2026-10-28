using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform bola;
    public Vector3 distancia = new Vector3(0, 5, -8);
    //public float suavizado = 5f;

    void LateUpdate()
    {

        Vector3 posicionObjetivo = bola.position + distancia;

        transform.position = posicionObjetivo;

      
    }
}