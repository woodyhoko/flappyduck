using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mud_levelgenerator : MonoBehaviour
{
    public GameObject player;
    public GameObject bigger;
    public GameObject smaller;
    public GameObject star_upgrade;
    public GameObject longger;
    public GameObject faster;
    public GameObject shooter;
    public GameObject pipe;
    public GameObject movingpipe;
    public GameObject rock;
    public GameObject wall;
    public GameObject invisible;
    public GameObject move_forward;
    public GameObject portal;
    public GameObject water;
    //public GameObject text;

    // public GameObject movingHori;

    private int difficulty = 0;
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
        float randomNumber = Random.Range(0, 1f);
        //level 1: 0.03
        if (randomNumber > 0.995f)
        {
            GameObject obj = (GameObject)Instantiate(rock);
            obj.GetComponent<rock>().clone = true;
            // obj.transform.SetParent(this.transform);
            obj.transform.position = new Vector3(Random.Range(-5.5f, 5.5f), 10, player.transform.position.z);
            obj.transform.rotation = new Quaternion(Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f));

        }
        if (randomNumber > 0.96f - difficulty * 0.0001f)
        {
            Physics.IgnoreLayerCollision(6, 10, true);
            float wallRandom = Random.Range(0, 1f);
            float heightRandom = Random.Range(0, 2f);
            if (randomNumber > 0.98f)
            {
                GameObject ppipe = (GameObject)Instantiate(pipe);
                //ppipe.GetComponent<pipe>().SetHealth(100f);
                ppipe.transform.localScale = new Vector3(0.7f + 2 * wallRandom, 0.5f + heightRandom, 0.7f + 2 * wallRandom);
                ppipe.transform.rotation = Quaternion.identity;
                ppipe.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
                Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }
            else if (randomNumber > 0.95f && randomNumber < 0.965f)
            {
                GameObject watero = (GameObject)Instantiate(water);
                watero.transform.rotation = Quaternion.identity;
                watero.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                Rigidbody m_Rigidbody = watero.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }
            /*else if (randomNumber>0.975f && randomNumber<0.98f)
            {
                Debug.Log("horizontal moving");
                GameObject movinghori = (GameObject)Instantiate(movingHori);
                movinghori.transform.rotation = Quaternion.identity;
                Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
                movinghori.transform.rotation = Quaternion.identity;
                movinghori.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }*/
            else if (randomNumber > 0.96f && randomNumber < 0.98f)
            {
                Debug.Log("Spawn moving pipe");
                GameObject mpipeo = (GameObject)Instantiate(movingpipe);
                mpipeo.transform.localScale = new Vector3(0.5f + 2 * wallRandom, 0.8f + heightRandom, 0.3f + 2 * wallRandom);
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
                    ppipe.transform.position = new Vector3(Random.Range(-2, 2f), 0.8f, 36);
                }
                ppipe.transform.rotation = Quaternion.identity;

                Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }
        }
        else if (randomNumber < 0.016f)
        {
            GameObject food;
            if (randomNumber < 0.0020f)
            {
                food = Instantiate(bigger);
            }
            else if ((randomNumber < 0.002f) && (randomNumber < 0.004f))
                food = Instantiate(smaller);
            else if ((randomNumber < 0.004f) && (randomNumber < 0.006f))
                food = Instantiate(longger);
            else if ((randomNumber < 0.006f) && (randomNumber < 0.008f))
                food = Instantiate(faster);
            else if ((randomNumber < 0.008f) && (randomNumber < 0.01f))
                food = Instantiate(shooter);
            //else if (randomNumber < 0.015f)
            else if ((randomNumber < 0.01f) && (randomNumber < 0.012f))
                food = Instantiate(invisible);
            else if ((randomNumber < 0.012f) && (randomNumber < 0.014f))
                food = Instantiate(star_upgrade);
            else
                food = Instantiate(move_forward);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            difficulty++;
        }
        else if (randomNumber < 0.018)
        {
            GameObject p = (GameObject)Instantiate(portal);
            p.transform.position = new Vector3(Random.Range(-4, 4f), 2, 36);
            Rigidbody m_Rigidbody = p.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
    }
}

