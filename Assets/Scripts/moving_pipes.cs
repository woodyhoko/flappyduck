using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_pipes : MonoBehaviour
{
    private Vector3 position;
    public float speedUpDown = 5;
    public float distanceUpDown = 1;
     // public GameObject healthBarUI;
    // public Canvas Canvas;
    //pipeHealth pipeHealth = new pipeHealth();
    public TMPro.TextMeshProUGUI score_text;
    HealthSystem healthSystem;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(6, 10, true);
        Physics.IgnoreLayerCollision(6, 6, true);
        healthSystem= new(400f);
        // healthBarUI = (GameObject)Instantiate(healthBarUI);
    }
    
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "bullet")
        {
            //Debug.Log("get hit by bullet");
             healthSystem.Damage(collision.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
            //pipeHealth.TakeDamage(collision.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
            if (healthSystem.GetHealth().Equals(0f))
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
        if (collider.gameObject.tag == "bullet")
        {
            //Debug.Log("get hit by bullet");
            if (gameObject != null && collider.gameObject != null)
            {
                healthSystem.Damage(collider.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
                //pipeHealth.TakeDamage(collision.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
                Debug.Log(healthSystem.GetHealth());
                gameObject.GetComponent<Renderer>().material.color = new Color(Mathf.Clamp(1 - healthSystem.GetHealthPercentage(), 0, 1), Mathf.Clamp(healthSystem.GetHealthPercentage(), 0, 1), 0, 0.5f);

                if (healthSystem.GetHealth().Equals(0f))
                {
                    Destroy(collider.gameObject);
                    Destroy(gameObject);
                }
                // Destroy(gameObject);
            }
        }
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject != null)
        {
            Vector3 mov = new Vector3(gameObject.transform.position.x,
                Mathf.Sin(speedUpDown * Time.time) * distanceUpDown, gameObject.transform.position.z);
            gameObject.transform.position = mov;
        }
        //Debug.Log(position);
    }
}
