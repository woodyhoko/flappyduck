using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public Material duckMaterial;
    public GameObject star;
    public GameObject bullet;
    public float starRotateSpeed;

    private bool shoot = false;
    private int shoot_freq = 150;
    private int shoot_timestep = 0;
    private float move_forward_limit = 4.0f;

    private bool jump = false;
    private int jump_numb = 0;
    private float jump_height = 5.0f;
    private int invi_remaining_time = 30;

    // Gravity, reversed gravity, move forward
    public static bool larger_gravity = false;
    public static bool reversed_gravity = false;
    public static bool move_forward = false;


    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        larger_gravity = false;
        reversed_gravity = false;
        move_forward = false;
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
        

        

        

    }


    void FixedUpdate()
    {
        // if(Input.GetKeyDown(KeyCode.A)){
        //     transform.Position(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
        // }
        star.transform.RotateAround(transform.position, Vector3.up, starRotateSpeed);
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
            if (transform.position.z < move_forward_limit)
            {
                m_Rigidbody.velocity = new Vector3(0, 0, m_Rigidbody.velocity.z + 3.0f);
            }

            Debug.Log("z: " + transform.position.z);

            //m_Rigidbody.velocity = new Vector3(0, 0, m_Rigidbody.velocity.z + 2.0f);
            move_forward = false;
        }




        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position = transform.position + new Vector3(-0.08f, 0 ,0); 
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position = transform.position + new Vector3(0.08f, 0 ,0);    
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
        if (collider.gameObject.tag == "faster")
        {
            // originally rotate at 30 degree/sec

            Destroy(collider.gameObject);
            starRotateSpeed *= 1.5f;
            ScoreManager.faster++;
        }
        if (collider.gameObject.tag == "longger")
        {
            //each time becomes 0.8 * original
            Destroy(collider.gameObject);
            star.transform.localScale += new Vector3(0,0.2f,0);
            ScoreManager.longer++;
        }
        if (collider.gameObject.tag == "shooter")
        {
            Destroy(collider.gameObject);
            shoot = true;
            if(shoot_freq >= 5){
                shoot_freq*=4;
                shoot_freq/=5;
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
            // Invoke ("EnableCollider", 5f);
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
