using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    //FINAL STEP: change all variables from public to private
    //variables
    
    //set speed from 5.0 to 17.0
    private float speed = 28.0f; 
    //need to add f at the end, letting computer know it's a float
    //add 'public' to float, so show in Unity
    //this is called initializing a variable

    //naming conventions for variables - lowercase for first letter, then capital
    private float turnSpeed = 75.0f; //changed to 'private', so set value
    
    //left & right
    private float horizontalInput; 
    
    //forward & backward
    //question - why not 'verticalInput'?
    private float forwardInput; 
                 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame (use deltaTime to update over time instead of every frame)
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //move vehicle forward
        //transform.Translate(0,0,1);

        //(0,0,1) x time.deltaTime x 20
        //try to avoid hard code numbers
        //transform.Translate(Vector3.forward * Time.deltaTime * 20); 
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //(reference UL-Lesson 1.4 - driver's seat)
        //Allow player control via input keys
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
        
        //move left & right, but doesn't rotate yet
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //use 'Rotate' method
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


    }
}
