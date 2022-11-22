using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1mid : MonoBehaviour
{
    public GameObject player;
    public GameObject rock;
    private int timer;
    public bool haveRock = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if (haveRock && (timer == 10 || timer == 500 || timer == 810)) {
            generateRock();
        }
    }

    private void generateRock() {
        GameObject obj = (GameObject)Instantiate(rock);
        obj.GetComponent<rock>().clone = true;
        obj.transform.position = new Vector3(player.transform.position.x, 10, player.transform.position.z);
        obj.transform.rotation = new Quaternion(Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f), Random.Range(-5.5f, 5.5f));
    }
}
