using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water31 : MonoBehaviour
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
        Debug.Log("Touched");
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("get hit by water");
            CheckDie31.Instant.game_over();
            }
            // Destroy(gameObject);

        }
    
}