using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class controller30 : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    //public Material duckMaterial;
    //public GameObject star;
    public GameObject bullet;    


    private bool jump = false;
    private int jump_numb = 0;
    private float jump_height = 5.0f;
    private int invi_remaining_time = 30;

    // Gravity, reversed gravity, move forward
    private float speed;

    private float timerValue = 0;
    

    public TMP_Text ateText;
    //public TMP_Text limitText;
    public int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        speed = GlobalData.Instance.move_speed * GlobalData.Instance.world_speed;
        m_Rigidbody = GetComponent<Rigidbody>();

        /*
        limitText.text = "eat limitation: " + GlobalData.Instance.update_max_limit;
        ateText.text = "ate:" + GlobalData.Instance.ate.ToString();
        */
        ateText.text = "timer:" + timerValue.ToString();
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

            // No limit on jumping on reversed gravity
            /*
            if (reversed_gravity)
            {
                jump_numb = 2;
                jump = true;
            }
            */
        }

        /*

        if (!GlobalData.Instance.choosen_powerCard)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                GlobalData.Instance.choosen_powerCard = true;
                power_card.SetActive(false);
                GlobalData.Instance.update_max_limit = 9;
                limitText.text = "eat limitation: " + GlobalData.Instance.update_max_limit;
                Time.timeScale = 1f;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                GlobalData.Instance.choosen_powerCard = true;
                power_card.SetActive(false);
                Time.timeScale = 1f;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                GlobalData.Instance.choosen_powerCard = true;
                power_card.SetActive(false);
                Time.timeScale = 1f;
                GlobalData.Instance.move_speed += 0.06f;
            }
        }
        */



    }


    void FixedUpdate()
    {
        timerValue += Time.deltaTime;
        ateText.text = "timer:" + timerValue.ToString();
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
        if(GlobalData.Instance.shoot){
            // print("check");
            GlobalData.Instance.shoot_timestep ++;
           if (GlobalData.Instance.shoot_timestep % GlobalData.Instance.shoot_freq == 0){
                GameObject bul;
                bul = Instantiate(bullet);
                bul.transform.position = transform.position + new Vector3(0, 0, 1f);
                Rigidbody m_Rigidbody = bul.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, 10f);
           }
        }
        if(invi_remaining_time > 0){
            invi_remaining_time--;
            if(invi_remaining_time <= 0){
                EnableCollider ();
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        
        if (GlobalData.Instance.ate < GlobalData.Instance.update_max_limit)
        {
            
            if (collider.gameObject.tag == "shooter")
            {
                Destroy(collider.gameObject);
                GlobalData.Instance.shoot = true;
                /*
                if (GlobalData.Instance.shoot_freq >= 5)
                {
                    GlobalData.Instance.shoot_freq *= 4;
                    GlobalData.Instance.shoot_freq /= 5;
                }
                */
                ScoreManager.shooter++;
                GlobalData.Instance.ate++;
            }

            
            //ateText.text = "ate:" + GlobalData.Instance.ate.ToString();
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


    //private void OnCollisionEnter(Collision collision)
    //{
    //if (collision.gameObject.tag == "pipe")
    //{
    //if player is bigger than (2,2,2) (After eating 4 Bigger foods)
    //  if(transform.localScale.x>2)
    //  {
    //     Debug.Log(collision.gameObject);
    //     Destroy(collision.gameObject);
    // }

    //}
    // }

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
        SceneManager.LoadScene("Level_3_1");
    }

    public void Replay_Button()
    {
        Time.timeScale = 1;
        GlobalData.Instance.destroy();
        SceneManager.LoadScene("Level_3_0");
    }
}
