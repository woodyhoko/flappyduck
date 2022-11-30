using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_levelgenerator1 : MonoBehaviour
{
    public GameObject player;
    public GameObject bigger;
    public GameObject smaller;
    public GameObject star_upgrade;
    public GameObject longger;
    public GameObject faster;
    public GameObject shooter;
    public GameObject pipe;
    public GameObject rock;
    public GameObject wall;
    public GameObject invisible;
    public GameObject move_forward;
    public GameObject portal;
    public GameObject water;
    public GameObject boss;
    public GameObject arm;
    public int bossShow = 1000;
    public GameObject progressBoard;
    public GameObject progress;

    //public GameObject boss;
    GameObject obj;
    Rigidbody m_Rigidbody;
    public float scale = 1f;
    private int time = 0;
    private float speed = -12f;
    RectTransform rt2;
    void Start()
    {
        RectTransform rt = (RectTransform)progressBoard.transform;
        rt2 = (RectTransform)progress.transform;
        rt.sizeDelta = new Vector2(bossShow, 30f);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time++;
        if (time > bossShow)
        {    
            if(time==1001)
            {
                obj = (GameObject)Instantiate(boss);
                obj.transform.position = new Vector3(0, 5, 36); 
                m_Rigidbody = obj.GetComponent<Rigidbody>();     
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                progressBoard.SetActive(false);
            }

            if (time == 1060)
            {
                m_Rigidbody.velocity = new Vector3(0, 0,0);
            }
            if((time-1060)%100==1)
            {
                float u = Random.Range(0,10f); 
                if(u<=2.5f)
                {
                    GameObject e1 = (GameObject)Instantiate(water);
                    GameObject e2 = (GameObject)Instantiate(water);
                    //GameObject e3 = (GameObject)Instantiate(water);
                    GameObject e4 = (GameObject)Instantiate(water);
                    e1.transform.position = new Vector3(-4f, .1f, 10);
                    e2.transform.position = new Vector3(0, .1f, 15);
                    //e3.transform.position = new Vector3(2f, 1, 16);
                    e4.transform.position = new Vector3(4f, .1f, 20);
                    Rigidbody r1 = e1.GetComponent<Rigidbody>();
                    r1.velocity = new Vector3(0, 0, speed);
                    Rigidbody r2 = e2.GetComponent<Rigidbody>();
                    r2.velocity = new Vector3(0, 0, speed);
                    //Rigidbody r3 = e3.GetComponent<Rigidbody>();
                    //r3.velocity = new Vector3(0, 0, -15f);
                    Rigidbody r4 = e4.GetComponent<Rigidbody>();
                    r4.velocity = new Vector3(0, 0, speed);
                }
                else if (u<=5f)
                {
                    GameObject e1 = (GameObject)Instantiate(water);
                    GameObject e2 = (GameObject)Instantiate(water);
                    //GameObject e3 = (GameObject)Instantiate(water);
                    GameObject e4 = (GameObject)Instantiate(water);
                    e1.transform.position = new Vector3(4, .1f, 10);
                    e2.transform.position = new Vector3(0, .1f, 15);
                    //e3.transform.position = new Vector3(2f, 1, 16);
                    e4.transform.position = new Vector3(-4f, .1f, 20);
                    Rigidbody r1 = e1.GetComponent<Rigidbody>();
                    r1.velocity = new Vector3(0, 0, speed);
                    Rigidbody r2 = e2.GetComponent<Rigidbody>();
                    r2.velocity = new Vector3(0, 0, speed);
                    //Rigidbody r3 = e3.GetComponent<Rigidbody>();
                    //r3.velocity = new Vector3(0, 0, -15f);
                    Rigidbody r4 = e4.GetComponent<Rigidbody>();
                    r4.velocity = new Vector3(0, 0, speed);
                }
                else if (u<=7.5f)
                {
                    GameObject e1 = (GameObject)Instantiate(arm);
                    e1.transform.position = new Vector3(-7f, 0.5f, 4);
                    Rigidbody r1 = e1.GetComponent<Rigidbody>();
                    r1.velocity = new Vector3(-speed*0.8f, 0,0);
                }
                else
                {
                    GameObject e1 = (GameObject)Instantiate(arm);
                    e1.transform.position = new Vector3(7f, 0.5f, 4);
                    Rigidbody r1 = e1.GetComponent<Rigidbody>();
                    r1.velocity = new Vector3(speed * 0.8f, 0, 0);
                }
            }
        }
        else
        {
            rt2.sizeDelta = new Vector2(time, 30f);
            float randomNumber = Random.Range(0, 1f);
            //level 1: 0.03
            if (randomNumber > 0.98f)
            {
                Physics.IgnoreLayerCollision(6, 10, true);
                float wallRandom = Random.Range(0, 1f);
                float heightRandom = Random.Range(0, 2f);
                if (randomNumber > 0.99f)
                {
                    GameObject ppipe = (GameObject)Instantiate(pipe);
                    //ppipe.GetComponent<pipe>().SetHealth(100f);
                    ppipe.transform.localScale = new Vector3(0.7f + 2 * wallRandom, 0.5f + heightRandom, 0.7f + 2 * wallRandom);
                    ppipe.transform.rotation = Quaternion.identity;
                    ppipe.transform.position = new Vector3(Random.Range(-5 * scale, 5f * scale), 1, 36);
                    Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                }
                else
                {
                    GameObject watero = (GameObject)Instantiate(water);
                    watero.transform.rotation = Quaternion.identity;
                    watero.transform.position = new Vector3(Random.Range(-5 * scale, 5f * scale), .010f, 36);
                    Rigidbody m_Rigidbody = watero.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                }
            }
            else if (randomNumber < 0.014f)
            {
                GameObject food;
                if (randomNumber < 0.002f)
                {
                    food = Instantiate(bigger);
                }
                else if (randomNumber < 0.004f)
                    food = Instantiate(smaller);
                else if (randomNumber < 0.005f)
                    food = Instantiate(longger);
                else if (randomNumber < 0.006f)
                    food = Instantiate(faster);
                else if (randomNumber < 0.010f)
                    food = Instantiate(shooter);
                else if (randomNumber < 0.012f)
                    food = Instantiate(invisible);
                else
                    food = Instantiate(star_upgrade);

                food.transform.rotation = Quaternion.identity;
                food.transform.Rotate(0, 90, 0); // for showing icons in right view
                food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
                Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }
        }
    }
}

