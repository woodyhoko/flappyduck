using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    // Rigidbody rb;
    public bool clone = false;
    public TMPro.TextMeshProUGUI score_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("get hit by water");
            ScoreManager.killedByWater= true;
            ScoreManager.killedByCeil = false;
            ScoreManager.killedByBound = false;
            FindObjectOfType<GameManager>().EndGame();
            }
            // Destroy(gameObject);
        }
    
}