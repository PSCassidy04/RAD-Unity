using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{

    Rigidbody playerBody;
    float jumpForce = 5;
    float explosionForce = 1000;
    float threshold = -10;


    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.W))
            {
                playerBody.AddForce(Vector3.back);
            }
            if (Input.GetKey(KeyCode.S))
            {
                playerBody.AddForce(Vector3.forward);
            }
            if (Input.GetKey(KeyCode.A))
            {
                playerBody.AddForce(Vector3.right);
            }
            if (Input.GetKey(KeyCode.D))
            {
                playerBody.AddForce(Vector3.left);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerBody.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            }

        if (transform.position.y < threshold) 
        {
            transform.position = new Vector3();
        }
            
    }

    public void OnCollisionEnter(Collision collision)
    {
            BounceScript BounceScript = collision.gameObject.GetComponent<BounceScript>();

            if (collision.gameObject.name == "BouncePlatform")
            {
            Rigidbody BouncePlatformrb = collision.gameObject.GetComponent<Rigidbody>();
                if (BouncePlatformrb != null)
                {
                    BouncePlatformrb.AddExplosionForce(explosionForce, transform.position + Vector3.up, 5);
                }
            }    
    }

}
