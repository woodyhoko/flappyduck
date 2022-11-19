using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class boss_controller : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public Material duckMaterial;
    public GameObject star;
    public List<GameObject> stars = new List<GameObject>();
    public GameObject bullet;

    private bool jump = false;
    private int jump_numb = 0;
    private float jump_height = 5.0f;
    private int invi_remaining_time = 30;

    // Gravity, reversed gravity, move forward
    public static bool larger_gravity = false;
    public static bool reversed_gravity = false;
    public static bool move_forward = false;
    private float speed;
    public int time = 0;
    public GameObject power_card;

    // properties for levels
    public bool level;
    public GameObject Canvas;
    public GameObject replay;
    public GameObject next_level;
    public TMP_Text title;
    public string this_Level_name = "Level_1_0"; // default value
    public string next_Level_name = "Level_1_0";
    private float timer = 0;

    public void Menu_Button()
    {
        Time.timeScale = 1;
        GlobalData.Instance.destroy();
        SceneManager.LoadScene("menu");
    }

    public void Next_Level_Button()
    {
        ScoreManager.biggerCube = 0;
        ScoreManager.smallerCube = 0;
        ScoreManager.shooter = 0;
        ScoreManager.faster = 0;
        ScoreManager.longer = 0;
        ScoreManager.invisible = 0;
        ScoreManager.star_upgrade = 0;
        if (this_Level_name == "Level_1_0")
        {
            ScoreManager.level10= false;
            ScoreManager.level20 = true;
        } else if (this_Level_name == "Level_2_0")
        {
            ScoreManager.level20 = false;
            ScoreManager.level21 = true;
        } else if (this_Level_name == "Level_2_1")
        {
            ScoreManager.level21 = false;
            ScoreManager.level22 = true;   
        } else if (this_Level_name == "Level_2_2")
        {
            ScoreManager.level22 = false;
            ScoreManager.level23 = true;
            
        } else if (this_Level_name == "Level_2_3")
        {
            ScoreManager.level23 = false;
            ScoreManager.level24 = true;
            
        } else if (this_Level_name == "Level_2_4")
        {
            ScoreManager.level24 = false;
            ScoreManager.level30 = true;
            
        } else if (this_Level_name == "Level_3_0")
        {
            ScoreManager.level30 = false;
            ScoreManager.level31 = true;
        } else if (this_Level_name == "Level_3_1")
        {
            ScoreManager.level31 = false;
        }
        Time.timeScale = 1;
        ScoreManager.startTime = Time.time;
        GlobalData.Instance.destroy();
        SceneManager.LoadScene(next_Level_name);
    }

    public void Replay_Button()
    {
        ScoreManager.biggerCube = 0;
        ScoreManager.smallerCube = 0;
        ScoreManager.shooter = 0;
        ScoreManager.faster = 0;
        ScoreManager.longer = 0;
        ScoreManager.invisible = 0;
        ScoreManager.star_upgrade = 0;
        Time.timeScale = 1;
        ScoreManager.startTime = Time.time;
        GlobalData.Instance.destroy();
        SceneManager.LoadScene(this_Level_name);
    }

    // Start is called before the first frame update
    void Start()
    {
        speed = GlobalData.Instance.move_speed * GlobalData.Instance.world_speed;
        m_Rigidbody = GetComponent<Rigidbody>();
        larger_gravity = false;
        reversed_gravity = false;
        move_forward = false;

        if (power_card != null){
          power_card.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update() {

        if (level && this_Level_name == "Level_1_0")
        {
            if (timer == 900)
            {
                ScoreManager.level10Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 1.0  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }

        if (level && this_Level_name == "Level_2_0")
        {
            if (timer == 1200)
            {
                ScoreManager.level20Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 2.0  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (level && this_Level_name == "Level_2_1")
        {
            if (timer == 1300)
            {
                ScoreManager.level21Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 2.1  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (level && this_Level_name == "Level_2_2") {
            if (timer == 1300)
            {
                ScoreManager.level22Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 2.2  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if(level && this_Level_name == "Level_2_3") {
            if (timer == 1600)
            {
                ScoreManager.level23Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 2.3  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if(level && this_Level_name == "Level_2_4") {
            if (timer == 1900)
            {
                ScoreManager.level24Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 2.4  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if(level && this_Level_name == "Level_3_0") {
            if (timer == 700)
            {
                ScoreManager.level30Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 3.0  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if(level && this_Level_name == "Level_3_1") {
            if (timer == 1400)
            {
                ScoreManager.level31Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 3.1  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }

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


        if (power_card != null){
            if (!GlobalData.Instance.choosen_powerCard)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    GlobalData.Instance.choosen_powerCard = true;
                    power_card.SetActive(false);
                    GlobalData.Instance.update_max_limit = 9;
                    //limitText.text = "eat limitation: " + GlobalData.Instance.update_max_limit;
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
        }



    }


    void FixedUpdate()
    {
        if (level) {
            timer++;
        }

        foreach(GameObject one_star in stars){
            // one_star.transform.RotateAround(transform.position, Vector3.up, GlobalData.Instance.starRotateSpeed);
            one_star.transform.RotateAround(transform.position, Vector3.up, -GlobalData.Instance.starRotateSpeed);
            one_star.transform.eulerAngles = new Vector3(0,0,0);
        }
        // star.transform.RotateAround(transform.position, Vector3.up, GlobalData.Instance.starRotateSpeed);
        // star.transform.RotateAround(transform.position, transform.eulerAngles, starRotateSpeed);

        //set jumping limit
        if (larger_gravity)
        {
            jump_height = 3.0f;
        }
        else
        {
            jump_height = 5.0f;
        }

        //reversed gravity
        if (reversed_gravity)
        {
            Physics.gravity = new Vector3(0, 9.8f, 0);
            //set unlimited jumping under reversed gravity environment
            jump_numb = 2;
            if (jump_height > 0)
            {
                jump_height = jump_height * (-1.0f);
            }
        }
        else
        {
            Physics.gravity = new Vector3(0, -9.8f, 0);
            if (jump_height < 0)
            {
                jump_height = jump_height * (-1.0f);
            }
        }

        if (jump)
        {
            jump = false;

            m_Rigidbody.velocity = new Vector3(0, jump_height, 0);
        }
        

        

        //move forward
        if (move_forward)
        {
            //Debug.Log("z: " + transform.position.z);
            if (transform.position.z < GlobalData.Instance.move_forward_limit)
            {
                m_Rigidbody.velocity = new Vector3(0, 0, m_Rigidbody.velocity.z + 3.0f);
            }
            move_forward = false;
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
            if (collider.gameObject.tag == "bigger")
            {
                //each time becomes 1.2 * original
                Destroy(collider.gameObject);
                transform.localScale = transform.localScale * 1.2f;
                ScoreManager.biggerCube++;
            }

            if (collider.gameObject.tag == "smaller")
            {
                //each time becomes 0.8 * original
                Destroy(collider.gameObject);
                transform.localScale = transform.localScale * 0.8f;
                ScoreManager.smallerCube++;
            }
            if(collider.gameObject.tag == "star_upgrade"){
                ScoreManager.star_upgrade++;
                Destroy(collider.gameObject);
                GameObject one_star  = Instantiate(star);
                one_star.SetActive(true);
                one_star.transform.SetParent(this.transform);
                one_star.transform.localScale = new Vector3(.5f, GlobalData.Instance.star_size, 0.5f);
                stars.Add(one_star);
                float angle = 2f * Mathf.PI / (float)stars.Count;
                for (int i = -1; ++i < stars.Count;){
                    stars[i].transform.position = this.transform.position + new Vector3(Mathf.Cos(angle*i), 0, Mathf.Sin(angle*i));
                }
            }
            if (collider.gameObject.tag == "faster")
            {
                // originally rotate at 30 degree/sec
                Destroy(collider.gameObject);
                GlobalData.Instance.starRotateSpeed *= 1.5f;
                ScoreManager.faster++;
            }
            if (collider.gameObject.tag == "longger")
            {
                //each time becomes 0.8 * original
                Destroy(collider.gameObject);
                GlobalData.Instance.star_size += 0.2f;
                foreach(GameObject one_star in stars){
                    one_star.transform.localScale = new Vector3(0.5f, GlobalData.Instance.star_size, 0.5f);
                }
                
                // star.transform.localScale += new Vector3(0, 0.2f, 0);
                ScoreManager.longer++;
            }
            if (collider.gameObject.tag == "shooter")
            {
                Destroy(collider.gameObject);
                GlobalData.Instance.shoot = true;
                if (GlobalData.Instance.shoot_freq >= 5)
                {
                    GlobalData.Instance.shoot_freq *= 4;
                    GlobalData.Instance.shoot_freq /= 5;
                }
                ScoreManager.shooter++;

            }

            if (collider.gameObject.tag == "move_forward")
            {
                Destroy(collider.gameObject);
                move_forward = true;
            }

            if (collider.gameObject.tag == "gravity")
            {
                Destroy(collider.gameObject);
                reversed_gravity = !reversed_gravity;
            }

            if (collider.gameObject.tag == "gravity_size")
            {
                Destroy(collider.gameObject);
                larger_gravity = !larger_gravity;
            }

            if (collider.gameObject.tag == "invisible")
            {
                Destroy(collider.gameObject);
                Physics.IgnoreLayerCollision(6, 7, true);
                Color tempCol = GetComponent<Renderer>().material.color;
                tempCol.a = .5f;
                GetComponent<Renderer>().material.color = tempCol;
                invi_remaining_time = 100;
                ScoreManager.invisible++;
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
}
