using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public Material duckMaterial;
    public GameObject main_camera;
    public GameObject star;
    public List<GameObject> stars = new List<GameObject>();
    public GameObject bullet;

    public GameObject cube;
    public GameObject heart;
    public GameObject HealthUi;
    // public List<GameObject> hearts = new List<GameObject>();

    private bool jump = false;
    private int jump_numb = 0;
    public static int ts;
    private float jump_height = 5.0f;
    private int invi_remaining_time = 30;
    // Gravity, reversed gravity, move forward
    public static bool larger_gravity = false;
    public static bool reversed_gravity = false;
    //public static bool move_forward = false;
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
    public string this_Level_name = "Level_1_0"; // default value
    public string next_Level_name = "Level_1_0";
    private float timer = 0;
    private bool fps_mode = false;
    private bool fps_mode_lock = false;

    private int lastKey = 0; // 0 for left and 1 for right

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
            ScoreManager.level10 = false;
            ScoreManager.level11 = true;
        }
        if (this_Level_name == "Level_1_1")
        {
            ScoreManager.level11 = false;
            ScoreManager.level20 = true;
        }
        else if (this_Level_name == "Level_2_0")
        {
            ScoreManager.level20 = false;
            ScoreManager.level21 = true;
        }
        else if (this_Level_name == "Level_2_1")
        {
            ScoreManager.level21 = false;
            ScoreManager.level22 = true;
        }
        else if (this_Level_name == "Level_2_2")
        {
            ScoreManager.level22 = false;
            ScoreManager.level23 = true;

        }
        else if (this_Level_name == "Level_2_3")
        {
            ScoreManager.level23 = false;
            ScoreManager.level24 = true;

        }
        else if (this_Level_name == "Level_2_4")
        {
            ScoreManager.level24 = false;
            ScoreManager.level30 = true;

        }
        else if (this_Level_name == "Level_3_0")
        {
            ScoreManager.level30 = false;
            ScoreManager.level31 = true;
        }
        else if (this_Level_name == "Level_3_1")
        {
            ScoreManager.level31 = false;
        }
        else if (this_Level_name == "Level_4_0")
        {
            ScoreManager.level40 = false;
            ScoreManager.level41 = true;
        }
        else if (this_Level_name == "Level_4_1")
        {
            ScoreManager.level41 = false;
            ScoreManager.level42 = true;
        }
        else if (this_Level_name == "Level_4_2")
        {
            ScoreManager.level42 = false;
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
        //change cube color
        //gameObject.GetComponent<Renderer>().material.color = new Color(Mathf.Clamp(1 - GlobalData.Instance.cube_health / 100f, 0, 1), Mathf.Clamp(GlobalData.Instance.cube_health / 100f, 0, 1), 0, 0.5f);


        

        speed = GlobalData.Instance.move_speed * GlobalData.Instance.world_speed;
        m_Rigidbody = GetComponent<Rigidbody>();
        larger_gravity = false;
        reversed_gravity = false;
        GlobalData.Instance.move_forward = false;
        // if (!level && !GlobalData.Instance.choosen_powerCard)
        // {
        //     if(power_card != null){
        //         power_card.SetActive(true);
        //     }
        //     Time.timeScale = 0f;
        // }
        if (power_card != null)
        {
            power_card.SetActive(false);
        }
        if (limitText != null)
        {
            limitText.text = "eat limitation: " + GlobalData.Instance.update_max_limit;
        }
        if (ateText != null)
        {
            ateText.text = "ate:" + GlobalData.Instance.ate.ToString();
        }
        for (int star_num_now = 0; star_num_now < GlobalData.Instance.star_num; star_num_now++)
        {
            GameObject one_star = Instantiate(star);
            one_star.SetActive(true);
            one_star.transform.SetParent(this.transform);
            one_star.transform.localScale = new Vector3(.5f, GlobalData.Instance.star_size, 0.5f);
            stars.Add(one_star);
            float angle = 2f * Mathf.PI / (float)stars.Count;
            for (int i = -1; ++i < stars.Count;)
            {
                stars[i].transform.position = this.transform.position + new Vector3(Mathf.Cos(angle * i), 0, Mathf.Sin(angle * i));
            }
        }
        for (int heart_now = 0; heart_now < GlobalData.Instance.cube_health; heart_now++)
        {
            GameObject heart1 = Instantiate(heart);
            heart1.SetActive(true);
            GlobalData.Instance.hearts.Add(heart1);
            heart1.transform.SetParent(HealthUi.transform);
            heart1.transform.position = new Vector3(50 + 55 * heart_now, 50f, 0f);
            //Debug.Log(GlobalData.Instance.cube_health);
        }
    }

    private void showResultPage(string text, bool hasRock)
    {
        Time.timeScale = 0;

        // set canvas
        Canvas.SetActive(true);
        GameObject background = Canvas.GetComponent<Transform>().Find("Background").gameObject;
        background.SetActive(true);
        if (hasRock)
        {
            GameObject dizzy = Canvas.GetComponent<Transform>().Find("Dizzy").gameObject;
            dizzy.SetActive(false);
        }

        title.text = text;
        replay.SetActive(false);
        next_level.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (fps_mode_lock)
        {
            main_camera.transform.position = this.transform.position;
        }
        if (level && this_Level_name == "Level_1_0")
        {
            if (timer == 900)
            {
                ScoreManager.level10Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 1.0  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }

        if (level && this_Level_name == "Level_1_1")
        {
            if (timer == 1000)
            {
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                ScoreManager.cube_health_org = GlobalData.Instance.hearts.Count;
                ScoreManager.level11Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                showResultPage("Level 1.1  Passed", true);
            }
        }

        if (level && this_Level_name == "Level_1_mid_dy")
        {
            if (timer >= 900)
            {
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                ScoreManager.cube_health_org = GlobalData.Instance.hearts.Count;
                ScoreManager.level11Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                showResultPage("Level_1_mid Passed", true);
            }
        }

        if (level && this_Level_name == "Level_3_mid_dy")
        {
            if (timer >= 950)
            {
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                ScoreManager.cube_health_org = GlobalData.Instance.hearts.Count;
                ScoreManager.level11Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                showResultPage("Level_3_mid Passed", true);
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
                ScoreManager.cube_health = GlobalData.Instance.cube_health;

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
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 2.1  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (level && this_Level_name == "Level_2_2")
        {
            if (timer == 1300)
            {
                ScoreManager.level22Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 2.2  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (level && this_Level_name == "Level_2_3")
        {
            if (timer == 1500)
            {
                ScoreManager.level23Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                title.text = "Level 2.3  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (level && this_Level_name == "Level_2_4")
        {
            if (timer == 1900)
            {
                ScoreManager.level24Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                title.text = "Level 2.4  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (level && this_Level_name == "Level_3_0")
        {
            if (timer == 700)
            {
                ScoreManager.level30Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                Time.timeScale = 0;
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                Canvas.SetActive(true);
                title.text = "Level 3.0  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (level && this_Level_name == "Level_3_1")
        {
            if (timer == 1400)
            {
                ScoreManager.level31Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                Time.timeScale = 0;
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                Canvas.SetActive(true);
                title.text = "Level 3.1  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }

        if (level && this_Level_name == "Level_4_0")
        {
            //stop game
            //if (timer == 300)
            //{
                
            //    Time.timeScale = 0;
                

            //}
            if (timer == 600)
            {
                ScoreManager.level40Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 4.0  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (level && this_Level_name == "Level_4_1")
        {
            if (timer == 820)
            {
                ScoreManager.level41Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 4.1  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (level && this_Level_name == "Level_5_0")
        {
            if (timer == 500)
            {
                // ScoreManager.level41Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                title.text = "Level 5.0  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (level && this_Level_name == "Level_4_2")
        {
            if (timer == 1100)
            {
                ScoreManager.level42Passed = true;
                ScoreManager.killedByBound = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                Time.timeScale = 0;
                Canvas.SetActive(true);
                ScoreManager.cube_health = GlobalData.Instance.cube_health;
                title.text = "Level 4.2  Passed";
                replay.SetActive(false);
                next_level.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

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


        if (power_card != null)
        {
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
        ts = ts + 1;
        if (!fps_mode_lock)
        {
            if (fps_mode && Vector3.Distance(main_camera.transform.position, this.transform.position) < 0.1)
            {
                fps_mode_lock = true;
            }
            if (fps_mode)
            {
                main_camera.transform.position = Vector3.Lerp(main_camera.transform.position, transform.position, 0.1f);
                main_camera.transform.rotation = Quaternion.Lerp(main_camera.transform.rotation, Quaternion.Euler(new Vector3(0, 0, 0)), 0.1f);
            }
            else
            {
                main_camera.transform.position = Vector3.Lerp(main_camera.transform.position, new Vector3(0, 4.6f, -7.69f), 0.1f);
                main_camera.transform.rotation = Quaternion.Lerp(main_camera.transform.rotation, Quaternion.Euler(32.725f, 0, 0), 0.1f);
            }
        }


        if (level)
        {
            timer++;
        }
        //time++;
        //if(time>200) SceneManager.LoadScene("demo2");


        // if(Input.GetKeyDown(KeyCode.A)){
        //     transform.Position(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
        // }
        foreach (GameObject one_star in stars)
        {
            // one_star.transform.RotateAround(transform.position, Vector3.up, GlobalData.Instance.starRotateSpeed);
            one_star.transform.RotateAround(transform.position, Vector3.up, -GlobalData.Instance.starRotateSpeed);
            one_star.transform.eulerAngles = new Vector3(0, 0, 0);
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
            
            m_Rigidbody.velocity = new Vector3(0, jump_height, 0);
        }




        //move forward
        if (GlobalData.Instance.move_forward)
        {
            //Debug.Log("z: " + transform.position.z);
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            Rigidbody player_Rigibody = player.GetComponent<Rigidbody>();

            if (player.transform.position.z < GlobalData.Instance.move_forward_limit)
            {
                //m_Rigidbody.velocity = new Vector3(0, 0, m_Rigidbody.velocity.z + 3.0f);
                player_Rigibody.velocity = new Vector3(0, 0, m_Rigidbody.velocity.z + 3.0f);

                //cloned cubes move forward
                int size = GlobalData.Instance.cloned_list.Count;
                for (int i = 0; i < size; i++)
                {
                    GlobalData.Instance.cloned_list[i].GetComponent<Rigidbody>().velocity = player_Rigibody.velocity;
                }
            }

            
        }

        // movement
        if (!GlobalData.Instance.dizzy)
        {
            MoveController();
        }
        else
        {
            TriggerDizzness();
        }

        //Time.timeScale = 0;
        if (GlobalData.Instance.shoot)
        {
            // print("check");
            GlobalData.Instance.shoot_timestep++;
            if (GlobalData.Instance.shoot_timestep % GlobalData.Instance.shoot_freq == 0)
            {
                // Player
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                GameObject bul;
                bul = Instantiate(bullet);
                bul.transform.position = player.transform.position + new Vector3(0, 0, 1f);
                Rigidbody m_Rigidbody = bul.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, 10f);

                //clone

                foreach (GameObject cloned_cube in GlobalData.Instance.cloned_list)
                {
                    GameObject cloned_bul = Instantiate(bullet);
                    cloned_bul.transform.position = cloned_cube.transform.position + new Vector3(0, 0, 1f);
                    cloned_bul.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 10f);
                }
            }


            
        }
        if (invi_remaining_time > 0)
        {
            GlobalData.Instance.isInvi = true;
            Debug.Log(GlobalData.Instance.isInvi);
            invi_remaining_time--;
            if (invi_remaining_time <= 0)
            {
                GlobalData.Instance.isInvi = false;
                EnableCollider();
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
            if (randomNumber < 0.3f)
            {
                GlobalData.Instance.world_speed = 1.3f;
                SceneManager.LoadScene("ice_world1");
            }
            else if (randomNumber < 0.6f)
            {
                SceneManager.LoadScene("small_world1");
            }
            else
            {
                GlobalData.Instance.world_speed = 0.7f;
                SceneManager.LoadScene("mud_world1");
            }
            //each time becomes 1.2 * original

        }
        if (level || !level) // shot term upgrade / down grade
        {
            if (collider.gameObject.tag == "star_upgrade")
            {
                //star_upgrade(collider, this);
                GlobalData.Instance.star_num++;
                ScoreManager.star_upgrade++;
                Destroy(collider.gameObject);


                GameObject player = GameObject.FindGameObjectWithTag("Player");
                //player object start_upgrade

                GameObject one_star = Instantiate(star);
                one_star.SetActive(true);
                one_star.transform.SetParent(player.transform);
                one_star.transform.localScale = new Vector3(.5f, GlobalData.Instance.star_size, 0.5f);

                controller player_comp = player.GetComponent<controller>();

                player_comp.stars.Add(one_star);
                float angle = 2f * Mathf.PI / (float)player_comp.stars.Count;
                for (int i = -1; ++i < player_comp.stars.Count;)
                {
                    player_comp.stars[i].transform.position = player.transform.position + new Vector3(Mathf.Cos(angle * i), 0, Mathf.Sin(angle * i));
                }

                // clone

                foreach (GameObject cloned_cube in GlobalData.Instance.cloned_list)
                {
                    GameObject cloned_one_star = Instantiate(star);
                    cloned_one_star.SetActive(true);
                    cloned_one_star.transform.SetParent(cloned_cube.transform);
                    cloned_one_star.transform.localScale = new Vector3(.5f, GlobalData.Instance.star_size, 0.5f);

                    controller clone_comp = cloned_cube.GetComponent<controller>();

                    clone_comp.stars.Add(cloned_one_star);
                    float cloned_angle = 2f * Mathf.PI / (float)clone_comp.stars.Count;
                    for (int i = -1; ++i < clone_comp.stars.Count;)
                    {
                        clone_comp.stars[i].transform.position = cloned_cube.transform.position + new Vector3(Mathf.Cos(angle * i), 0, Mathf.Sin(angle * i));
                    }
                }




                Debug.Log("star numb: " + GlobalData.Instance.star_num);
            }
            if (collider.gameObject.tag == "invisible")
            {
                Destroy(collider.gameObject);

                Physics.IgnoreLayerCollision(6, 7, true);

                // Player
                GameObject player = GameObject.FindGameObjectWithTag("Player");

                Color tempCol = player.GetComponent<Renderer>().material.color;
                print("player color original: " + tempCol.a);
                tempCol.a = .5f;

                player.GetComponent<Renderer>().material.color = tempCol;
                print("player color change: " + player.GetComponent<Renderer>().material.color.a);

                // Cloned cube
                foreach (GameObject cloned_cube in GlobalData.Instance.cloned_list)
                {
                    Color cloned_tempCol = cloned_cube.GetComponent<Renderer>().material.color;
                    print("clone color original: " + tempCol.a);
                    cloned_tempCol.a = .5f;
                    cloned_cube.GetComponent<Renderer>().material.color = cloned_tempCol;
                    print("clone color change: " + cloned_cube.GetComponent<Renderer>().material.color.a);
                }


                invi_remaining_time = 100;
                // Invoke ("EnableCollider", 5f);
                ScoreManager.invisible++;
                // GlobalData.Instance.ate++;
            }

        }
        if (level || GlobalData.Instance.ate < GlobalData.Instance.update_max_limit) // long term upgrade
        {
            if (collider.gameObject.tag == "bigger")
            {
                //each time becomes 1.2 * original
                Destroy(collider.gameObject);
                //transform.localScale = transform.localScale * 1.2f;
                ScoreManager.biggerCube++;
                GlobalData.Instance.ate++;


                GameObject player = GameObject.FindGameObjectWithTag("Player");

                player.transform.localScale = GlobalData.Instance.player_localScale * 1.2f;
                GlobalData.Instance.player_localScale = player.transform.localScale;

                //cloned cubes
                int size = GlobalData.Instance.cloned_list.Count;
                for (int i = 0; i < size; i++)
                {
                    GlobalData.Instance.cloned_list[i].transform.localScale = GlobalData.Instance.player_localScale * 0.5f;
                }
            }
            if (collider.gameObject.tag == "smaller")
            {
                //each time becomes 0.8 * original
                Destroy(collider.gameObject);
                //transform.localScale = transform.localScale * 0.8f;
                ScoreManager.smallerCube++;
                GlobalData.Instance.ate++;



                GameObject player = GameObject.FindGameObjectWithTag("Player");
                player.transform.localScale = GlobalData.Instance.player_localScale * 0.8f;
                GlobalData.Instance.player_localScale = player.transform.localScale;
                //cloned cubes
                int size = GlobalData.Instance.cloned_list.Count;
                for (int i = 0; i < size; i++)
                {
                    GlobalData.Instance.cloned_list[i].transform.localScale = GlobalData.Instance.player_localScale * 0.5f;
                }
            }
            if (collider.gameObject.tag == "faster")
            {
                // originally rotate at 30 degree/sec
                Destroy(collider.gameObject);
                GlobalData.Instance.starRotateSpeed *= 1.5f;
                ScoreManager.faster++;
                GlobalData.Instance.ate++;

                // No need for cloned cubes due to only use data from Global Data
            }
            if (collider.gameObject.tag == "longger")
            {
                //each time becomes 0.8 * original
                Destroy(collider.gameObject);
                GlobalData.Instance.star_size += 0.2f;

                /*
                foreach (GameObject one_star in stars)
                {
                    one_star.transform.localScale = new Vector3(0.5f, GlobalData.Instance.star_size, 0.5f);
                }
                */

                // player
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                foreach (GameObject one_star in player.GetComponent<controller>().stars)
                {
                    one_star.transform.localScale = new Vector3(0.5f, GlobalData.Instance.star_size, 0.5f);
                }


                //cloned cube
                foreach (GameObject cloned_cube in GlobalData.Instance.cloned_list)
                {
                    foreach (GameObject cloned_star in cloned_cube.GetComponent<controller>().stars)
                    {
                        cloned_star.transform.localScale = new Vector3(0.25f, GlobalData.Instance.star_size * 0.5f, 0.25f);
                    }
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
                //no setting for cloned clube due to only using Global Data
            }

            if (collider.gameObject.tag == "move_forward")
            {
                Destroy(collider.gameObject);
                GlobalData.Instance.move_forward = true;
                GlobalData.Instance.ate++;

                //cloned cubes
            }
            if (collider.gameObject.tag == "fps")
            {
                Destroy(collider.gameObject);
                fps_mode = !fps_mode;
                if (!fps_mode)
                {
                    fps_mode_lock = false;
                }
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
            if (ateText != null)
            {
                ateText.text = "ate:" + GlobalData.Instance.ate.ToString();
            }
        }

        //Clone
        if (collider.gameObject.tag == "clone")
        {
            Destroy(collider.gameObject);

            GameObject player = GameObject.FindGameObjectWithTag("Player");
            //if ()

            GameObject clone = Instantiate(player);
            Debug.Log("clone once");
            clone.SetActive(true);

            clone.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

            float player_x_pos = player.transform.position.x;
            float cloned_x = 0f;

            do
            {
                cloned_x = Random.Range(-4.5f, 4.5f);
                print("clone_x: " + cloned_x);
            } while ((cloned_x <= (player_x_pos + 0.5f)) && (cloned_x >= (player_x_pos - 0.5f)));

            if (this_Level_name == "Level_4_0" && GlobalData.Instance.cloned_list.Count == 0)
            {
                clone.transform.position = new Vector3(clone.transform.position.x - 2f, 4.0f, Random.Range(clone.transform.position.z, clone.transform.position.z + 2f));
            }
            else
            {
                clone.transform.position = new Vector3(cloned_x, 4.0f, clone.transform.position.z);
            }
            

            //clone.transform.rotation = Quaternion.identity;
            clone.tag = "cloned_cube";
            GlobalData.Instance.cloned_list.Add(clone);


            GameObject[] cloned_list = GameObject.FindGameObjectsWithTag("cloned_cube");
            Debug.Log("clone list size: " + cloned_list.Length + "  , cube list Global: " + GlobalData.Instance.cloned_list.Count);

        }
        //cherry
        if (collider.gameObject.tag == "cherry")
        {
            int hp = GlobalData.Instance.cube_health;
            if (hp >= GlobalData.Instance.hearts.Count)
            {
                GameObject heart1 = Instantiate(heart);
                heart1.SetActive(true);
                GlobalData.Instance.hearts.Add(heart1);
                heart1.transform.SetParent(HealthUi.transform);
                heart1.transform.position = new Vector3(50 + 55 * hp, 50f, 0f);
            }
            else
                GlobalData.Instance.hearts[hp].SetActive(true);
            GlobalData.Instance.cube_health += 1;
            Destroy(collider.gameObject);
        }

    }
    private void EnableCollider()
    {
        Color tempCol = GetComponent<Renderer>().material.color;
        tempCol.a = 1f;
        GetComponent<Renderer>().material.color = tempCol;
        Physics.IgnoreLayerCollision(6, 7, false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //gameObject.GetComponent<Renderer>().material.color = new Color(Mathf.Clamp(1 - GlobalData.Instance.cube_health/100f, 0, 1), Mathf.Clamp(GlobalData.Instance.cube_health / 100f, 0, 1), 0, 0.5f);

        if (collision.gameObject.tag == "Plane")
        {
            jump_numb = 2;
        }
    }

    private void TriggerDizzness()
    {
        if (lastKey == 1 && Input.GetKey(KeyCode.LeftArrow))
        {
            lastKey = 0;
            GlobalData.Instance.numNeedHit -= 1;
        }
        else if (lastKey == 0 && Input.GetKey(KeyCode.RightArrow))
        {
            lastKey = 1;
            GlobalData.Instance.numNeedHit -= 1;
        }
        // check if it can recover
        if (GlobalData.Instance.numNeedHit <= 0)
        {
            Canvas.SetActive(false);
            GlobalData.Instance.dizzy = false;
            GlobalData.Instance.numNeedHit = 0;
        }
        else
        {
            // set the canvas
            GameObject background = Canvas.GetComponent<Transform>().Find("Background").gameObject;
            GameObject dizzy = Canvas.GetComponent<Transform>().Find("Dizzy").gameObject;
            Canvas.SetActive(true);
            background.SetActive(false);
            dizzy.SetActive(true);
            float rate = (1 - (float)GlobalData.Instance.numNeedHit / (float)GlobalData.Instance.numTotalHit) * 100;
            TMP_Text progress = Canvas.GetComponent<Transform>().Find("Dizzy").GetComponent<Transform>().Find("Progress").GetComponent<TMP_Text>();
            progress.text = string.Format("Recover {0:0}%", rate); // $"Recover {rate.1f}%";
            print(GlobalData.Instance.numNeedHit);
        }
    }

    private void MoveController()
    {
        Canvas.SetActive(false);
        GlobalData.Instance.dizzy = false;
        GlobalData.Instance.numNeedHit = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            lastKey = 0;
            transform.position = transform.position + new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            lastKey = 1;
            transform.position = transform.position + new Vector3(speed, 0, 0);
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
    // }
    // }
}
