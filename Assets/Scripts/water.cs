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


        if (collision.gameObject.tag == "cloned_cube")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Player" && collision.gameObject.tag != "star")
        {
            //Debug.Log("---------------water triggger!!------------");
            GlobalData.Instance.cube_health -= 1;
            int hp = GlobalData.Instance.cube_health;
            if (hp > 0)
                GlobalData.Instance.hearts[hp].SetActive(false);
            if (hp <= 0f)
            {
                ScoreManager.killedByWater = false;
                ScoreManager.killedByPipe = true;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByBound = false;
            }
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "cloned_cube")
        {
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "Player" && collider.gameObject.tag != "star")
        {
           //Debug.Log("---------------water triggger!!------------");
           GlobalData.Instance.cube_health -= 1;
           int hp = GlobalData.Instance.cube_health;
           if (hp > 0)
               GlobalData.Instance.hearts[hp].SetActive(false);
           if (hp <= 0f)
           {
               ScoreManager.killedByWater = false;
               ScoreManager.killedByPipe = true;
               ScoreManager.killedByCeil = false;
               ScoreManager.killedByBound = false;
           }
           Destroy(this.gameObject);
         }
    }
}