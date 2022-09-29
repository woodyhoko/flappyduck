using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerator : MonoBehaviour
{
    public GameObject bigger;
    public GameObject smaller;
    public GameObject longger;
    public GameObject faster;
    public GameObject shooter;
    public GameObject pipe;
    public GameObject wall;
    public GameObject invisible;
    public GameObject move_forward;
    public GameObject water;
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
        if (randomNumber > 0.99f)
        {
            float wallRandom = Random.Range(0, 1f);
            float heightRandom = Random.Range(0, 1f);
            if (randomNumber > 0.995f)
            {
                GameObject ppipe = (GameObject)Instantiate(pipe);
                ppipe.GetComponent<pipe>().SetHealth(100f);
                ppipe.transform.localScale = new Vector3(1+wallRandom,0.5f + heightRandom, 1);
                ppipe.transform.rotation = Quaternion.identity;
                ppipe.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
                Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }
            else if ((randomNumber < 0.995f )&&(randomNumber > 0.990f))
            {
                GameObject watero = (GameObject)Instantiate(water);
                watero.transform.rotation = Quaternion.identity;
                watero.transform.position = new Vector3(Random.Range(-5, 5f), 0, 36);
                Rigidbody m_Rigidbody = watero.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            }
            else
            {
                GameObject ppipe = (GameObject)Instantiate(wall);
                ppipe.GetComponent<pipe>().SetHealth(100f);
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
                food = Instantiate(longger);
            else if ((randomNumber < 0.006f) && (randomNumber < 0.008f))
                food = Instantiate(faster);
            else if ((randomNumber < 0.008f) && (randomNumber < 0.01f))
                food = Instantiate(shooter);
            //else if (randomNumber < 0.015f)
            else if ((randomNumber < 0.01f) && (randomNumber < 0.012f))
                food = Instantiate(invisible);
            else
                food = Instantiate(move_forward);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            difficulty++;
        }
    }
}

