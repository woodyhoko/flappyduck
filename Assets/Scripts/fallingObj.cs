using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingObj : MonoBehaviour
{
    public Rigidbody rb;
    // public Collider col;
    float distToGround = 0.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // col = GetComponent<Collider>();
    }

    void Update()
    {
        if(rb.transform.position.z < 0.1f) {
            rb.useGravity = true;
        }
        if (isGrounded()) {
            Destroy(gameObject);
        }
    }

    bool isGrounded()
    {
        return Physics.Raycast(rb.transform.position, Vector3.down, distToGround);
    }
}
