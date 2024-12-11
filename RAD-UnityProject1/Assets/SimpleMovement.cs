using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{

    Rigidbody playerBody;
    float jumpForce = 5;


    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.S))
            {
                playerBody.AddForce(Vector3.forward);
            }
            if (Input.GetKey(KeyCode.W))
            {
                playerBody.AddForce(Vector3.back);
            }
            if (Input.GetKey(KeyCode.D))
            {
                playerBody.AddForce(Vector3.left);
            }
            if (Input.GetKey(KeyCode.A))
            {
                playerBody.AddForce(Vector3.right);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerBody.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Collider collider = collision.collider;

        //if (Rigidbody != null)
        //{
        //      if (collider == getGameObject.Floor)
        //      FailReset.
        //}
    }

}
