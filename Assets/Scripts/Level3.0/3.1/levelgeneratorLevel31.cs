using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class levelgeneratorLevel31 : MonoBehaviour
{
    public GameObject player;
    public GameObject shooter;
    public GameObject pipe;
    public GameObject movingpipe;
    public GameObject wall;
    public GameObject water;
    public GameObject text;
    public GameObject movingHori;

    public GameObject Canvas;
    public TMP_Text title;
    public GameObject replay;
    public GameObject next_level;


    public float pip_pos_z = 45;

    private bool start = true;
    
    private int difficulty = 0, timer = 0;
    //public GameObject player; 
    //public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        // GameObject ppipe = (GameObject)Instantiate (pipe);
        // // var rotation = new Quaternion();
        // // rotation.eulerAngles = new Vector3(54.5f, 0, 0);
        // ppipe.transform.rotation = Quaternion.identity;
        // ppipe.transform.position = new Vector3(0, 1, 20);
        // Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
        // m_Rigidbody.velocity = new Vector3(0,0,-15f);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if (start)
        {

            start = false;
            GameObject food;
            food = Instantiate(shooter);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(4.0f, 2, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);

            
        }

        if (timer == 100)
        {
            GameObject food;
            food = Instantiate(shooter);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(4.0f, 2, 36);
            //food.transform.position = new Vector3(0, 2, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }


        if (timer == 380)
        {
            float x = -3.5f;

            for (float i = 0; i < 2; i++)
            {
                GameObject ppipe = (GameObject)Instantiate(water);
                ppipe.transform.position = new Vector3(x, 0.5f, pip_pos_z+16);
                //ppipe.transform.localScale = new Vector3(0.45f, 0.25f, 3.0f);
                ppipe.transform.localScale = new Vector3(0.45f, 0.25f, 3.0f);
                ppipe.transform.rotation = Quaternion.identity;
                Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                x *= (-1f);
            }


            
            for (int i = 0; i < 8; i++)
            {
                GameObject ppipe = (GameObject)Instantiate(pipe);
                ppipe.transform.position = new Vector3(0f, 1f, pip_pos_z);
                //ppipe.transform.localScale = new Vector3(1.5f, 2f, 1.5f);
                ppipe.transform.rotation = Quaternion.identity;
                Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                pip_pos_z += 4f;
            }

        }

        if (timer == 700)
        {
            Time.timeScale = 0;
            Canvas.SetActive(true);
            title.text = "Level Passed";
            replay.SetActive(false);
            //next_level.SetActive(true);
        }



        /*

        if (timer == 150)
        {
            float x = -4.5f;
            for (float i = 0; i < 6; i++)
            {
                GameObject ppipe = (GameObject)Instantiate(pipe);
                ppipe.transform.position = new Vector3(x, 1f, 36);
                ppipe.transform.localScale = new Vector3(1.5f, 2f, 1.5f);
                ppipe.transform.rotation = Quaternion.identity;
                Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                x += (GlobalData.Instance.plane_width / 6);
            }

        }

        if (timer == 350)
        {

            float z = 36;
            for (int j = 0; j < 5; j++)
            {
                z += 3;
                float x = -4.5f;
                if (j % 2 == 1)
                {
                    x -= 0.3f;
                }
                for (float i = 0; i < 8; i++)
                {
                    GameObject ppipe = (GameObject)Instantiate(movingpipe);
                    ppipe.transform.position = new Vector3(x, 1f, z);
                    ppipe.transform.rotation = Quaternion.identity;
                    Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                    x += (GlobalData.Instance.plane_width / 8);
                }
            }



        }


        if (timer == 550)
        {
            GameObject ppipe = (GameObject)Instantiate(wall);
            //ppipe.GetComponent<pipe>().SetHealth(100f);
            ppipe.transform.localScale = new Vector3(GlobalData.Instance.plane_width, 5f, 6f);
            ppipe.transform.position = new Vector3(0f, 1f, 36);

            ppipe.transform.rotation = Quaternion.identity;

            Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }


        */

       

        
        
        
        

        
        /*
        float randomNumber = Random.Range(0, 1f);
        //level 1: 0.03
        if (randomNumber > 0.96f - difficulty * 0.0001f)
        {
            Physics.IgnoreLayerCollision(6, 10, true);
            float wallRandom = Random.Range(0, 1f);
            float heightRandom = Random.Range(0, 2f);
            if (randomNumber > 0.98f)
            {
                GameObject ppipe = (GameObject)Instantiate(pipe);
                //ppipe.GetComponent<pipe>().SetHealth(100f);
                ppipe.transform.localScale = new Vector3(0.7f+2*wallRandom,0.5f + heightRandom, 0.7f + 2*wallRandom);
                ppipe.transform.rotation = Quaternion.identity;
                ppipe.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
                Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }
            else if (randomNumber>0.95f && randomNumber<0.965f)
            {
                GameObject watero = (GameObject)Instantiate(water);
                watero.transform.rotation = Quaternion.identity;
                watero.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                Rigidbody m_Rigidbody = watero.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            } 
            else if (randomNumber>0.975f && randomNumber<0.98f)
            {
                Debug.Log("horizontal moving");
                GameObject movinghori = (GameObject)Instantiate(movingHori);
                movinghori.transform.rotation = Quaternion.identity;
                Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
                movinghori.transform.rotation = Quaternion.identity;
                movinghori.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }
            else if (randomNumber>0.96f && randomNumber<0.98f)
            {
                Debug.Log("Spawn moving pipe");
                GameObject mpipeo = (GameObject)Instantiate(movingpipe);
                mpipeo.transform.localScale = new Vector3(0.5f+2*wallRandom,0.8f + heightRandom, 0.3f + 2*wallRandom);
                mpipeo.transform.rotation = Quaternion.identity;
                mpipeo.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                Rigidbody m_Rigidbody = mpipeo.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }
            else
            {
                GameObject ppipe = (GameObject)Instantiate(wall);
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
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }
            
        }
        */
        /*
        else if (randomNumber > 0.970f){
            GameObject obj = (GameObject)Instantiate (rock);
            obj.GetComponent<rock>().clone = true;
            // obj.transform.SetParent(this.transform);
            obj.transform.position = new Vector3(Random.Range(-5.5f, 5.5f), 10, player.transform.position.z);
            obj.transform.rotation = new Quaternion(Random.Range(-5.5f, 5.5f),Random.Range(-5.5f, 5.5f),Random.Range(-5.5f, 5.5f),Random.Range(-5.5f, 5.5f));
            
        }
        */

        /*
        else  if (randomNumber < 0.0020f)
        {
            if (GlobalData.Instance.shoot)
            {

            }
            GameObject food;
            //if (randomNumber < 0.0020f)
            {
                food = Instantiate(shooter);
            }
            
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            difficulty++;
        }
        */

    }
}

