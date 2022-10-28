using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_remove_boss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x < -20|| transform.position.x > 20)
        {
            Destroy(gameObject);
        }
    }
}
