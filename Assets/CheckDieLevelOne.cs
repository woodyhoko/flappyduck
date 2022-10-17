using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckDieLevelOne : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Canvas;
    public TMP_Text title;
    public GameObject replay;
    public GameObject next_level;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        

        if(transform.position.y < -10 || transform.position.z < -10 || transform.position.x < -6 || transform.position.x > 6) {
            ScoreManager.killedByBound = true;
            game_over();
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "ceil"){
            ScoreManager.killedByCeil = true;
            game_over();
        }
    }
    
    void game_over()
    {
        Time.timeScale = 0;
        Canvas.SetActive(true);
        title.text = "Game Over";
        replay.SetActive(true);
        next_level.SetActive(false);
    }
}
