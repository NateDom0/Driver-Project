using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public GameObject player; //keep as public or else it'll break camera
    private Vector3 offset = new Vector3(0, 5, -15); //create new variable called 'offset'
    //make private, only used within this class

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //changed from Update() to LateUpdate()
    {
        //transform.position = player.transform.position;
        //camera's position will be set to players position

        //offset the camera behind the player by adding to the player's position
        //transform.position = player.transform.position + new Vector3(0, 5, -7);
        //transform.position = player.transform.position + new Vector3(0, 5, -15);
        transform.position = player.transform.position + offset; //call variable 'offset'

    }
}
