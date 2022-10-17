using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void level1()
    {
        Debug.Log("Level1");
        SceneManager.LoadScene("level1smaller");
    }

    public void level2()
    {
        Debug.Log("Level2");
        SceneManager.LoadScene("Level2");
    }

    public void level3()
    {
        Debug.Log("Level3");
        SceneManager.LoadScene("Level_3_0");
    }

    public void level4()
    {
        Debug.Log("Level4");
        SceneManager.LoadScene("Level4");
    }

    public void level5()
    {
        Debug.Log("Level5");
        SceneManager.LoadScene("Level5");
    }

    public void level_endless()
    {
        Debug.Log("Endless Run");
        SceneManager.LoadScene("demo2");
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
