using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_remove : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI score_text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -10){
            ScoreManager.sscore++;
            score_text.text = "Score : " + ScoreManager.sscore.ToString();
            Destroy(gameObject);
        }

        if (this.gameObject.tag == "cloned_cube" )
        {
            if (this.transform.position.y < -20)
            {
                Destroy(this.gameObject);
            }
        }
    }

    //private void OnTriggerEnter(Collider collider)
    //{
        //if (collider.gameObject.tag == "bullet")
        //{
          //  Destroy(collider.gameObject);
           // Destroy(gameObject);
       // }
   // }
}
