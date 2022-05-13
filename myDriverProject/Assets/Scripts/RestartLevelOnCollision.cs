using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //added

public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag; //initialized string tag variable
    

    private void OnCollisionEnter(Collision collision) //added collision function
    {
        //If the tag is 'Player', then restart level if collides with the respawn plane
        if(collision.collider.tag == strTag)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }
}
