using System;
using UnityEngine;

public class Salto : MonoBehaviour
{
    
    private Rigidbody rb;               
    public float speed;                
    public float jumpForce;
    public GameManager gameManager;
    public Vector3 respawnPoint;       
    public float fallLimit;             

    private bool tocandoSuelo;



  
    void Start()
    {

        gameManager = GetComponent<GameManager>();
        rb = GetComponent<Rigidbody>();            
        respawnPoint = transform.position;
    }

    
    private void Update()
    {
        Movement();
        if (transform.position.y < fallLimit)
        {
            Respawn();
        }
    }



    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            gameManager.points++;
            Destroy(other.gameObject);
        }
    }

    void Movement()
    {
        
        float inputHor = Input.GetAxis("Horizontal");
        float inputVer = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (tocandoSuelo)
            {
                jumpForce = 200;
            }
        }
        else { jumpForce = 0; }

     
        Vector3 movement = new Vector3(inputHor * speed, jumpForce, inputVer * speed);

      
        rb.AddForce(movement);
    }

    void Respawn()
    {
        rb.linearVelocity = Vector3.zero;      
        transform.position = respawnPoint;     
    }

    private void OnCollisionEnter(Collision collision)
    {
        tocandoSuelo = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        tocandoSuelo = false;
    }

}
