using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin_Rotation : MonoBehaviour
{
    // Start is called before the first frame update

    public float X_Rotation = 0f;
    public float Z_Rotation = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x + X_Rotation, this.transform.eulerAngles.y, this.transform.eulerAngles.z + Z_Rotation);
    }
}
