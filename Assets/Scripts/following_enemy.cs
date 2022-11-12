using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class following_enemy : MonoBehaviour
{
    public float maxHealth = 50f;
    private float speed = 5f;

    private Rigidbody enemyrb;
    HealthSystem healthSystem;

    private GameObject player;

    private float reactDist = 50f;
    // Start is called before the first frame update
    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        player = GameObject.Find("Cube");
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
        }
        else  if (collider.gameObject.tag == "Player")
        {
            GlobalData.Instance.cube_health -= 1;
            GlobalData.Instance.hearts[GlobalData.Instance.cube_health].SetActive(false);
            if (GlobalData.Instance.cube_health <= 0f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
            Debug.Log("get hit by chasing enemy");
            Destroy(gameObject);
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
    void FixedUpdate()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        Vector3 lookDir;
        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y,
            player.transform.position.z);
        if (dist <= reactDist)
        { if (dist > 5f)
            {
                targetPos.z += (dist / 2f);
            }
            
            lookDir = (targetPos - transform.position).normalized;
            enemyrb.AddForce(lookDir * speed);
        }
        else
        {
            lookDir = (targetPos - transform.position).normalized;
            enemyrb.AddForce(lookDir * speed * 0.2f);
        }
    }
}
