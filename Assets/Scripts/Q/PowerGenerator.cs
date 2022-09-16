using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerGenerator : MonoBehaviour
{
    public GameObject power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomNumber = Random.Range(0, 1f);
        if (randomNumber > 0.999f)
        {
            GameObject pp = (GameObject)Instantiate(power);
            //ppipe.transform.rotation = Quaternion.identity;
            pp.transform.position = new Vector3(Random.Range(-5, 5f), Random.Range(1, 3.5f), 36);
            Rigidbody m_Rigidbody = pp.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            
        }
    }
}
