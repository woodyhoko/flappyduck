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

        //cube.transform.position = new Vector3(cube.transform.position.x, cube.transform.position.y, cube.transform.position.z + 0.9f);
        //controller_Q.m_Rigidbody.velocity = new Vector3(0, 0, controller_Q.m_Rigidbody.velocity.z + 2.0f);
        controller.move_forward = true;
        controller_Q.move_forward = true;
        

        //ScoreManager.sscore += 2;
        //score_text.text = "Score : " + ScoreManager.sscore.ToString();


    }

}
