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
                die.GetComponent<TMPro.TextMeshProUGUI>().text = "Be careful of silver traps!";
            }
            else if (ScoreManager.killedByBound) {
                die.GetComponent<TMPro.TextMeshProUGUI>().text = "Die from falling! ";
            }
            else if (ScoreManager.killedByCeil) {
                die.GetComponent<TMPro.TextMeshProUGUI>().text = "Weird gravity is dangerous..";
            }
            else if (ScoreManager.killedByRock) {
                die.GetComponent<TMPro.TextMeshProUGUI>().text = "Killed by falling rocks!";
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
        if (Input.GetKeyUp(KeyCode.Space)){
            ScoreManager.sscore = 0;
            ScoreManager.startTime = Time.time;
            SceneManager.LoadScene("tutorial");
        }
        else if (Input.anyKeyDown){
            ScoreManager.sscore = 0;
            ScoreManager.startTime = Time.time;
            SceneManager.LoadScene("demo2");
        }
    }
}
