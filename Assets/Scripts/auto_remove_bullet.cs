using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_remove_bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float bullet_damage = 50;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.z > 50)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        //if (collider.gameObject.tag == "water")
        //{
        //    Destroy(gameObject);
        //}
        if (collider.gameObject.tag == "impenetrable_water")
        {
            Destroy(gameObject);
        }
    }
}
