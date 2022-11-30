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
    public GameObject pipe;
    public GameObject water;
    public GameObject rock;
    public GameObject img;
    public GameObject canvas; // canvas
    public GameObject canvas2; // canvas
    public GameObject shooting_enemy;
    public GameObject chasing_enemy;
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
        else if(time==75)
        {
            PauseGame();
            canvas2.SetActive(true);
        }
        else if(time == 70 || time == 80 || time == 90)
        {
            food = Instantiate(pipe);
            if (time == 70)
                food.transform.position = new Vector3(0, 1, 36);
            else if (time == 80)
                food.transform.position = new Vector3(-4, 1, 36);
            else
                food.transform.position = new Vector3(2, 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        else if(time==130||time==140)
        {
            food = Instantiate(water);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            if(time==130)
                food.transform.position = new Vector3(0, 0, 36);
            else if(time==140)
                food.transform.position = new Vector3(-4, 0, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        else if (time == 160)
        {
            PauseGame();
            canvas2.SetActive(true);
        }
        else if (time == 280)
        {
            GameObject obj = (GameObject)Instantiate(rock);
            obj.GetComponent<t_rock>().clone = true;
            obj.transform.position = new Vector3(player.transform.position.x, 10, player.transform.position.z);
            obj.transform.rotation = new Quaternion(Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f));
        }
        if (time == 275||time==445||time==500)
        {
            PauseGame();
            canvas2.SetActive(true);
        }
        if (time==450)
        {
            food = Instantiate(shooting_enemy);
            //food.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            food.transform.position = new Vector3(3, 0, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            food.SetActive(true);
        }
        if (time == 470)
        {
            food = Instantiate(chasing_enemy);
            //food.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            food.transform.position = new Vector3(-2, 0, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            food.SetActive(true);
        }
        if (time==600)
        {
            food = Instantiate(invisible);
            food.transform.rotation = Quaternion.identity;
            food.transform.position = new Vector3(-3, 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        if(time==640)
        {
            food = Instantiate(wall);
            food.transform.rotation = Quaternion.identity;
            food.transform.localScale = new Vector3(10, 10, 1);
                food.transform.position = new Vector3(0, 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
            
        }

        if(time==680||time==850)
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
