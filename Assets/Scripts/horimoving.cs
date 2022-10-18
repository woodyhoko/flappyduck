using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class horimoving : MonoBehaviour
{
    
    public GameObject Canvas;
    public TMP_Text title;
    public GameObject replay;

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("horizontal wall touched");
        // if(collision.gameObject.tag == "Player")
        // {
        //     // ScoreManager.killedByWater= true;
        //     // FindObjectOfType<GameManager>().EndGame();
        //     Time.timeScale = 0;
        //     Canvas.SetActive(true);
        //     title.text = "Game Over";
        //     replay.SetActive(true);
        // }
        // Destroy(gameObject);

    }
    
}
