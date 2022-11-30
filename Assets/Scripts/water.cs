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
         Debug.Log("---------------water collision!!------------");
        if (collision.gameObject.tag == "Player")
         {
           GlobalData.Instance.cube_health -= 1;
           GlobalData.Instance.hearts[GlobalData.Instance.cube_health].SetActive(false);
             Destroy(gameObject);
         }

        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "cloned_cube")
        {
            Destroy(collider.gameObject);
        }

        //if (collider.gameObject.tag == "Player" && collider.gameObject.tag != "star")
        //{
        //   Debug.Log("---------------water triggger!!------------");
        //   GlobalData.Instance.cube_health -= 1;
        //   GlobalData.Instance.hearts[GlobalData.Instance.cube_health].SetActive(false);
        //  if (GlobalData.Instance.cube_health <= 0f)
        //  {
        //      ScoreManager.killedByWater = true;
        //      ScoreManager.killedByPipe = false;
        //      ScoreManager.killedByCeil = false;
        //      ScoreManager.killedByBound = false;
        //  }

        //  Destroy(this.gameObject);
        //  Debug.Log("get hit by water");
        // }
    }
}