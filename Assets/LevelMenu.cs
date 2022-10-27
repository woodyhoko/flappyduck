using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void level10()
    {
        Debug.Log("Level10");
        SceneManager.LoadScene("Level_1_0");
        ScoreManager.level1 = true;
		ScoreManager.level1Passed = false;
		ScoreManager.level20 = false;
		ScoreManager.level21 = false;
		ScoreManager.level22 = false;
		ScoreManager.level23 = false;
		ScoreManager.level24 = false;
		ScoreManager.level30 = false;
		ScoreManager.level31 = false;

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

    public void level11()
    {
        // Debug.Log("Level11");
        SceneManager.LoadScene("Level_1_0");
        ScoreManager.level1 = true;
		ScoreManager.level1Passed = false;
		ScoreManager.level20 = false;
		ScoreManager.level21 = false;
		ScoreManager.level22 = false;
		ScoreManager.level23 = false;
		ScoreManager.level24 = false;
		ScoreManager.level30 = false;
		ScoreManager.level31 = false;
		ScoreManager.tutorial = false;
        ScoreManager.startTime = Time.time;
        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;
		ScoreManager.biggerCube = 0;
		ScoreManager.smallerCube = 0;
		ScoreManager.shooter = 0;
		ScoreManager.faster = 0;
		ScoreManager.longer = 0;
		ScoreManager.invisible = 0;
		ScoreManager.star_upgrade = 0;
    }

    public void level20()
    {
        SceneManager.LoadScene("Level_2_0");
        ScoreManager.level1 = false;
		ScoreManager.level20 = true;
		ScoreManager.level20Passed = false;
		ScoreManager.level21 = false;
		ScoreManager.level22 = false;
		ScoreManager.level23 = false;
		ScoreManager.level24 = false;
		ScoreManager.level30 = false;
		ScoreManager.level31 = false;
		ScoreManager.tutorial = false;
        ScoreManager.startTime = Time.time;
        
        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;

		ScoreManager.biggerCube = 0;
		ScoreManager.smallerCube = 0;
		ScoreManager.shooter = 0;
		ScoreManager.faster = 0;
		ScoreManager.longer = 0;
		ScoreManager.invisible = 0;
		ScoreManager.star_upgrade = 0;
    }

    public void level21()
    {
        SceneManager.LoadScene("Level_2_1");
        ScoreManager.level1 = false;
		ScoreManager.level20 = false;
		ScoreManager.level21 = true;
		ScoreManager.level21Passed = false;
		ScoreManager.level22 = false;
		ScoreManager.level23 = false;
		ScoreManager.level24 = false;
		ScoreManager.level30 = false;
		ScoreManager.level31 = false;
		ScoreManager.tutorial = false;
        ScoreManager.startTime = Time.time;
        
        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;

		ScoreManager.biggerCube = 0;
		ScoreManager.smallerCube = 0;
		ScoreManager.shooter = 0;
		ScoreManager.faster = 0;
		ScoreManager.longer = 0;
		ScoreManager.invisible = 0;
		ScoreManager.star_upgrade = 0;
    }

    public void level22()
    {
        SceneManager.LoadScene("Level_2_2");
        ScoreManager.level1 = false;
		ScoreManager.level20 = false;
		ScoreManager.level21 = false;
		ScoreManager.level22 = true;
		ScoreManager.level22Passed = false;
		ScoreManager.level23 = false;
		ScoreManager.level24 = false;
		ScoreManager.level30 = false;
		ScoreManager.level31 = false;
		ScoreManager.tutorial = false;
        ScoreManager.startTime = Time.time;
        
        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;

		ScoreManager.biggerCube = 0;
		ScoreManager.smallerCube = 0;
		ScoreManager.shooter = 0;
		ScoreManager.faster = 0;
		ScoreManager.longer = 0;
		ScoreManager.invisible = 0;
		ScoreManager.star_upgrade = 0;
    }
    
    public void level40()
    {
	    SceneManager.LoadScene("Level_4_0");
	    ScoreManager.level1 = false;
	    ScoreManager.level20 = false;
	    ScoreManager.level21 = false;
	    ScoreManager.level22 = false;
	    ScoreManager.level22Passed = false;
	    ScoreManager.level23 = false;
	    ScoreManager.level24 = false;
	    ScoreManager.level30 = false;
	    ScoreManager.level31 = false;
	    ScoreManager.tutorial = false;
	    ScoreManager.startTime = Time.time;
        
	    ScoreManager.killedByRock = false;
	    ScoreManager.killedByWater = false;
	    ScoreManager.killedByCeil = false;
	    ScoreManager.killedByBound = false;

	    ScoreManager.biggerCube = 0;
	    ScoreManager.smallerCube = 0;
	    ScoreManager.shooter = 0;
	    ScoreManager.faster = 0;
	    ScoreManager.longer = 0;
	    ScoreManager.invisible = 0;
	    ScoreManager.star_upgrade = 0;
    }

    public void level23()
    {
        SceneManager.LoadScene("Level_2_3");
        ScoreManager.level1 = false;
		ScoreManager.level20 = false;
		ScoreManager.level21 = false;
		ScoreManager.level22 = false;
		ScoreManager.level23 = true;
		ScoreManager.level23Passed = false;
		ScoreManager.level24 = false;
		ScoreManager.level30 = false;
		ScoreManager.level31 = false;
		ScoreManager.tutorial = false;
        ScoreManager.startTime = Time.time;

        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;

		ScoreManager.biggerCube = 0;
		ScoreManager.smallerCube = 0;
		ScoreManager.shooter = 0;
		ScoreManager.faster = 0;
		ScoreManager.longer = 0;
		ScoreManager.invisible = 0;
		ScoreManager.star_upgrade = 0;
    }

    public void level24()
    {
        SceneManager.LoadScene("Level_2_4");
        ScoreManager.level1 = false;
		ScoreManager.level20 = false;
		ScoreManager.level21 = false;
		ScoreManager.level22 = false;
		ScoreManager.level23 = false;
		ScoreManager.level24 = true;
		ScoreManager.level24Passed = false;
		ScoreManager.level30 = false;
		ScoreManager.level31 = false;
		ScoreManager.tutorial = false;
        ScoreManager.startTime = Time.time;

        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;

		ScoreManager.biggerCube = 0;
		ScoreManager.smallerCube = 0;
		ScoreManager.shooter = 0;
		ScoreManager.faster = 0;
		ScoreManager.longer = 0;
		ScoreManager.invisible = 0;
		ScoreManager.star_upgrade = 0;
    }

    public void level30()
    {
        SceneManager.LoadScene("Level_3_0");
        ScoreManager.level1 = false;
		ScoreManager.level20 = false;
		ScoreManager.level21 = false;
		ScoreManager.level22 = false;
		ScoreManager.level23 = false;
		ScoreManager.level24 = false;
		ScoreManager.level30 = true;
		ScoreManager.level30Passed = false;
		ScoreManager.level31 = false;
		ScoreManager.tutorial = false;
        ScoreManager.startTime = Time.time;
        
        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;

		ScoreManager.biggerCube = 0;
		ScoreManager.smallerCube = 0;
		ScoreManager.shooter = 0;
		ScoreManager.faster = 0;
		ScoreManager.longer = 0;
		ScoreManager.invisible = 0;
		ScoreManager.star_upgrade = 0;
    }

    public void level31()
    {
        SceneManager.LoadScene("Level_3_1");
        ScoreManager.level1 = false;
		ScoreManager.level20 = false;
		ScoreManager.level21 = false;
		ScoreManager.level22 = false;
		ScoreManager.level23 = false;
		ScoreManager.level24 = false;
		ScoreManager.level30 = false;
		ScoreManager.level31 = true;
		ScoreManager.level31Passed = false;
		ScoreManager.tutorial = false;
        ScoreManager.startTime = Time.time;
        
        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;

		ScoreManager.biggerCube = 0;
		ScoreManager.smallerCube = 0;
		ScoreManager.shooter = 0;
		ScoreManager.faster = 0;
		ScoreManager.longer = 0;
		ScoreManager.invisible = 0;
		ScoreManager.star_upgrade = 0;
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
		ScoreManager.level20 = false;
		ScoreManager.level21 = false;
		ScoreManager.level22 = false;
		ScoreManager.level23 = false;
		ScoreManager.level24 = false;
		ScoreManager.level30 = false;
		ScoreManager.level31 = false;
		ScoreManager.tutorial = false;
        ScoreManager.startTime = Time.time;
        
        ScoreManager.killedByRock = false;
        ScoreManager.killedByWater = false;
        ScoreManager.killedByCeil = false;
        ScoreManager.killedByBound = false;

		ScoreManager.biggerCube = 0;
		ScoreManager.smallerCube = 0;
		ScoreManager.shooter = 0;
		ScoreManager.faster = 0;
		ScoreManager.longer = 0;
		ScoreManager.invisible = 0;
		ScoreManager.star_upgrade = 0;
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
        
        ScoreManager.level1 = false;
        ScoreManager.level20 = false;
        ScoreManager.level21 = false;
        ScoreManager.level22 = false;
        ScoreManager.level23 = false;
        ScoreManager.level24 = false;
        ScoreManager.level30 = false;
        ScoreManager.level31 = false;
		ScoreManager.tutorial = true;
        
        
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
