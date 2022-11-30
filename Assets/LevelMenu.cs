using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{

    private void initLevel()
    {
        ScoreManager.level10 = false;
        ScoreManager.level11 = false;
        ScoreManager.level12 = false;
        ScoreManager.level13 = false;
        ScoreManager.level20 = false;
        ScoreManager.level21 = false;
        ScoreManager.level22 = false;
        ScoreManager.level23 = false;
        ScoreManager.level24 = false;
        ScoreManager.level25 = false;
        ScoreManager.level30 = false;
        ScoreManager.level31 = false;
        ScoreManager.level32 = false;
        ScoreManager.level33 = false;
        ScoreManager.level34 = false;
        ScoreManager.level40 = false;
        ScoreManager.level41 = false;
        ScoreManager.level42 = false;
        ScoreManager.level43 = false;

        ScoreManager.startTime = Time.time;
        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;
        ScoreManager.tutorial = false;
        ScoreManager.biggerCube = 0;
        ScoreManager.smallerCube = 0;
        ScoreManager.shooter = 0;
        ScoreManager.faster = 0;
        ScoreManager.longer = 0;
        ScoreManager.invisible = 0;
        ScoreManager.star_upgrade = 0;
    }

    public void level10()
    {
        Debug.Log("Level10");
        SceneManager.LoadScene("Level_1_0");
        initLevel();
        ScoreManager.level10 = true;
    }

    public void level11()
    {
        // Debug.Log("Level11");
        SceneManager.LoadScene("Level_1_1");
        initLevel();
        ScoreManager.level11 = true;
    }

    public void level12()
    {
        // Debug.Log("Level11");
        SceneManager.LoadScene("Level_1_mid_dy");
        initLevel();
        ScoreManager.level12 = true;
    }

    public void level13()
    {
        // Debug.Log("Level11");
        SceneManager.LoadScene("Level_1_3");
        initLevel();
        ScoreManager.level13 = true;
    }

    public void level20()
    {
        SceneManager.LoadScene("Level_2_0");
        initLevel();
        ScoreManager.level20 = true;
    }

    public void level21()
    {
        SceneManager.LoadScene("Level_2_1");
        initLevel();
        ScoreManager.level21 = true;
    }

    public void level22()
    {
        SceneManager.LoadScene("Level_2_mid");
        initLevel();
        ScoreManager.level22 = true;
    }

    public void level23()
    {
        SceneManager.LoadScene("Level_2_2");
        initLevel();
        ScoreManager.level23 = true;
    }

    public void level24()
    {
        SceneManager.LoadScene("Level_2_3");
        initLevel();
        ScoreManager.level24 = true;
    }

    public void level25()
    {
        SceneManager.LoadScene("Level_2_4");
        initLevel();
        ScoreManager.level25 = true;
    }

    public void level30()
    {
        SceneManager.LoadScene("Level_3_0");
        initLevel();
        ScoreManager.level30 = true;
    }

    public void level31()
    {
        SceneManager.LoadScene("Level_3_1");
        initLevel();
        ScoreManager.level31 = true;
    }

    public void level32()
    {
        SceneManager.LoadScene("Level_3_mid_dy");
        initLevel();
        ScoreManager.level32 = true;
    }

    public void level33()
    {
        SceneManager.LoadScene("Level_3_3");
        initLevel();
        ScoreManager.level33 = true;
    }

    public void level34()
    {
        SceneManager.LoadScene("Level_3_4");
        initLevel();
        ScoreManager.level34 = true;
    }

    public void level40()
    {
        SceneManager.LoadScene("Level_4_0");
        initLevel();
        ScoreManager.level40 = true;
    }

    public void level41()
    {
        SceneManager.LoadScene("Level_4_1");
        initLevel();
        ScoreManager.level41 = true;
    }

    public void level42()
    {
        SceneManager.LoadScene("Level_4_2");
        initLevel();
        ScoreManager.level42 = true;
    }

    public void level43()
    {
        SceneManager.LoadScene("Level_4_3");
        initLevel();
        ScoreManager.level43 = true;
    }

    public void level_endless()
    {
        Debug.Log("Endless Run");
        SceneManager.LoadScene("demo2");
        initLevel();
    }

    public void level_portal()
    {
        Debug.Log("Portal Run");
        SceneManager.LoadScene("portal");
        initLevel();
    }
    public void enter_namePage()
    {
        ScoreManager.biggerCube = 0;
        ScoreManager.smallerCube = 0;
        ScoreManager.shooter = 0;
        ScoreManager.faster = 0;
        ScoreManager.longer = 0;
        ScoreManager.invisible = 0;
        ScoreManager.star_upgrade = 0;
        ScoreManager.sscore = 0;
        Time.timeScale = 1;
        ScoreManager.startTime = Time.time;
        GlobalData.Instance.destroy();
        SceneManager.LoadScene("inputUserName");
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
        Debug.Log("tutorialhere");
        SceneManager.LoadScene("tutorial");
        ScoreManager.startTime = Time.time;

        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;

        initLevel();
        ScoreManager.tutorial = true;


    }

    public void leaderBoard()
    {
        SceneManager.LoadScene("leaderboard");
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
