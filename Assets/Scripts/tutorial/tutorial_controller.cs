using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class tutorial_controller : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public Material duckMaterial;
    public GameObject star;
    public GameObject bullet;
    public float starRotateSpeed;

    private bool shoot = false;
    private int shoot_freq = 50;
    private int shoot_timestep = 0;
    private float move_forward_limit = 4.0f;

    public int numTotalHit = 3;
    public int numNeedHit = 3;

    private bool jump = false;
    private int jump_numb = 0;
    private float jump_height = 5.0f;
    private int invi_remaining_time = 30;
    public float move_speed = 0.08f;

    // Gravity, reversed gravity, move forward
    public static bool larger_gravity = false;
    public static bool reversed_gravity = false;
    public static bool move_forward = false;

    private int update_max_limit = 6;
    private int ate = 0;
    public TMP_Text ateText;
    public TMP_Text limitText;
    private bool dizzy = false;
    public GameObject heart;
    public GameObject HealthUi;
    public int cube_health = 5;
    public List<GameObject> hearts = new List<GameObject>();
    // Start is called before the first frame update
    private int lastKey = 0; // 0 for left and 1 for right
    public GameObject Canvas;
    void Start()
    {

        m_Rigidbody = GetComponent<Rigidbody>();
        larger_gravity = false;
        reversed_gravity = false;
        move_forward = false;
        limitText.text = "eat limitation: " + update_max_limit;
        for (int heart_now = 0; heart_now < cube_health; heart_now++)
        {
            GameObject heart1 = Instantiate(heart);
            heart1.SetActive(true);
            hearts.Add(heart1);
            heart1.transform.SetParent(HealthUi.transform);
            heart1.transform.position = new Vector3(50 + 55 * heart_now, 50f, 0f);
            //Debug.Log(GlobalData.Instance.cube_health);
        }
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
        // movement
        if (!dizzy)
        {
            MoveController();
        }
        else
        {
            TriggerDizzness();
        }
        if (transform.position.y < -10 || transform.position.z < -10 || transform.position.x < -6 || transform.position.x > 6)
        {
            SceneManager.LoadScene("gameover");
        }
            star.transform.RotateAround(transform.position, Vector3.up, starRotateSpeed);
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
            if (transform.position.z < move_forward_limit)
            {
                m_Rigidbody.velocity = new Vector3(0, 0, m_Rigidbody.velocity.z + 3.0f);
            }

            Debug.Log("z: " + transform.position.z);

            //m_Rigidbody.velocity = new Vector3(0, 0, m_Rigidbody.velocity.z + 2.0f);
            move_forward = false;
        }




        if(shoot){
           // print("check");
           shoot_timestep ++;
           if (shoot_timestep%shoot_freq == 0){
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

        if (collider.gameObject.tag == "pipe")
        {
            cube_health--;
           hearts[cube_health].SetActive(false);

            if (cube_health <= 0f)
            {
                ScoreManager.killedByWater = true;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByBound = false;
                FindObjectOfType<GameManager>().EndGame();
            }
            Debug.Log("get hit by pipe");
        }
        if (collider.gameObject.tag == "bullet")
        {
            Destroy(collider.gameObject);
            cube_health--;
            hearts[cube_health].SetActive(false);

            if (cube_health <= 0f)
            {
                ScoreManager.killedByWater = true;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByBound = false;
                FindObjectOfType<GameManager>().EndGame();
            }
            Debug.Log("get hit by pipe");
        }
        if (ate < update_max_limit)
        {
            if (collider.gameObject.tag == "bigger")
            {
                //tutorial : each time becomes 1.2 * original
                Destroy(collider.gameObject);
                transform.localScale = transform.localScale * 1.2f;
                ScoreManager.biggerCube++;
                ate++;
            }
            if (collider.gameObject.tag == "smaller")
            {
                //tutorial : each time becomes 0.8 * original
                Destroy(collider.gameObject);
                transform.localScale = transform.localScale * 0.9f;
                ScoreManager.smallerCube++;
                ate++;
            }
            if (collider.gameObject.tag == "faster")
            {
                // originally rotate at 30 degree/sec

                Destroy(collider.gameObject);
                starRotateSpeed *= 1.5f;
                ScoreManager.faster++;
                ate++;
            }
            if (collider.gameObject.tag == "longger")
            {
                //each time becomes 0.8 * original
                Destroy(collider.gameObject);
                star.transform.localScale += new Vector3(0, 0.2f, 0);
                ScoreManager.longer++;
                ate++;
            }
            if (collider.gameObject.tag == "shooter")
            {
                Destroy(collider.gameObject);
                shoot = true;
                if (shoot_freq >= 5)
                {
                    shoot_freq *= 4;
                    shoot_freq /= 5;
                }
                ScoreManager.shooter++;
                ate++;
            }

            if (collider.gameObject.tag == "move_forward")
            {
                Destroy(collider.gameObject);
                move_forward = true;
                ate++;
            }

            if (collider.gameObject.tag == "gravity")
            {
                Destroy(collider.gameObject);
                reversed_gravity = !reversed_gravity;
                ate++;
            }

            if (collider.gameObject.tag == "gravity_size")
            {
                Destroy(collider.gameObject);
                larger_gravity = !larger_gravity;
                ate++;
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
                ate++;
            }
            ateText.text = "ate:" + ate.ToString();
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
        if (collision.gameObject.tag == "Rock")
        {
            dizzy = true;
            numNeedHit = numTotalHit;
            TriggerDizzness();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Plane")
        {
            jump_numb = 2;

        }
        if (collision.gameObject.tag == "water")
        {
            cube_health--;
            hearts[cube_health].SetActive(false);

            if (cube_health <= 0f)
            {
                ScoreManager.killedByWater = true;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByBound = false;
                FindObjectOfType<GameManager>().EndGame();
            }
            Destroy(collision.gameObject);
            //Debug.Log("get hit by pipe");
        }
    }
    private void TriggerDizzness()
    {
        if (lastKey == 1 && Input.GetKey(KeyCode.LeftArrow))
        {
            lastKey = 0;
            numNeedHit -= 1;
        }
        else if (lastKey == 0 && Input.GetKey(KeyCode.RightArrow))
        {
            lastKey = 1;
            numNeedHit -= 1;
        }

        // check if it can recover
        if (numNeedHit <= 0)
        {
            Canvas.SetActive(false);
            dizzy = false;
            numNeedHit = 0;
        }
        else
        {
            // set the canvas
            GameObject background = Canvas.GetComponent<Transform>().Find("Background").gameObject;
            GameObject dizzy = Canvas.GetComponent<Transform>().Find("Dizzy").gameObject;
            Canvas.SetActive(true);
            background.SetActive(false);
            dizzy.SetActive(true);

            float rate = (1 - (float)numNeedHit / (float)numTotalHit) * 100;
            TMP_Text progress = Canvas.GetComponent<Transform>().Find("Dizzy").GetComponent<Transform>().Find("Progress").GetComponent<TMP_Text>();
            progress.text = string.Format("Recover {0:0}%", rate); // $"Recover {rate.1f}%";
            //print(numNeedHit);
        }
    }

    private void MoveController()
    {
        Canvas.SetActive(false);
        dizzy = false;
        numNeedHit = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            lastKey = 0;
            transform.position = transform.position + new Vector3(-move_speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            lastKey = 1;
            transform.position = transform.position + new Vector3(move_speed, 0, 0);
        }
    }


}
