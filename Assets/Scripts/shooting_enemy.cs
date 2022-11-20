using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting_enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enebul;
    public float maxHealth = 50f;
    private Rigidbody enemyrb;
    HealthSystem healthSystem;


    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        healthSystem= new(maxHealth);
    }
    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "bullet")
        {
            Debug.Log("Enemy get hit by bullet1");
            if (gameObject != null && collider.gameObject != null&& healthSystem!=null)
            {
                //healthSystem.Damage(collider.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
                healthSystem.Damage(50f);
                //pipeHealth.TakeDamage(collision.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
                //Debug.Log(healthSystem.GetHealth());
                gameObject.GetComponent<Renderer>().material.color = new Color(Mathf.Clamp(1 - healthSystem.GetHealthPercentage(), 0, 1), Mathf.Clamp(healthSystem.GetHealthPercentage(), 0, 1), 0, 0.5f);
                Debug.Log(healthSystem.GetHealth());
                if (healthSystem.GetHealth().Equals(0f))
                {
                    Destroy(collider.gameObject);
                    Destroy(gameObject);
                }
                // Destroy(gameObject);
            }
            else  if (collider.gameObject.tag == "Player")
            {
                GlobalData.Instance.cube_health -= 1;
                GlobalData.Instance.hearts[GlobalData.Instance.cube_health].SetActive(false);
                if (GlobalData.Instance.cube_health <= 0f)
                {
                    FindObjectOfType<GameManager>().EndGame();
                }
                Debug.Log("get hit by shooting enemy");
                Destroy(gameObject);
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "bullet")
        {
            Debug.Log("Enemy get hit by bullet2");
            //Debug.Log("get hit by bullet");
            healthSystem.Damage(collision.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
            //pipeHealth.TakeDamage(collision.gameObject.GetComponent<auto_remove_bullet>().bullet_damage);
            if (healthSystem.GetHealth().Equals(0f))
            {
                Destroy(collision.gameObject);
            }


        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.ts % GlobalData.Instance.shoot_freq == 0)
        {  

            GameObject enebulins;
            enebulins = Instantiate(enebul);
            enebulins.transform.position = transform.position + new Vector3(0, 0,-2f);
            Rigidbody m_Rigidbody = enebulins.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -20f);
        }
    }
}
