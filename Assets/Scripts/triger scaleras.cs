using UnityEngine;

public class trigerscaleras : MonoBehaviour
{
    public GameObject escaleras;
    private void OnTriggerEnter(Collider other)
    {
        escaleras.SetActive(true);
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
