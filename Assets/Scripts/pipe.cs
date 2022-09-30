using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pipe : MonoBehaviour
{
    // public GameObject healthBarUI;
    // public Canvas Canvas;
    pipeHealth pipeHealth = new pipeHealth();
    public TMPro.TextMeshProUGUI score_text;

    // Start is called before the first frame update
    void Start()
    {
        // HealthSystem = new(100f);
        // healthBarUI = (GameObject)Instantiate(healthBarUI);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // healthBar.transform.SetParent(Canvas.transform);
        // healthBar.transform.position = this.transform.position + new Vector3(0,1.2f,0);
    }

    public void SetHealth(float max_health){
        pipeHealth.init(max_health);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "bullet")
        {
            //Debug.Log("get hit by bullet");
            // healthSystem.Damage(20);
            pipeHealth.TakeDamage(collision.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
            //Debug.Log(healthSystem.GetHealth());
            if (!pipeHealth.CheckDie())
            {
                Destroy(collision.gameObject);
            }
            // Destroy(gameObject);

        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "star")
        {
            ScoreManager.sscore++;
            score_text.text = "Score : " + ScoreManager.sscore.ToString();
            Destroy(gameObject);
        }
    }
}
