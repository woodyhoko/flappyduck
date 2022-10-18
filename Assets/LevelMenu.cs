using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void level10()
    {
        Debug.Log("Level10");
        SceneManager.LoadScene("level1smaller");
        ScoreManager.level1 = true;
        ScoreManager.startTime = Time.time;
    }

    public void level11()
    {
        // Debug.Log("Level11");
        SceneManager.LoadScene("level1smaller");
        ScoreManager.level1 = true;
        ScoreManager.startTime = Time.time;
    }

    public void level20()
    {
        SceneManager.LoadScene("Level_2_0");
        ScoreManager.level1 = false;
        ScoreManager.startTime = Time.time;
    }

    public void level21()
    {
        SceneManager.LoadScene("Level_2_1");
        ScoreManager.level1 = false;
        ScoreManager.startTime = Time.time;
    }

    public void level22()
    {
        SceneManager.LoadScene("Level_2_2");
        ScoreManager.level1 = false;
        ScoreManager.startTime = Time.time;
    }

    public void level23()
    {
        SceneManager.LoadScene("Level1");
    }

    public void level30()
    {
        SceneManager.LoadScene("Level_3_0");
        ScoreManager.level1 = false;
        ScoreManager.startTime = Time.time;
    }

    public void level31()
    {
        SceneManager.LoadScene("Level_3_1");
        ScoreManager.level1 = false;
        ScoreManager.startTime = Time.time;
    }

    public void level32()
    {
        SceneManager.LoadScene("Level1");
    }

    public void level_endless()
    {
        Debug.Log("Endless Run");
        SceneManager.LoadScene("demo2");
        ScoreManager.level1 = false;
        ScoreManager.startTime = Time.time;
    }

    public void QuitMenu()
    {
        Debug.Log("QuitMenu");
        SceneManager.LoadScene("gameover");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void GoTutorial()
    {
        SceneManager.LoadScene("tutorial");
    }

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
