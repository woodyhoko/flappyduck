using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10 || transform.position.z < -10 || transform.position.x < -6 || transform.position.x > 6) {
            ScoreManager.killedByBound = true;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "ceil"){
            ScoreManager.killedByCeil = true;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
