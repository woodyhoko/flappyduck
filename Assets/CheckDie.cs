using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CheckDie : MonoBehaviour
{
    public bool islevel = true;
    public GameObject Canvas;
    public TMP_Text title;
    public GameObject replay;
    public GameObject next_level;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10 || transform.position.z < -10 || transform.position.x < -6 || transform.position.x > 6) {
            if (this.tag == "Player")
            {
                if(islevel)
                {
				    ScoreManager.killedByBound = true;
				    ScoreManager.killedByCeil = false;
				    ScoreManager.killedByWater = false;
                    level_game_over();
                }
                else
                {
                    ScoreManager.killedByBound = true;
				    ScoreManager.killedByCeil = false;
				    ScoreManager.killedByWater = false;
                    FindObjectOfType<GameManager>().EndGame();
                }
            }
            else
            {
                Destroy(this);
            }

            
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "ceil" || collider.gameObject.tag == "water"){
            if (this.tag == "Player")
            {
                if (islevel) {
				    if (collider.gameObject.tag == "ceil") {
					    ScoreManager.killedByCeil = true;
					    ScoreManager.killedByWater = false;
					    ScoreManager.killedByBound = false;
					    Debug.Log("ceil");
				    } else {
					    ScoreManager.killedByWater = true;
					    ScoreManager.killedByCeil = false;
					    ScoreManager.killedByBound = false;
					    Debug.Log("water");
				    }
                    level_game_over();
                } else {
                    ScoreManager.killedByCeil = true;
				    ScoreManager.killedByWater = false;
				    ScoreManager.killedByBound = false;
                    FindObjectOfType<GameManager>().EndGame();
                }
            }
            else
            {
                Destroy(this);
            }
                
        }
    }

    private void level_game_over()
    {
        Time.timeScale = 0;
        Canvas.SetActive(true);
        title.text = "Game Over";
        replay.SetActive(true);
        next_level.SetActive(false);
    }
}
