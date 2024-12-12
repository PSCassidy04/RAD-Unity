using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform character;

    float xRotation;
    float yRotation;
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        distance = Vector3.Distance(transform.position, character.position);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(transform.right, Input.GetAxis("Vertical"));
        transform.RotateAround( character.transform.position,Vector3.up, Input.GetAxis("Horizontal"));

        transform.position = character.position - transform.forward * distance;
        //float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        //float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        //yRotation += mouseX;

        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        //orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
