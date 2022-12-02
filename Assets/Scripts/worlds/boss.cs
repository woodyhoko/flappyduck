using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boss : MonoBehaviour
{

    public GameObject Canvas;
    public TMP_Text title;

    //public TMPro.TextMeshProUGUI score_text;
    HealthSystem healthSystem;
    public float maxHealth = 400f;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(6, 10, true);
        Physics.IgnoreLayerCollision(6, 6, true);
        healthSystem = new(maxHealth);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            //Debug.Log("get hit by bullet");
            healthSystem.Damage(collision.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
            //pipeHealth.TakeDamage(collision.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
            if (healthSystem.GetHealth().Equals(0f))
            {
                Destroy(collision.gameObject);
            }


        }
    }

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "bullet")
        {
            //Debug.Log("get hit by bullet");
            if (gameObject != null && collider.gameObject != null && healthSystem != null)
            {
                healthSystem.Damage(50f);
                //Debug.Log(healthSystem.GetHealth());
                gameObject.GetComponent<Renderer>().material.color = new Color(Mathf.Clamp(healthSystem.GetHealthPercentage(), 0, 1), Mathf.Clamp(1-healthSystem.GetHealthPercentage(), 0, 1), 0, 0.5f);
                if (healthSystem.GetHealth().Equals(0f))
                {
                    Destroy(collider.gameObject);
                    Destroy(gameObject);
                    level_pass();
                }
            }
        }
    }
    private void level_pass()
    {
        Time.timeScale = 0;
        Canvas.SetActive(true);
        title.text = "level pass";
        //replay.SetActive(true);
        //next_level.SetActive(false);
    }
}
