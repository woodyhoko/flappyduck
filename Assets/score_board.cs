using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score_board : MonoBehaviour
{
    public GameObject score;
    public GameObject die;
    public GameObject textt;
    public GameObject heading;

    // Start is called before the first frame update
    void Start()
    {
        bool died = (ScoreManager.killedByWater || ScoreManager.killedByBound || ScoreManager.killedByCeil || ScoreManager.killedByRock);
        if (died) {
            score.SetActive(true);
            die.SetActive(true);
            heading.SetActive(true);
            textt.SetActive(false);

            score.GetComponent<TMPro.TextMeshProUGUI>().text = "Score : " + ScoreManager.sscore.ToString();
            if (ScoreManager.killedByWater) {
                die.GetComponent<TMPro.TextMeshProUGUI>().text = "Game Over! Be careful of silver traps!";
            }
            else if (ScoreManager.killedByBound) {
                die.GetComponent<TMPro.TextMeshProUGUI>().text = "Game Over! Watch out you fell of the platform!";
            }
            else if (ScoreManager.killedByCeil) {
                die.GetComponent<TMPro.TextMeshProUGUI>().text = "Game Over! Weird gravity is dangerous. Dont jump too High! ";
            }
            else if (ScoreManager.killedByRock) {
                die.GetComponent<TMPro.TextMeshProUGUI>().text = "Game Over! Avoid Rocks !";
            }
        } else {
            score.SetActive(false);
            die.SetActive(false);
            heading.SetActive(false);
            textt.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.anyKeyDown);
        if (Input.GetKeyDown(KeyCode.Space)){
            ScoreManager.sscore = 0;
            ScoreManager.startTime = Time.time;
            SceneManager.LoadScene("tutorial");
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            ScoreManager.sscore = 0;
            ScoreManager.startTime = Time.time;
            SceneManager.LoadScene("menu");
        }
    }
}
