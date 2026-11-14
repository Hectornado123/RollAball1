using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;

    public float velocidad = 2f;

    private bool haciaB = true;

    void Update()
    {
        if (haciaB)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);

            if (transform.position.x >= puntoB.position.x)
            {
                haciaB = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);

            if (transform.position.x <= puntoA.position.x)
            {
                haciaB = true;
            }
        }
    }
}
