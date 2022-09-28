using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocksgenerator : MonoBehaviour
{
    public GameObject player;
    public GameObject fall;
    public GameObject rock;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float randomNumber = Random.Range(0, 1f);
        if (randomNumber < 0.005f){
            GameObject newrock = (GameObject)Instantiate (rock);
            newrock.GetComponent<Rock>().clone = true;
            newrock.transform.position = new Vector3(Random.Range(-5, 5f), 16, player.transform.position.z);

            // GameObject fall_obj = (GameObject)Instantiate (fall);
            // newrock.GetComponent<Fall>().clone = true;
            // fall_obj.transform.parent = newrock.transform;
        }
    }
}
