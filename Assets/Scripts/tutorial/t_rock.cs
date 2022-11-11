using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t_rock : MonoBehaviour
{
    // Rigidbody rb;

    public GameObject rock_shadow;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Instantiate(rock_shadow);
        // obj.transform.SetParent(this.transform);
        obj.transform.position = transform.position + new Vector3(0, -transform.position.y + 0.001f, 0);
        obj.GetComponent<rockShadow>().clone = true;
    }


    void Update()
    {

    }

}
