using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_up_down_obstacle : MonoBehaviour
{
    public float ceilling = 4.0f;
    public float displacement = 0.01f;
    public float bottom = -2.0f;
    private float sign = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y_displacement = (this.transform.position.y + displacement * sign);
        if (y_displacement >= ceilling || y_displacement <= bottom)
        {
            sign *= -1;
        }

        this.transform.position = new Vector3(this.transform.position.x, y_displacement, this.transform.position.z);

    }
}
