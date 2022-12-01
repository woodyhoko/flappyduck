using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water31 : MonoBehaviour
{
    // Rigidbody rb;
    public bool clone = false;
    public TMPro.TextMeshProUGUI score_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "cloned_cube")
        {
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "Player" && collider.gameObject.tag != "star")
        {
            GlobalData.Instance.cube_health -= 1;
            int hp = GlobalData.Instance.cube_health;
            if (hp > 0)
                GlobalData.Instance.hearts[hp].SetActive(false);
            if (hp <= 0f)
            {
                ScoreManager.killedByWater = true;
                ScoreManager.killedByPipe = false;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByBound = false;
            }
            Destroy(this.gameObject);
        }
    }

}