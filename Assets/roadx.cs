using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadx : MonoBehaviour
{
    // Start is called before the first frame update
    public float z_offset = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        z_offset -= 0.02f;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, z_offset);
    }
}
