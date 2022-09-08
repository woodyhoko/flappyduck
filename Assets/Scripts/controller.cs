using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if(Input.GetKeyDown(KeyCode.A)){
        //     transform.Position(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
        // }
        if(Input.GetKeyDown(KeyCode.Space)){
            // transform.position = transform.position + new Vector3(0, 1.5f, 0);
            m_Rigidbody.velocity = new Vector3(0,5.0f,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position = transform.position + new Vector3(-0.08f, 0 ,0);    
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position = transform.position + new Vector3(0.08f, 0 ,0);    
        }
    }
}
