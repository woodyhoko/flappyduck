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

    private bool jump = false;
    private int invi_remaining_time = 30;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)){
            jump = true;
        }
    }
    void FixedUpdate()
    {
        // if(Input.GetKeyDown(KeyCode.A)){
        //     transform.Position(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
        // }
         star.transform.RotateAround(transform.position, Vector3.up, starRotateSpeed * Time.deltaTime);
        //star.transform.RotateAround(transform.position, transform.eulerAngles, starRotateSpeed);
        if (jump){
            jump = false;
            // transform.position = transform.position + new Vector3(0, 1.5f, 0);
            m_Rigidbody.velocity = new Vector3(0,5.0f,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
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
            starRotateSpeed += 5;
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
