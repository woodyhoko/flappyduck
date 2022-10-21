using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_remove_boss : MonoBehaviour
{
    private int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time++;
        if(time>200)
            Destroy(gameObject);
    }
}
