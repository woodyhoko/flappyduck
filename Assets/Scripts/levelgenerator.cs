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
	public GameObject invisible;
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
    void Update()
    {
   
        float randomNumber = Random.Range(0, 1f);
        if (randomNumber > 0.995f-0.001f*difficulty*3){
        GameObject ppipe = (GameObject)Instantiate (pipe);
        ppipe.transform.rotation = Quaternion.identity;
        ppipe.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
        Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
        m_Rigidbody.velocity = new Vector3(0,0,-15f);
        }
        else if(randomNumber < 0.004f)
        {    
            GameObject food;
            if (randomNumber<0.001f)
            {
                food = Instantiate(bigger);
            }
            else if(randomNumber < 0.002f)
                food = Instantiate(smaller);
            else if(randomNumber < 0.003f)
                food = Instantiate(longger);
            else
                food = Instantiate(faster);
            food.transform.rotation = Quaternion.identity;
            food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            difficulty++;
        }
        if (randomNumber > 0.004f && randomNumber < 0.005f){
            GameObject food;
            food = Instantiate(shooter);
            food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -20f);
            difficulty++;
        }

        if (randomNumber > 0.005f && randomNumber < 0.01f){
            GameObject food;
            food = Instantiate(invisible);
            food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -20f);
            difficulty++;
        }
    }
}
