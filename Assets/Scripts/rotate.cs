using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(player.transform.position, Vector3.up, 50 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collider)
    {
       // if (collider.gameObject.tag == "pipe")
        //{
            //Destroy(collider.gameObject); ScoreManager.sscore++;
        //}
    }
}
