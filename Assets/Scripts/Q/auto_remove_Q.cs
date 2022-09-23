using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_remove_Q : MonoBehaviour
{
    // Start is called before the first frame update
    //public TMPro.TextMeshProUGUI score_text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -20){
            //ScoreManager.sscore++;
            //score_text.text = "Score : " + ScoreManager.sscore.ToString();
            Destroy(gameObject);
        }
    }
}
