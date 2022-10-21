using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class canvas2 : MonoBehaviour
{
    public GameObject c; // canvas
    public TMP_Text text;
    // Start is called before the first frame update
    private int line = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space))
         { 
            line++;
         }
        switch (line)
        {
            case 0:
                text.text = "avoid obstacles!";
                break;
            case 1:
                c.SetActive(false);
                Time.timeScale = 1f;
                line++;
                break;
            case 2:
                text.text = "avoid falling rocks!";
                break;
            case 3:
                c.SetActive(false);
                Time.timeScale = 1f;
                line++;
                break;
            case 4:
                text.text = "Eat the power cube : Invisible";
                break;
            case 5:
                c.SetActive(false);
                Time.timeScale = 1f;
                line++;
                break;
            case 6:
                text.text = "you will meet different cubes in following levels";
                break;
            case 7:
                text.text = " In endless mode : You can only eat limited number of power cubes";
                break;
            case 8:
                SceneManager.LoadScene("gameover");
                break;
        }
    }
    
}
