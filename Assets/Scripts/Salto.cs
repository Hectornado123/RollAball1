using System;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class Salto : MonoBehaviour
{
    
    private Rigidbody rb;
    public GameObject Puerta1;
    public float speed;                
    public float jumpForce;
    public GameManager gameManager;
    public Vector3 respawnPoint;       
    public float fallLimit;
    float maxSpeed = 10;
    private bool tocandoSuelo;



  
    void Start()
    {
        Puerta1.SetActive(true);
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
        LimitarVelocidad();
    }


    
        


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            gameManager.points++;
           
            Destroy(other.gameObject);

        }
        if (other.gameObject.CompareTag("button"))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
            //GetComponent<Renderer>().material.color = new Color(255,0,0);
            Puerta1.SetActive(false);
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
                jumpForce = 400;
            }
        }
        else { jumpForce = 0; }

     
        Vector3 movement = new Vector3(inputHor * speed, jumpForce, inputVer * speed);

      
        rb.AddForce(movement);
    }

    void Respawn()
    {
       
        rb.angularVelocity = Vector3.zero;
        //rb.linearVelocity = Vector3.zero;      
        transform.position = respawnPoint;
        jumpForce = 300;    
    }

   private void OnCollisionEnter(Collision collision)
    {
        tocandoSuelo = true;

         if (collision.gameObject.CompareTag("enemy"))
        {
            Respawn();
        }
    }

    void LimitarVelocidad()
    {
        // Obtengo la velocidad horizontal de la bola
        Vector3 horizontal = new Vector3(
            rb.linearVelocity.x,
            0,
            rb.linearVelocity.z
        );

        // Limito su magnitud a maxSpeed
        horizontal = Vector3.ClampMagnitude(horizontal, maxSpeed);

        // Mantengo la velocidad vertical
        rb.linearVelocity = new Vector3(
            horizontal.x,
            rb.linearVelocity.y,
            horizontal.z
        );
    }
    private void OnCollisionExit(Collision collision)
    {
        tocandoSuelo = false;
    }

}
