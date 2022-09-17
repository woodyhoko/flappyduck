using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public GameObject star;
    public GameObject bullet;
    public float starRotateSpeed;

    private bool shoot = false;
    private int shoot_freq = 10;
    private int shoot_timestep = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if(Input.GetKeyDown(KeyCode.A)){
        //     transform.Position(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
        // }
        star.transform.RotateAround(transform.position, Vector3.up, starRotateSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space)){
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
            print("check");
           shoot_timestep ++;
           if (shoot_timestep%shoot_freq == 0){
                GameObject bul;
                bul = Instantiate(bullet);
                bul.transform.position = transform.position + new Vector3(0, 0, 1f);
                Rigidbody m_Rigidbody = bul.GetComponent<Rigidbody>();
                m_Rigidbody.velocity = new Vector3(0, 0, 10f);
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
            
        }
        if (collider.gameObject.tag == "smaller")
        {
            //each time becomes 0.8 * original
            transform.localScale = transform.localScale * 0.8f;
            Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag == "faster")
        {
            // originally rotate at 30 degree/sec

            starRotateSpeed += 20;
            Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag == "longger")
        {
            //each time becomes 0.8 * original
            star.transform.localScale += new Vector3(0,0.2f,0);
            Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag == "shooter")
        {
            shoot = true;
            shoot_freq/=2 ;
        }

        if (collider.gameObject.tag == "invisible")
        {
            Destroy(collider.gameObject);
            Physics.IgnoreLayerCollision(6, 7, true);
            Invoke ("EnableCollider", 5f);
        }
        void  EnableCollider () {
            Physics.IgnoreLayerCollision(6, 7, false);
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
