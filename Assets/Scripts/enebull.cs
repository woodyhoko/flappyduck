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
        
        if (collider.gameObject.tag == "Player"&& GlobalData.Instance.isInvi==false)
        {
            Debug.Log(GlobalData.Instance.isInvi);
            Destroy(gameObject);
            if (GlobalData.Instance.cube_health > 0f)
            {
                Debug.Log(GlobalData.Instance.cube_health);
                GlobalData.Instance.cube_health -= 1;
                GlobalData.Instance.hearts[GlobalData.Instance.cube_health].SetActive(false);
               
                Debug.Log("get hit by shooting enemy");
                
            }
            
        }
       

        else if (collider.gameObject.tag == "pipe")
        { Debug.Log("--------------- ene bullet hit wall!!------------");
            Destroy(gameObject);
        }
    }
}
