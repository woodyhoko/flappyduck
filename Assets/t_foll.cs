using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t_foll : MonoBehaviour
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
        healthSystem = new(maxHealth);

    }
    private void OnCollisionEnter(Collision collision)
    {


    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        Vector3 lookDir;
        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y,
            player.transform.position.z);
        if (dist <= reactDist)
        {
            if (dist > 5f)
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
