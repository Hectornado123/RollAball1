using UnityEngine;

public class trigerpuente : MonoBehaviour
{
    public GameObject puente;
    private void OnTriggerEnter(Collider other)
    {
        puente.SetActive(true);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
