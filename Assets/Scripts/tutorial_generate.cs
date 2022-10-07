using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class tutorial_generate : MonoBehaviour
{            
    public GameObject player;
    public GameObject bigger;
    public GameObject smaller;
    public GameObject longger;
    public GameObject faster;
    public GameObject shooter;
    public GameObject invisible;
    public GameObject move_forward;
    public GameObject wall;
    public TMP_Text text;
    public GameObject canvas; // canvas
    int time = 90;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject food;
        if (time == 530||time==840)
        {
            food = Instantiate(wall);
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.localScale = new Vector3(10, 10, 10);
            food.transform.position = new Vector3(0, 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        else if(time==1200) SceneManager.LoadScene("init");
        else if (time == 580)
        {
            text.text = "";
            canvas.SetActive(true);
            PauseGame();
        }
        else if (time % 120 == 0&&time!=600 && time != 480&&time<=720)
        {
 
            if (time == 120)
            {
                food = Instantiate(bigger);
                text.text = "bigger";
            }
            else if (time == 240)
            {
                food = Instantiate(smaller);
                text.text = "smaller";
            }
            else if (time == 360)
            {
                food = Instantiate(invisible);
                text.text = "invisible";
            }
            //else if (time == 480)
            //{
              //  food = Instantiate(move_forward);
              //  text.text = "move forward";
            //}
            else if (time == 720)
            {
                food = Instantiate(shooter);
                text.text = "get a gun!";
            }
            else
            {
                food = Instantiate(wall);
            }
            food.transform.rotation = Quaternion.identity;
            food.transform.Rotate(0, 90, 0); // for showing icons in right view
            food.transform.localScale = new  Vector3(2, 2, 2);
            food.transform.position = new Vector3(0, 1, 36);
            Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0, 0, -15f);
        }
        time++;
    }
    void PauseGame()
    {
        
            Time.timeScale = 0f;
        
    }
}
