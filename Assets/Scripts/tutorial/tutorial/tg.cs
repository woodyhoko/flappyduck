using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class tg : MonoBehaviour
{            
    public GameObject player;
    public GameObject invisible;
    public GameObject move_forward;
    public GameObject wall;
    public GameObject water;
    public GameObject rock;
    public GameObject img;
    public GameObject canvas; // canvas
    public GameObject canvas2; // canvas
    int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        PauseGame();
    }
    void Update()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject food;
        if(time==80)
        {
            PauseGame();
            canvas2.SetActive(true);
        }
        if (time == 20||time==50||time==60)
        {

            food = Instantiate(wall);
            food.transform.rotation = Quaternion.identity;
            if(time==30)
                food.transform.position = new Vector3(0, 1, 36);
            else if(time==50)
                food.transform.position = new Vector3(-3, 1, 36);
            else
                food.transform.position = new Vector3(5, 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        else if(time==100||time==120||time==130)
        {
            food = Instantiate(water);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            if(time==120)
                food.transform.position = new Vector3(0, 0, 36);
            else if(time==100)
                food.transform.position = new Vector3(-4, 0, 36);
            else
                food.transform.position = new Vector3(2, 0, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        else if (time == 280)
        {
            GameObject obj = (GameObject)Instantiate(rock);
            GameObject obj2 = (GameObject)Instantiate(rock);
            obj.GetComponent<rock>().clone = true;
            obj2.GetComponent<rock>().clone = true;
            // obj.transform.SetParent(this.transform);
            obj.transform.position = new Vector3(-4, 10, player.transform.position.z);
        
            obj2.transform.position = new Vector3(0, 10, player.transform.position.z);
        }
        if(time==281)
        {
            PauseGame();
            canvas2.SetActive(true);
        }
        if(time==320)
        {
            food = Instantiate(invisible);
            food.transform.rotation = Quaternion.identity;
            food.transform.position = new Vector3(-3, 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        if(time==330)
        {
            food = Instantiate(wall);
            food.transform.rotation = Quaternion.identity;
            food.transform.localScale = new Vector3(10, 10, 1);
                food.transform.position = new Vector3(0, 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        if(time==360)
        {
            PauseGame();
            canvas2.SetActive(true);
        }
        if(time==480)
        {
            PauseGame();
            canvas2.SetActive(true);
        }
        time++;
    }
    void
        PauseGame()
    {
        
            Time.timeScale = 0f;
        
    }
}
