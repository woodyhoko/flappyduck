using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public GameObject reminder;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // add a reminder
        if(other.tag == "Plane") {
            GameObject r = (GameObject)Instantiate (reminder);
            r.transform.rotation = Quaternion.identity;
            r.transform.position = new Vector3(rb.transform.position.x, 0.01f, rb.transform.position.z);
        }
    }

    // private void OnTriggerExit(Collider other)
    // {
    //     if(other.tag == "Plane") {
    //         Destroy(gameObject);
    //     }
    // }
}