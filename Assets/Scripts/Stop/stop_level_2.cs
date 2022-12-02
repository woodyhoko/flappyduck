using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop_level_2 : MonoBehaviour
{
    // Start is called before the first frame update
    bool isStopped = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if (!isStopped)
        {
            Time.timeScale = 0;
            isStopped = true;
        }

    }
}
