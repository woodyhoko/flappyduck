using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableFreshButton : MonoBehaviour
{
    public GameObject myButton; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void disable()
    {
        myButton.SetActive(false);
    }
}
