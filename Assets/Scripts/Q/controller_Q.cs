using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_Q : MonoBehaviour
{
    public static Rigidbody m_Rigidbody;
    public float height= 4.0f;
    float lastPressTime = 0.0f;
    public static bool have_power = false;

    bool larger_gravity = false;
    bool reversed_gravity = false;
    public static bool move_forward = false;
    public float forward_limit = 4.0f;

    public float ceilling = 4.0f;

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
            if (larger_gravity)
            {
                m_Rigidbody.velocity = new Vector3(0, 3.0f, 0);
            }
            else
            {
                m_Rigidbody.velocity = new Vector3(0,5.0f,0);
            }
            
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position = transform.position + new Vector3(-0.08f, 0 ,0);    
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position = transform.position + new Vector3(0.08f, 0 ,0);    
        }


        if (move_forward)
        {
            Debug.Log("z: " + transform.position.z);
            move_forward = !move_forward;
            if (transform.position.z < forward_limit)
            {
                m_Rigidbody.velocity = new Vector3(0, 0, m_Rigidbody.velocity.z + 2.0f);
            }
        }


        //add or cancel gravity
        if (Input.GetKey(KeyCode.W))
        {
            larger_gravity = !larger_gravity;
        }

        //reverse gravity
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (reversed_gravity)
            {
                Physics.gravity = new Vector3(0, 1.0f, 0);
            }
            else
            {
                Physics.gravity = new Vector3(0, -9.8f, 0);
            }

            reversed_gravity = !reversed_gravity;
        }
        //set celling on reversed gravity
        if (transform.position.y > 5.0f)
        {
            transform.position = new Vector3(transform.position.x, ceilling, transform.position.z);
        }



        //add Q
        if(Input.GetKey(KeyCode.Q))
        {
            //h = height / 2
            if (have_power)
            {
                have_power = false;
                transform.position = new Vector3(-transform.position.x, height - transform.position.y, transform.position.z);
                lastPressTime = Time.time;
            }
        }

    }
}
