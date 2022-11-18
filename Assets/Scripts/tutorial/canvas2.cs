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
                text.text = "Touch the pipes and walls will lose your health!!!";
                break;
            case 1:
                c.SetActive(false);
                Time.timeScale = 1f;
                line++;
                break;
            case 2:
                text.text = "Avoid the silver traps!!!";
                break;
            case 3:
                c.SetActive(false);
                Time.timeScale = 1f;
                line++;
                break;
            case 4:
                text.text = "Falling rocks will make you dizzy. Avoid it!";
                break;
            case 5:
                c.SetActive(false);
                Time.timeScale = 1f;
                line++;
                break;
            case 6:
                text.text = "Certain enemies will shoot at you!";
                break;
            case 7:
                c.SetActive(false);
                Time.timeScale = 1f;
                line++;
                break;
            case 8:
                text.text = "Certain enemies will chase at you!";
                break;
            case 9:
                c.SetActive(false);
                Time.timeScale = 1f;
                line++;
                break;
            case 10:
                text.text = "Eat the power cube : Invisible !!! ";
                break;
            case 11:
                c.SetActive(false);
                Time.timeScale = 1f;
                line++;
                break;
            case 12:
                text.text = "You will meet different upgrade cubes in following levels";
                break;
            case 13:
                text.text = " In endless mode : You can only eat limited number of power cubes";
                break;
            case 14:
                SceneManager.LoadScene("gameover");
                break;
        }
    }
    
}
