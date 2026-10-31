using UnityEngine;
using UnityEngine.SceneManagement;

public class TrigerMeta : MonoBehaviour
{

    public int points2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("finish"))
        {

            Debug.Log("tienes" + points2);
            //SceneManager.LoadScene("nivel 2");
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
