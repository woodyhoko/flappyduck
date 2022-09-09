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
        if(transform.position.z < -20){
            score_text.text = (int.Parse(score_text.text) + 1).ToString();
            Destroy(gameObject);
        }
    }
}
