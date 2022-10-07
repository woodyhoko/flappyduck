using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score_board : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TMPro.TextMeshProUGUI>().text = "Score : " + ScoreManager.sscore.ToString();
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.anyKeyDown){
            ScoreManager.sscore = 0;
            ScoreManager.startTime = Time.time;
            SceneManager.LoadScene("demo2");
        }
    }
}
