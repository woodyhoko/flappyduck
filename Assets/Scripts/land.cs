using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class land : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.velocity = new Vector3(0,0,-15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
