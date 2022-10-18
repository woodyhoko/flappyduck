using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
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

    public TMP_Text ateText;
    public TMP_Text limitText;
    public int time = 0;
    public GameObject power_card;

    // properties for levels
    public bool level;
    public GameObject Canvas;
    public GameObject replay;
    public GameObject next_level;
    public TMP_Text title;
    public string this_Level_name = "Level1smaller"; // default value
    public string next_Level_name = "Level1smaller";
    private float timer = 0;

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
        SceneManager.LoadScene(next_Level_name);
    }

    public void Replay_Button()
    {
        Time.timeScale = 1;
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
        // if (!level && !GlobalData.Instance.choosen_powerCard)
        // {
        //     if(power_card != null){
        //         power_card.SetActive(true);
        //     }
        //     Time.timeScale = 0f;
        // }
        power_card.SetActive(false);
        if (limitText != null){
            limitText.text = "eat limitation: " + GlobalData.Instance.update_max_limit;
        }
        if (ateText != null){
            ateText.text = "ate:" + GlobalData.Instance.ate.ToString();
        }
    }

    // Update is called once per frame
    void Update() {
        if(level && this_Level_name != "Level1smaller") {
            if (timer == 700)
            {
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if(level && this_Level_name == "Level_3_1") {
            if (timer == 700)
            {
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if(level && this_Level_name != "Level1smaller") {
            if (timer == 700)
            {
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level Passed";
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
        }



    }


    void FixedUpdate()
    {
        if (level) {
            timer++;
        }
        //time++;
        //if(time>200) SceneManager.LoadScene("demo2");


        // if(Input.GetKeyDown(KeyCode.A)){
        //     transform.Position(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
        // }
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
            

            /*
            if (larger_gravity)
            {
                m_Rigidbody.velocity = new Vector3(0, 3.0f, 0);
            }
            else
            {
                m_Rigidbody.velocity = new Vector3(0, 5.0f, 0);
            }
            //m_Rigidbody.AddForce(0, -9.8f, 0, ForceMode.Force);
            */
            
            Debug.Log("gravity: " + Physics.gravity);
            Debug.Log("jumping: " + transform.position);
            Debug.Log("jumping height: " + jump_height);
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

            Debug.Log("z: " + transform.position.z);
            //m_Rigidbody.velocity = new Vector3(0, 0, m_Rigidbody.velocity.z + 2.0f);
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
        if (collider.gameObject.tag == "portal_back")
        {
            //each time becomes 1.2 * original
            SceneManager.LoadScene("demo2");
            GlobalData.Instance.world_speed = 1f;
        }
        if (collider.gameObject.tag == "portal")
        {
            float randomNumber = Random.Range(0, 1f);
            if(randomNumber<1f)
            {  
                SceneManager.LoadScene("small_world");
            }
            else
            {
                GlobalData.Instance.world_speed = 0.7f;
                SceneManager.LoadScene("mud_world");
            }
            //each time becomes 1.2 * original

        }
        if (level || GlobalData.Instance.ate < GlobalData.Instance.update_max_limit)
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
            if(collider.gameObject.tag == "star_upgrade"){
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
                GlobalData.Instance.ate++;
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
                GlobalData.Instance.ate++;
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
                GlobalData.Instance.ate++;
            }

            if (collider.gameObject.tag == "move_forward")
            {
                Destroy(collider.gameObject);
                move_forward = true;
                GlobalData.Instance.ate++;
            }

            if (collider.gameObject.tag == "gravity")
            {
                Destroy(collider.gameObject);
                reversed_gravity = !reversed_gravity;
                GlobalData.Instance.ate++;
            }

            if (collider.gameObject.tag == "gravity_size")
            {
                Destroy(collider.gameObject);
                larger_gravity = !larger_gravity;
                GlobalData.Instance.ate++;
            }

            if (collider.gameObject.tag == "invisible")
            {
                Destroy(collider.gameObject);
                Physics.IgnoreLayerCollision(6, 7, true);
                Color tempCol = GetComponent<Renderer>().material.color;
                tempCol.a = .5f;
                GetComponent<Renderer>().material.color = tempCol;
                invi_remaining_time = 100;
                // Invoke ("EnableCollider", 5f);
                ScoreManager.invisible++;
                GlobalData.Instance.ate++;
            }
            if (ateText != null){
                ateText.text = "ate:" + GlobalData.Instance.ate.ToString();
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
}
