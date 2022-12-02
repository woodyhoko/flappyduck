using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feather : MonoBehaviour
{
    // Start is called before the first frame update
    public float feather_chance;
    public GameObject f;
    public float speed = -21f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Random.Range(0, 1f) < feather_chance)
        {
            GameObject food;
            food = Instantiate(f);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0,speed);
        }
    }
}
