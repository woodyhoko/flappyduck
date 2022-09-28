using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reminder : MonoBehaviour
{
    // Rigidbody rb;
    public bool clone = false;

    // Start is called before the first frame update
    void Start()
    {
        if (clone){
            Invoke("DestroyFallingRock", 1f);
        }
        // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void DestroyFallingRock(){
        Destroy(gameObject);
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if(other.tag == "Rock") {
    //         Destroy(gameObject);
    //     }
    // }
}
