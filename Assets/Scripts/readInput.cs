using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readInput : MonoBehaviour
{
    private string input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void readStringInput(string name)
    {
        input = name;
        ScoreManager.username = name;
        Debug.Log(ScoreManager.username);
    }
}
