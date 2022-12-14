using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class t_pipe : MonoBehaviour
{
    public TMPro.TextMeshProUGUI score_text;
    HealthSystem healthSystem;
    public float maxHealth = 400f;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(6, 10, true);
        Physics.IgnoreLayerCollision(6, 6, true);
        healthSystem= new(maxHealth);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // healthBar.transform.SetParent(Canvas.transform);
        // healthBar.transform.position = this.transform.position + new Vector3(0,1.2f,0);
    }

    //public void SetHealth(float max_health){
     //   pipeHealth.init(max_health);
   // }

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


        }
    }

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "bullet")
        {
            //Debug.Log("get hit by bullet");
            if (gameObject != null && collider.gameObject != null&& healthSystem!=null)
            {
                //healthSystem.Damage(collider.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
                healthSystem.Damage(1);
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
        if (collider.gameObject.tag == "Player")
        {
            GlobalData.Instance.hearts[GlobalData.Instance.cube_health].SetActive(false);

            if (GlobalData.Instance.cube_health <= 0f)
            {
                ScoreManager.killedByWater = true;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByBound = false;
                FindObjectOfType<GameManager>().EndGame();
            }
            Debug.Log("get hit by pipe");
        }
    }
}
