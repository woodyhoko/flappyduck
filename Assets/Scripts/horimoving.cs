using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horimoving : MonoBehaviour
{
    public bool clone = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -20){
            Destroy(gameObject);
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("horingmovingTouched");
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("get hit by moving pipes");
            
            FindObjectOfType<GameManager>().EndGame();
        }
        // Destroy(gameObject);

    }
}
