using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    // Rigidbody rb;
    public bool clone = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Touched");
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("get hit by water");
            Destroy(collision.gameObject);
            }
            // Destroy(gameObject);

        }
    
}