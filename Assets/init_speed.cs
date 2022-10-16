using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init_speed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
