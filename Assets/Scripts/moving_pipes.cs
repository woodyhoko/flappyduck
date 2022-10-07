using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_pipes : MonoBehaviour
{
    private Vector3 position;
    public GameObject obj;
    public float speedUpDown = 20;
    public float distanceUpDown = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 mov = new Vector3 (obj.transform.position.x, Mathf.Sin(speedUpDown * Time.time) * distanceUpDown, obj.transform.position.z);
        obj.transform.position = mov;
        //Debug.Log(position);
    }
}
