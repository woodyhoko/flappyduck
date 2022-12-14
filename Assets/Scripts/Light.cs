using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    // public GameObject healthBarUI;
    // public Canvas Canvas;
    //pipeHealth pipeHealth = new pipeHealth();
    HealthSystem healthSystem;
    public float maxHealth = 400f;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(6, 10, true);
        Physics.IgnoreLayerCollision(6, 6, true);
        healthSystem = new(maxHealth);
    }
    void Update()
    {
        if (transform.position.z < -5)
        {
            GlobalData.Instance.lightNum--;
            Destroy(gameObject);
        }
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
            healthSystem.Damage(50);
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
                //healthSystem.Damage(collider.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
                healthSystem.Damage(50);
                //pipeHealth.TakeDamage(collision.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
                //Debug.Log(healthSystem.GetHealth());
                gameObject.GetComponent<Renderer>().material.color = new Color(
                    Mathf.Clamp(1 - healthSystem.GetHealthPercentage(), 0, 1),
                    Mathf.Clamp(healthSystem.GetHealthPercentage(), 0, 1), 0, 0.5f);
                if (healthSystem.GetHealth().Equals(0f))
                {
                    Destroy(collider.gameObject);
                    Destroy(gameObject);
                }
                // Destroy(gameObject);
            }
        }

        if (collider.gameObject.tag == "Player" && collider.gameObject.tag != "star")
        {
            GlobalData.Instance.cube_health -= 1;
            int hp = GlobalData.Instance.cube_health;
            if (hp >= 0)
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