using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{

    public TMPro.TextMeshProUGUI score_text;
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        controller_Q.have_power = true;
        //ScoreManager.sscore += 2;
        //score_text.text = "Score : " + ScoreManager.sscore.ToString();


    }

}
