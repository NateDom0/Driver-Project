using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 15.0f;
    private float rotationSpeed = 90.0f;
    private float verticalInput;

    //allows player to turn plane left/right
    //private float horizontalInput;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate() //changed from FixedUpdate to Update
    {
        // get the user's vertical input (up and down)
        verticalInput = Input.GetAxis("Vertical");

        // get user's horizontal input (left and right)
        //horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * verticalInput);

        // turns plane left and right using left/right keys
        //transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);

    }
}
