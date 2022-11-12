using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enebull : MonoBehaviour
{
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
        Debug.Log("---------------bullet triggger!!------------");
        if (collider.gameObject.tag == "Player")
        {
            GlobalData.Instance.cube_health -= 1;
            GlobalData.Instance.hearts[GlobalData.Instance.cube_health].SetActive(false);
            if (GlobalData.Instance.cube_health <= 0f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
            Debug.Log("get hit by bullet of shooting enemy");
        }
    }
}
