using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{

    public TMPro.TextMeshProUGUI score_text;
    public GameObject cube;
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        //controller_Q.have_power = true;

        cube.transform.position = new Vector3(cube.transform.position.x, cube.transform.position.y, cube.transform.position.z + 0.9f);


        //ScoreManager.sscore += 2;
        //score_text.text = "Score : " + ScoreManager.sscore.ToString();


    }

}
