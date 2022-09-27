using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ScoreManager.killedByRock = true;
            FindObjectOfType<GameManager>().EndGame();
        }
        else if(other.tag == "Plane") {
            Destroy(gameObject);
        }
    }
}
