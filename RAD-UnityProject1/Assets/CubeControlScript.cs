using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    Rigidbody rb;
    float jumpForce = 5;
    float explosionRadius = 5;
    float explosionStrength = 1000;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jumpForce*Vector3.up, ForceMode.Impulse);
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        //VictimScript victimScript = collision.gameObject.GetComponent<VictimScript>();

        Collider[] allVictims = Physics.OverlapSphere(transform.position + Vector3.down, explosionRadius);

        foreach (Collider collider in allVictims)
        {
            VictimScript newVictim = collider.gameObject.GetComponent<VictimScript>();



            if (newVictim != null)
            {
                newVictim.bump(explosionStrength, transform.position + Vector3.down, explosionRadius);
            }
        }

        //if (collision.gameobject.name == "victim")
        //{
        //    rigidbody victimrb = collision.gameobject.getcomponent<rigidbody>();
        //    if (victimrb != null)
        //    {
        //    victimrb.addexplosionforce(1000, transform.position + vector3.down, 5);
        //        print("kaboom");
        //   }
        //}     


    }


}
