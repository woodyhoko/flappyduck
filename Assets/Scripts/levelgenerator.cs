using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerator : MonoBehaviour
{
    public GameObject player;
    public GameObject bigger;
    public float bigger_chance;
    public GameObject smaller;
    public float smaller_chance;
    public GameObject star_upgrade;
    public float star_upgrade_chance;
    public GameObject longger;
    public float longger_chance;
    public GameObject faster;
    public float faster_chance;
    public GameObject shooter;
    public float shooter_chance;
    public GameObject pipe;
    public float pipe_chance;
    public GameObject movingpipe;
    public float movingpipe_chance;
    public GameObject rock;
    public float rock_chance;
    public GameObject wall;
    public float wall_chance;
    public GameObject invisible;
    public float invisible_chance;
    public GameObject move_forward;
    public float move_forward_chance;
    public GameObject portal;
    public float portal_chance;
    public GameObject water;
    public float water_chance;
    public GameObject fps;
    public float fps_chance;
    public GameObject clone;
    public float clone_chance;
    public GameObject wall2;


    //public GameObject lightNum = 0;
    //public GameObject light1Limit = 2;
    public GameObject light1;
    public GameObject light2;
    public GameObject lightWhite;
    public GameObject lightWhite2;
    //public GameObject lightChance = 0.02;
    //public GameObject text;
    public float speed = -15f;
    // public GameObject movingHori;
    public GameObject heart;
    public GameObject HealthUi;
    public GameObject cherry;
    private int difficulty = 0;
    public int intervalTime = 0;
    //public GameObject player; 
    //public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        speed = GlobalData.Instance.world_speed * speed;
        Physics.IgnoreLayerCollision(6, 10, true);
        // GameObject ppipe = (GameObject)Instantiate (pipe);
        // // var rotation = new Quaternion();
        // // rotation.eulerAngles = new Vector3(54.5f, 0, 0);
        // ppipe.transform.rotation = Quaternion.identity;
        // ppipe.transform.position = new Vector3(0, 1, 20);
        // Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
        // m_Rigidbody.velocity = new Vector3(0,0,-15f);
        Debug.Log(GlobalData.Instance.cube_health);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (intervalTime > 0)
        {
            intervalTime--;
            Debug.Log(intervalTime);
        }
        else
        {    
            float randomNumber = Random.Range(0, 1f);
            float modNumber = Random.Range(0, 1f);
            if (modNumber < 0.01f)
            {
                int lightNum = GlobalData.Instance.lightNum;
                if (modNumber < 0.002f)
                {
                    GameObject w1 = (GameObject)Instantiate(wall2);
                    GameObject w2 = (GameObject)Instantiate(wall2);
                    //ppipe.GetComponent<pipe>().SetHealth(100f);
                    GameObject c = (GameObject)Instantiate(cherry);
                    w1.transform.position = new Vector3(0, 3.5f, 36);
                    w2.transform.position = new Vector3(0, 0.4f, 36);
                    c.transform.position = new Vector3(Random.Range(-4f, 4f), 1.5f, 36);
                    Rigidbody m_Rigidbody = w1.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    Rigidbody m_Rigidbody2 = w2.GetComponent<Rigidbody>();
                    m_Rigidbody2.velocity = new Vector3(0, 0, speed);
                    Rigidbody m_Rigidbody3 = c.GetComponent<Rigidbody>();
                    m_Rigidbody3.velocity = new Vector3(0, 0, speed);
                    intervalTime = 50;
                }
                else if (modNumber < 0.004f)
                {
                    GameObject w1 = (GameObject)Instantiate(wall2);
                    GameObject w2 = (GameObject)Instantiate(wall2);
                    //ppipe.GetComponent<pipe>().SetHealth(100f);

                    w1.transform.localScale = new Vector3(4f, 3, 0.5f);
                    w2.transform.localScale = new Vector3(4f, 3, 0.5f);
                    w1.transform.position = new Vector3(-3f, 0.8f, 36);
                    w2.transform.position = new Vector3(3f, 0.8f, 36);
                    Rigidbody m_Rigidbody = w1.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    Rigidbody m_Rigidbody2 = w2.GetComponent<Rigidbody>();
                    m_Rigidbody2.velocity = new Vector3(0, 0, speed);
                    intervalTime = 50;
                }
                else if (lightNum <= 4 && modNumber < 0.006f)
                {
                    GameObject l;
                    GlobalData.Instance.lightNum += 2;
                    l = Instantiate(light1);
                    l.transform.position = new Vector3(-5, 0.2f, 36);
                    Rigidbody m_Rigidbody = l.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    l = Instantiate(light2);
                    l.transform.position = new Vector3(5, 0.2f, 36);
                    m_Rigidbody = l.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                }
                else if (lightNum <= 4 && modNumber < 0.008f)
                {
                    GameObject l;
                    GlobalData.Instance.lightNum += 2;
                    l = Instantiate(light1);
                    l.transform.position = new Vector3(-5, 0.2f, 36);
                    Rigidbody m_Rigidbody = l.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    l = Instantiate(light2);
                    l.transform.position = new Vector3(5, 0.2f, 36);
                    m_Rigidbody = l.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                }
                else if (lightNum == 0 && modNumber < 0.009f)
                {
                     GameObject l;
                     GlobalData.Instance.lightNum += 6;
                    l = Instantiate(lightWhite);
                     l.transform.position = new Vector3(-5, 0.2f, 36);
                     Rigidbody m_Rigidbody = l.GetComponent<Rigidbody>();
                     m_Rigidbody.velocity = new Vector3(0, 0, speed);

                     l = Instantiate(lightWhite);
                     l.transform.position = new Vector3(-5, 0.2f, 38);
                     m_Rigidbody = l.GetComponent<Rigidbody>();
                     m_Rigidbody.velocity = new Vector3(0, 0, speed);

                    l = Instantiate(lightWhite);
                    l.transform.position = new Vector3(-5, 0.2f, 40);
                    m_Rigidbody = l.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);


                    l = Instantiate(lightWhite2);
                    l.transform.position = new Vector3(5, 0.2f, 36);
                    m_Rigidbody = l.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);

                    l = Instantiate(lightWhite2);
                    l.transform.position = new Vector3(5, 0.2f, 38);
                    m_Rigidbody = l.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);

                    l = Instantiate(lightWhite2);
                    l.transform.position = new Vector3(5, 0.2f, 40);
                    m_Rigidbody = l.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                }
            }
            else
            {
                //level 1: 0.03
                if (Random.Range(0, 1f) < rock_chance)
                {
                    GameObject obj = (GameObject)Instantiate(rock);
                    obj.GetComponent<rock>().clone = true;
                    // obj.transform.SetParent(this.transform);
                    // obj.transform.position = new Vector3(Random.Range(-5.5f, 5.5f), 10, player.transform.position.z);
                    obj.transform.position = new Vector3(player.transform.position.x, 10, player.transform.position.z);
                    obj.transform.rotation = new Quaternion(Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f));
                }
                if (Random.Range(0, 1f) < pipe_chance + difficulty * 0.0001f)
                {
                    float wallRandom = Random.Range(0, 1f);
                    float heightRandom = Random.Range(0, 2f);
                    GameObject ppipe = (GameObject)Instantiate(pipe);
                    //ppipe.GetComponent<pipe>().SetHealth(100f);
                    ppipe.transform.localScale = new Vector3(0.7f +  wallRandom, 0.5f + heightRandom, 0.7f +  wallRandom);
                    ppipe.transform.rotation = Quaternion.identity;
                    ppipe.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
                    Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                }
                if (Random.Range(0, 1f) < water_chance)
                {
                    GameObject watero = (GameObject)Instantiate(water);
                    watero.transform.rotation = Quaternion.identity;
                    watero.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                    Rigidbody m_Rigidbody = watero.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                }
                if (Random.Range(0, 1f) < movingpipe_chance)
                {
                    float wallRandom = Random.Range(0, 1f);
                    float heightRandom = Random.Range(0, 2f);
                    GameObject mpipeo = (GameObject)Instantiate(movingpipe);
                    mpipeo.transform.localScale = new Vector3(0.5f + 2 * wallRandom, 0.8f + heightRandom, 0.3f + 2 * wallRandom);
                    mpipeo.transform.rotation = Quaternion.identity;
                    mpipeo.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                    Rigidbody m_Rigidbody = mpipeo.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                }
                if (Random.Range(0, 1f) < wall_chance)
                {
                    float WRandom = Random.Range(-1, 1f);
                    float HRandom = Random.Range(0, 2f);
                    GameObject ppipe = (GameObject)Instantiate(wall);
                    //ppipe.GetComponent<pipe>().SetHealth(100f);
                    //if (wallRandom > 0.5)
                    //{
                        ppipe.transform.localScale = new Vector3(3f + WRandom, 2+HRandom, 0.5f);
                        ppipe.transform.position = new Vector3(Random.Range(-4+WRandom, 4-WRandom), 1f, 36);
                    //}
                    //else
                    //{
                        ppipe.transform.position = new Vector3(Random.Range(-2, 2f), 0.8f, 36);
                    //}
                    ppipe.transform.rotation = Quaternion.identity;

                    Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                }
                // if (Random.Range(0, 1f) > randomNumber > 0.96f - difficulty * 0.0001f)
                // {
                //     float wallRandom = Random.Range(0, 1f);
                //     float heightRandom = Random.Range(0, 2f);
                //     if (randomNumber > 0.98f)
                //     {
                //         GameObject ppipe = (GameObject)Instantiate(pipe);
                //         //ppipe.GetComponent<pipe>().SetHealth(100f);
                //         ppipe.transform.localScale = new Vector3(0.7f + 2 * wallRandom, 0.5f + heightRandom, 0.7f + 2 * wallRandom);
                //         ppipe.transform.rotation = Quaternion.identity;
                //         ppipe.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
                //         Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                //         m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                //     }
                //     else if (randomNumber > 0.95f && randomNumber < 0.965f)
                //     {
                //         GameObject watero = (GameObject)Instantiate(water);
                //         watero.transform.rotation = Quaternion.identity;
                //         watero.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                //         Rigidbody m_Rigidbody = watero.GetComponent<Rigidbody>();
                //         m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                //     }
                //     /*else if (randomNumber>0.975f && randomNumber<0.98f)
                //     {
                //         Debug.Log("horizontal moving");
                //         GameObject movinghori = (GameObject)Instantiate(movingHori);
                //         movinghori.transform.rotation = Quaternion.identity;
                //         Rigidbody m_Rigidbody = movinghori.GetComponent<Rigidbody>();
                //         movinghori.transform.rotation = Quaternion.identity;
                //         movinghori.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                //         m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                //     }*/
                //     else if (randomNumber > 0.96f && randomNumber < 0.98f)
                //     {
                //         Debug.Log("Spawn moving pipe");
                //         GameObject mpipeo = (GameObject)Instantiate(movingpipe);
                //         mpipeo.transform.localScale = new Vector3(0.5f + 2 * wallRandom, 0.8f + heightRandom, 0.3f + 2 * wallRandom);
                //         mpipeo.transform.rotation = Quaternion.identity;
                //         mpipeo.transform.position = new Vector3(Random.Range(-5, 5f), .010f, 36);
                //         Rigidbody m_Rigidbody = mpipeo.GetComponent<Rigidbody>();
                //         m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                //     }
                //     else
                //     {
                //         GameObject ppipe = (GameObject)Instantiate(wall);
                //         //ppipe.GetComponent<pipe>().SetHealth(100f);
                //         if (wallRandom > 0.5)
                //         {
                //             ppipe.transform.localScale = new Vector3(2.5f, 2, 0.5f);
                //             ppipe.transform.position = new Vector3(Random.Range(-5, 5f), 1f, 36);
                //         }
                //         else
                //         {
                //             ppipe.transform.position = new Vector3(Random.Range(-2, 2f), 0.8f, 36);
                //         }
                //         ppipe.transform.rotation = Quaternion.identity;

                //         Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
                //         m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                //     }
                // }
                if (Random.Range(0, 1f) < bigger_chance)
                {
                    GameObject food;
                    food = Instantiate(bigger);
                    food.transform.rotation = Quaternion.identity;
                    food.transform.Rotate(0, 90, 0); // for showing icons in right view
                    food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

                    Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    difficulty++;
                }
                if (Random.Range(0, 1f) < smaller_chance)
                {
                    GameObject food;
                    food = Instantiate(smaller);
                    food.transform.rotation = Quaternion.identity;
                    food.transform.Rotate(0, 90, 0); // for showing icons in right view
                    food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

                    Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    difficulty++;
                }
                if (Random.Range(0, 1f) < faster_chance)
                {
                    GameObject food;
                    food = Instantiate(faster);
                    food.transform.rotation = Quaternion.identity;
                    food.transform.Rotate(0, 90, 0); // for showing icons in right view
                    food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

                    Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    difficulty++;
                }
                if (Random.Range(0, 1f) < longger_chance)
                {
                    GameObject food;
                    food = Instantiate(longger);
                    food.transform.rotation = Quaternion.identity;
                    food.transform.Rotate(0, 90, 0); // for showing icons in right view
                    food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

                    Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    difficulty++;
                }
                if (Random.Range(0, 1f) < shooter_chance)
                {
                    GameObject food;
                    food = Instantiate(shooter);
                    food.transform.rotation = Quaternion.identity;
                    food.transform.Rotate(0, 90, 0); // for showing icons in right view
                    food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

                    Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    difficulty++;
                }
                if (Random.Range(0, 1f) < invisible_chance)
                {
                    GameObject food;
                    food = Instantiate(invisible);
                    food.transform.rotation = Quaternion.identity;
                    food.transform.Rotate(0, 90, 0); // for showing icons in right view
                    food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

                    Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    difficulty++;
                }
                if (Random.Range(0, 1f) < star_upgrade_chance)
                {
                    GameObject food;
                    food = Instantiate(star_upgrade);
                    food.transform.rotation = Quaternion.identity;
                    food.transform.Rotate(0, 90, 0); // for showing icons in right view
                    food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

                    Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    difficulty++;
                }
                if (Random.Range(0, 1f) < move_forward_chance)
                {
                    GameObject food;
                    food = Instantiate(move_forward);
                    food.transform.rotation = Quaternion.identity;
                    food.transform.Rotate(0, 90, 0); // for showing icons in right view
                    food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

                    Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    difficulty++;
                }
                if (Random.Range(0, 1f) < portal_chance)
                {
                    GameObject p = (GameObject)Instantiate(portal);
                    p.transform.position = new Vector3(Random.Range(-4, 4f), 2, 36);
                    Rigidbody m_Rigidbody = p.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                }
                if (Random.Range(0, 1f) < fps_chance)
                {
                    GameObject food;
                    food = Instantiate(fps);
                    food.transform.rotation = Quaternion.identity;
                    food.transform.Rotate(0, 90, 0); // for showing icons in right view
                    food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

                    Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    difficulty++;
                }
                if (Random.Range(0, 1f) < clone_chance)
                {
                    GameObject food;
                    food = Instantiate(clone);
                    food.transform.rotation = Quaternion.identity;
                    food.transform.Rotate(0, 90, 0);
                    food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
                    Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                    m_Rigidbody.velocity = new Vector3(0, 0, speed);
                    difficulty++;
                }

                // else if (randomNumber < 0.016f)
                // {
                //     GameObject food;
                //     if (randomNumber < 0.0020f)
                //     {
                //         food = Instantiate(bigger);
                //     }
                //     else if ((randomNumber < 0.002f) && (randomNumber < 0.004f))
                //         food = Instantiate(smaller);
                //     else if ((randomNumber < 0.004f) && (randomNumber < 0.006f))
                //         food = Instantiate(faster);
                //     else if ((randomNumber < 0.006f) && (randomNumber < 0.008f))
                //         food = Instantiate(longger);
                //     else if ((randomNumber < 0.008f) && (randomNumber < 0.01f))
                //         food = Instantiate(shooter);
                //     //else if (randomNumber < 0.015f)
                //     else if ((randomNumber < 0.01f) && (randomNumber < 0.012f))
                //         food = Instantiate(invisible);
                //     else if ((randomNumber < 0.012f) && (randomNumber < 0.014f))
                //         food = Instantiate(star_upgrade);
                //     else
                //         food = Instantiate(move_forward);
                //     food.transform.rotation = Quaternion.identity;
                //     food.transform.Rotate(0, 90, 0); // for showing icons in right view
                //     food.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);

                //     Rigidbody m_Rigidbody = food.GetComponent<Rigidbody>();
                //     m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                //     difficulty++;
                // }
                // else if (randomNumber < 0.017f)
                // {
                //     GameObject p = (GameObject)Instantiate(portal);
                //     p.transform.position = new Vector3(Random.Range(-4, 4f), 2, 36);
                //     Rigidbody m_Rigidbody = p.GetComponent<Rigidbody>();
                //     m_Rigidbody.velocity = new Vector3(0, 0, -15f);
                // }
            }
        }
    }
}

