using UnityEngine;
using UnityEngine.SceneManagement;

public class trigermeta : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("meta"))
        {
            SceneManager.LoadScene("nivel 2");
        }
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
