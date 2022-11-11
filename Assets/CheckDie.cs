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
        if(collider.gameObject.tag == "ceil" ||collider.gameObject.tag == "pipe"){
            if (this.tag == "Player")
            {
                if (collider.gameObject.tag == "pipe")
                {
                    GlobalData.Instance.cube_health -= 1;
                    int hp = GlobalData.Instance.cube_health;
                    if (hp >= 0)
                        GlobalData.Instance.hearts[hp].SetActive(false);
                    if (hp <= 0f)
                    {
                        ScoreManager.killedByWater = true;
                        ScoreManager.killedByCeil = false;
                        ScoreManager.killedByBound = false;
                        if (islevel)
                            level_game_over();
                        else
                            FindObjectOfType<GameManager>().EndGame();
                    }
                }
                else if (collider.gameObject.tag == "ceil")
                {
                    ScoreManager.killedByCeil = true;
                    ScoreManager.killedByWater = false;
                    ScoreManager.killedByBound = false;
                    Debug.Log("ceil");
                    if (islevel)
                        level_game_over();
                    else
                        FindObjectOfType<GameManager>().EndGame();
                }
            }
            else
            {
                int size = GlobalData.Instance.cloned_list.Count;

                for (int i = 0; i < size; i++)
                {
                    if (GlobalData.Instance.cloned_list[i] == this)
                    {
                        GlobalData.Instance.cloned_list.RemoveAt(i);
                    }
                }
                Destroy(this);
            }
                
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "water" && this.tag == "Player")
        {
            GlobalData.Instance.cube_health -= 1;
            GlobalData.Instance.hearts[GlobalData.Instance.cube_health].SetActive(false);
            if (GlobalData.Instance.cube_health <= 0f)
            {
               
                ScoreManager.killedByWater = true;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByBound = false;
                if(islevel)
                {
                    level_game_over();
                }
                else
                    FindObjectOfType<GameManager>().EndGame();
            }
            Destroy(collision.gameObject);
            Debug.Log("get hit by water");
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
