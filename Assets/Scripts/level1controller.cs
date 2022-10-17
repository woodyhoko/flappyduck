using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class level1controller : MonoBehaviour
{
    Rigidbody m_Rigidbody;


    private bool jump = false;
    private int jump_numb = 0;
    private float jump_height = 5.0f;

    // Gravity, reversed gravity, move forward
    private float speed;

    private float timerValue = 0;
    

    // public TMP_Text ateText;
    //public TMP_Text limitText;
    public int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        speed = GlobalData.Instance.move_speed * GlobalData.Instance.world_speed;
        m_Rigidbody = GetComponent<Rigidbody>();
        
        Time.timeScale = 1;
    }



    // Update is called once per frame
    void Update() {

        

        if (Input.GetKeyDown(KeyCode.Space)){

            if (jump_numb > 0)
            {
                jump = true;
                jump_numb -= 1;
            }
        }
    }


    void FixedUpdate()
    {
        timerValue += Time.deltaTime;
        // ateText.text = "timer:" + timerValue.ToString();
        //time++;
        //if(time>200) SceneManager.LoadScene("demo2");


        // if(Input.GetKeyDown(KeyCode.A)){
        //     transform.Position(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
        // }
        //star.transform.RotateAround(transform.position, Vector3.up, GlobalData.Instance.starRotateSpeed);
        // star.transform.RotateAround(transform.position, transform.eulerAngles, starRotateSpeed);



        if (jump)
        {
            jump = false;
            m_Rigidbody.velocity = new Vector3(0, jump_height, 0);
        }


        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position = transform.position + new Vector3(-speed, 0 ,0); 
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position = transform.position + new Vector3(speed, 0 ,0);    
        }
        
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        
        if (GlobalData.Instance.ate < GlobalData.Instance.update_max_limit)
        {
            if (collider.gameObject.tag == "bigger")
            {
                //each time becomes 1.2 * original
                Destroy(collider.gameObject);
                transform.localScale = transform.localScale * 1.2f;
                ScoreManager.biggerCube++;
                GlobalData.Instance.ate++;


            }
            if (collider.gameObject.tag == "smaller")
            {
                //each time becomes 0.8 * original
                Destroy(collider.gameObject);
                transform.localScale = transform.localScale * 0.8f;
                ScoreManager.smallerCube++;
                GlobalData.Instance.ate++;
            }
        }
    }
    private void  EnableCollider () {
        Color tempCol = GetComponent<Renderer>().material.color;
        tempCol.a = 1f;
        GetComponent<Renderer>().material.color = tempCol;
        Physics.IgnoreLayerCollision(6, 7, false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plane")
        {
            jump_numb = 2;

        }
    }
    
    public void Menu_Button()
    {
        Time.timeScale = 1;
        GlobalData.Instance.destroy();
        SceneManager.LoadScene("menu");
    }

    public void Next_Level_Button()
    {
        Time.timeScale = 1;
        GlobalData.Instance.destroy();
        SceneManager.LoadScene("Level_2_0");
    }

    public void Replay_Button()
    {
        Time.timeScale = 1;
        GlobalData.Instance.destroy();
        SceneManager.LoadScene("level1smaller");
    }
}
