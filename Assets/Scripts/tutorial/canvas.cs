using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class canvas : MonoBehaviour
{
    public GameObject c; // canvas
    // Start is called before the first frame update
    private int line = -1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            c.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
