using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pipe : MonoBehaviour
{
    public GameObject healthBarUI;
    public Canvas Canvas;
    GameObject healthBar;
    //public HealthBar hb;
    HealthSystem healthSystem;
    // Start is called before the first frame update
    void Start()
    {  
      
      healthSystem = new(100f);
      //hb.Setup(healthSystem);
      healthBar = (GameObject)Instantiate(healthBarUI);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        healthBar.transform.SetParent(Canvas.transform);
        healthBar.transform.position = this.transform.position + new Vector3(0,1f,0);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag== "bullet")
        {
            //Debug.Log("get hit by bullet");
            healthSystem.Damage(20);
            healthBar.transform.localScale -= new Vector3(0.25f,0,0);
            //Debug.Log(healthSystem.GetHealth());
            if (healthSystem.GetHealth() <= 0)
            {
                Destroy(gameObject);
                Destroy(healthBar);
            }

        }
        if (collider.gameObject.tag == "star")
        {
            Destroy(gameObject);
            Destroy(healthBar);
        }
    }
}
