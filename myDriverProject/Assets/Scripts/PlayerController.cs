using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//comment
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move vehicle forward
        //transform.Translate(0,0,1);
        transform.Translate(Vector3.forward);
        
    }
}