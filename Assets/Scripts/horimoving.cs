using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horimoving : MonoBehaviour
{

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("horizontal wall touched");
        if(collision.gameObject.tag == "Player")
        {
            // ScoreManager.killedByWater= true;
            FindObjectOfType<GameManager>().EndGame();
        }
        // Destroy(gameObject);

    }
    
}
