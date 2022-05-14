using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnOnCollisionX : MonoBehaviour
{
    [SerializeField]
    string strTag; // initialize string tag variable

    private void OnCollisionEnter(Collision collision)
    {
        // if 'player' collides against object, it will restart the level
        if(collision.collider.tag == strTag)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
