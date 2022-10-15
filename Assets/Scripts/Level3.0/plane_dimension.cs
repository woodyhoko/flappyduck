using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_dimension : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 planeSize = GetComponent<Collider>().bounds.size;
        GlobalData.Instance.plane_width = planeSize.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
