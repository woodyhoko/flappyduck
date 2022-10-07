using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class canvas : MonoBehaviour
{
    public GameObject c; // canvas
    public GameObject p; // player
    public GameObject s; // star
    public TMP_Text text; public GameObject star;
    // Start is called before the first frame update
    private int line = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            line++;
        }
        switch (line)
        {
            case 0:
                text.text = "!";
                break;
            case 1:
                text.text = "wall!";
                break;
            case 2:
                s.SetActive(true);
                p.SetActive(false);
                text.text = "I will protect you!";
                break;
            case 3:
                text.text = "I will destroy the obstacles I touch";
                break;
            case 4:
                c.SetActive(false);
                Time.timeScale = 1f;
                star.SetActive(true);
                break;
        }
    }
}
