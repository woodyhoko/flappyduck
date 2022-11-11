using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class levelgeneratorLevel1 : MonoBehaviour
{
    public GameObject player;
    public GameObject bigger;
    public GameObject smaller;
    public GameObject movingpipe;
    public GameObject text;
    public GameObject movingHori;

    private int timer; 
    private bool start = true;
    
    public GameObject Canvas;
    public TMP_Text title;
    public GameObject replay;
    public GameObject next_level;

    public bool haveRock = false;

    void Start()
    {
    }

    private void generateRock() {
        GameObject obj = (GameObject)Instantiate(rock);
        obj.GetComponent<rock>().clone = true;
        obj.transform.position = new Vector3(player.transform.position.x, 10, player.transform.position.z);
        obj.transform.rotation = new Quaternion(Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (haveRock && (timer == 100 || timer == 200 || timer == 300)) {
            generateRock();
        }

        timer++;
        if (start)
        {
            start = false;
            GameObject movinghori = (GameObject)Instantiate(movingHori);
            movinghori.transform.rotation = Quaternion.identity;
            //movinghori.transform.position = new Vector3(Random.Range(-6, -1f), .010f, 36);
            movinghori.transform.position = new Vector3(-5f, .010f, 36);
            Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                
            GameObject movinghori2 = (GameObject)Instantiate(movingHori);
            movinghori2.transform.rotation = Quaternion.identity;
            movinghori2.transform.position = new Vector3(5f, .010f, 36);
            Rigidbody m_Rigidbody2 = movinghori2.GetComponent<Rigidbody>();
            m_Rigidbody2.velocity = new Vector3(0, 0, -15f);
        }

        if (timer == 150)
        {
            GameObject movinghori = (GameObject)Instantiate(movingHori);
            movinghori.transform.rotation = Quaternion.identity;
            //movinghori.transform.position = new Vector3(Random.Range(-6, -1f), .010f, 36);
            movinghori.transform.position = new Vector3(-3.5f, .010f, 36);
            Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                
            GameObject movinghori2 = (GameObject)Instantiate(movingHori);
            movinghori2.transform.rotation = Quaternion.identity;
            movinghori2.transform.position = new Vector3(3.5f, .010f, 36);
            Rigidbody m_Rigidbody2 = movinghori2.GetComponent<Rigidbody>();
            m_Rigidbody2.velocity = new Vector3(0, 0, -15f);
        }

        if (timer == 300)
        {
            GameObject food;
            food = Instantiate(smaller);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 1, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        
        if (timer == 330)
        {
            GameObject food;
            food = Instantiate(smaller);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 2, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        
        if (timer == 350)
        {
            GameObject food;
            food = Instantiate(bigger);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 1, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        
        if (timer == 370)
        {
            GameObject food;
            food = Instantiate(smaller);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 2, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        
        if (timer == 390)
        {
            GameObject food;
            food = Instantiate(bigger);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 2, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        

        if (timer == 480)
        {
            GameObject movinghori = (GameObject)Instantiate(movingHori);
            movinghori.transform.rotation = Quaternion.identity;
            //movinghori.transform.position = new Vector3(Random.Range(-6, -1f), .010f, 36);
            movinghori.transform.position = new Vector3(-3f, .010f, 36);
            Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                
            GameObject movinghori2 = (GameObject)Instantiate(movingHori);
            movinghori2.transform.rotation = Quaternion.identity;
            movinghori2.transform.position = new Vector3(3f, .010f, 36);
            Rigidbody m_Rigidbody2 = movinghori2.GetComponent<Rigidbody>();
            m_Rigidbody2.velocity = new Vector3(0, 0, -15f);
        }
        
        if (timer == 530)
        {
            GameObject food;
            food = Instantiate(smaller);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-3, 3f), 1, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        

        if (timer == 600)
        {
            GameObject movinghori = (GameObject)Instantiate(movingHori);
            movinghori.transform.rotation = Quaternion.identity;
            //movinghori.transform.position = new Vector3(Random.Range(-6, -1f), .010f, 36);
            movinghori.transform.position = new Vector3(-2.9f, .010f, 36);
            Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                
            GameObject movinghori2 = (GameObject)Instantiate(movingHori);
            movinghori2.transform.rotation = Quaternion.identity;
            movinghori2.transform.position = new Vector3(2.9f, .010f, 36);
            Rigidbody m_Rigidbody2 = movinghori2.GetComponent<Rigidbody>();
            m_Rigidbody2.velocity = new Vector3(0, 0, -15f);
        }
        
        if (timer == 630)
        {
            GameObject food;
            food = Instantiate(bigger);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 0, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        
        if (timer == 650)
        {
            GameObject food;
            food = Instantiate(bigger);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 1, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        
        if (timer == 670)
        {
            GameObject food;
            food = Instantiate(bigger);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 0, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }

        if (timer == 700)
        {
            GameObject movinghori = (GameObject)Instantiate(movingHori);
            movinghori.transform.rotation = Quaternion.identity;
            //movinghori.transform.position = new Vector3(Random.Range(-6, -1f), .010f, 36);
            movinghori.transform.position = new Vector3(-5f, .010f, 36);
            Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                
            GameObject movinghori2 = (GameObject)Instantiate(movingHori);
            movinghori2.transform.rotation = Quaternion.identity;
            movinghori2.transform.position = new Vector3(5f, .010f, 36);
            Rigidbody m_Rigidbody2 = movinghori2.GetComponent<Rigidbody>();
            m_Rigidbody2.velocity = new Vector3(0, 0, -15f);
        }

        /*
        if (timer == 900)
        {
            ScoreManager.level1Passed= true;
            Time.timeScale = 0;
            Canvas.SetActive(true);
            title.text = "Level Passed";
            replay.SetActive(false);
            next_level.SetActive(true);

        }
        */
        
        /*float randomNumber = Random.Range(0, 1f);
        //level 1: 0.03
        if (randomNumber > 0.96f - difficulty * 0.0001f)
        {
            Physics.IgnoreLayerCollision(6, 10, true);
            float wallRandom = Random.Range(0, 1f);
            float heightRandom = Random.Range(0, 2f);
            //if (randomNumber > 0.98f)
            //{
                /*GameObject ppipe = (GameObject)Instantiate(pipe);
                //ppipe.GetComponent<pipe>().SetHealth(100f);
                ppipe.transform.localScale = new Vector3(0.7f+2*wallRandom,0.5f + heightRandom, 0.7f + 2*wallRandom);
                ppipe.transform.rotation = Quaternion.identity;
                ppipe.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
                Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);*/
           // }
            // if (randomNumber>0.95f && randomNumber<0.965f)
            /*if (time < 30 && first_smaller == false)
            {
                GameObject food;
                food = Instantiate(smaller);

                first_smaller = true;
            }
            else if (time < 50 && first == false)
            {
                Debug.Log(time);
                GameObject movinghori = (GameObject)Instantiate(movingHori);
                movinghori.transform.rotation = Quaternion.identity;
                //movinghori.transform.position = new Vector3(Random.Range(-6, -1f), .010f, 36);
                movinghori.transform.position = new Vector3(-5f, .010f, 36);
                Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                
                GameObject movinghori2 = (GameObject)Instantiate(movingHori);
                movinghori2.transform.rotation = Quaternion.identity;
                movinghori2.transform.position = new Vector3(5f, .010f, 36);
                Rigidbody m_Rigidbody2 = movinghori2.GetComponent<Rigidbody>();
                m_Rigidbody2.velocity = new Vector3(0, 0, -15f);
                first = true;
            } 
            // else if (randomNumber>0.975f && randomNumber<0.98f)
            else if (randomNumber>0.975f && randomNumber<0.98f)
            {
                /*GameObject movinghori = (GameObject)Instantiate(movingHori);
                movinghori.transform.rotation = Quaternion.identity;
                movinghori.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);*/
            //}
            // else if (randomNumber>0.96f && randomNumber<0.98f)
            /*else if (time > 100 && second == false)
            {
                Debug.Log(time);
                GameObject movinghori = (GameObject)Instantiate(movingHori);
                movinghori.transform.rotation = Quaternion.identity;
                //movinghori.transform.position = new Vector3(Random.Range(-6, -1f), .010f, 36);
                movinghori.transform.position = new Vector3(-3f, .010f, 36);
                Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                
                GameObject movinghori2 = (GameObject)Instantiate(movingHori);
                movinghori2.transform.rotation = Quaternion.identity;
                movinghori2.transform.position = new Vector3(3f, .010f, 36);
                Rigidbody m_Rigidbody2 = movinghori2.GetComponent<Rigidbody>();
                m_Rigidbody2.velocity = new Vector3(0, 0, -15f);

                second = true;
            }
            else
            {
                /*GameObject ppipe = (GameObject)Instantiate(wall);
                //ppipe.GetComponent<pipe>().SetHealth(100f);
                if (wallRandom > 0.5)
                {
                    ppipe.transform.localScale = new Vector3(2.5f, 2, 0.5f);
                    ppipe.transform.position = new Vector3(Random.Range(-5, 5f), 1f, 36);
                }
                else
                {
                    ppipe.transform.position = new Vector3(Random.Range(-5, 5f),0.8f, 36);
                }
                ppipe.transform.rotation = Quaternion.identity;
 
                Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);*/
            /*}
            
        }
        else  if (randomNumber < 0.014f)
        {
            GameObject food;
            if (randomNumber < 0.0020f)
            {
                food = Instantiate(bigger);
            }
            else if ((randomNumber < 0.002f) && (randomNumber < 0.004f))
                food = Instantiate(smaller);
            else if ((randomNumber < 0.004f) && (randomNumber < 0.006f))
                food = Instantiate(bigger);
            else if ((randomNumber < 0.006f) && (randomNumber < 0.008f))
                food = Instantiate(smaller);
            else if ((randomNumber < 0.008f) && (randomNumber < 0.01f))
                food = Instantiate(bigger);
            //else if (randomNumber < 0.015f)
            else if ((randomNumber < 0.01f) && (randomNumber < 0.012f))
                food = Instantiate(smaller);
            else
                food = Instantiate(smaller);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            difficulty++;
        }
        else if (randomNumber < 0.015f)
        {
            GameObject p = (GameObject)Instantiate(portal);
            p.transform.position = new Vector3(Random.Range(-4, 4f), 2, 36);
            Rigidbody m_Rigidbody = p.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }

        time++;*/
    }
}

