using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class levelgeneratorLevel1 : MonoBehaviour
{
    public GameObject player;
    public GameObject bigger;
    public GameObject smaller;
    public GameObject text;
    public GameObject movingHori;

    private int timer;
    private bool start = true;

    public GameObject Canvas;
    public TMP_Text title;
    public GameObject replay;
    public GameObject next_level;
    public GameObject rock;
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

        // level 1.1
        if (haveRock) {
            level11();
            return;
        }

        // level 1.0
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
    }

    private void level11(){
        if (haveRock && (timer == 90 || timer == 330 || timer == 810)) {
            generateRock();
        }

        if (timer == 180)
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

        if (timer == 200 || timer == 250 || timer == 300 || timer == 350 || timer == 380 || timer == 420 || timer == 550 || timer == 580 || timer == 700)
        {
            GameObject food;
            food = Instantiate(smaller);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 1, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }

        if (timer == 350 || timer == 390)
        {
            GameObject food;
            food = Instantiate(bigger);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 1, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }

        if (timer == 520)
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

        if (timer == 650)
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

        if (timer == 600 || timer == 700 || timer == 770)
        {
            GameObject food;
            food = Instantiate(bigger);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-4, 4f), 2, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }

        if (timer == 800)
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

    }
}

