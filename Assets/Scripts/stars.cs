using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stars : MonoBehaviour
{
    public GameObject strmid10;
    public GameObject strmid11;
    public GameObject strmid20;
    public GameObject strmid21;
    public GameObject strmid22;
    public GameObject strmid23;
    public GameObject strmid24;
    public GameObject strmid30;
    public GameObject strmid31;
    public GameObject strmid40;
    public GameObject strmid41;
  public GameObject strmid42;

    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("STATS OF level 1 AFTERRR");
        Debug.Log(ScoreManager.cube_health);
        Debug.Log(ScoreManager.level30);
        Debug.Log(ScoreManager.level30Passed);
        if (ScoreManager.level31Passed)
        {
            if (ScoreManager.cube_health == ScoreManager.cube_health_org)
            {
                strmid31.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            }


        }
        else if (ScoreManager.level30Passed)
        {
            Debug.Log("passed");
              if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid30.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
            }
          
        }
        else if ( ScoreManager.level21Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid21.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            }
        }
        else if ( ScoreManager.level20Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid20.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                
            }
        }
        else if ( ScoreManager.level22Passed)
        {
            Debug.Log("passed");
           if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid22.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
            }
        }
        else if ( ScoreManager.level23Passed)
        {
            Debug.Log("passed");
           if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid23.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
            }
        }
        else if ( ScoreManager.level24Passed)
        {
            Debug.Log("passed");
           if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid24.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
              
            }
        }
        else if ( ScoreManager.level10Passed)
        {
            Debug.Log("passed level 1.0");
           if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid10.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
              
            }
        }
        else if ( ScoreManager.level40Passed)
        {
            Debug.Log("passed");
           if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid40.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
              
            }
        }
        else if ( ScoreManager.level41Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid41.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                
            }
        }
        else if ( ScoreManager.level42Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid42.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
            }
        } else if ( ScoreManager.level11Passed)
        {
            Debug.Log(" lev 1.1 passed");
            Debug.Log(ScoreManager.cube_health_org);
            Debug.Log(ScoreManager.cube_health);
            if (ScoreManager.cube_health  == ScoreManager.cube_health_org)
            {
                strmid11.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                Debug.Log(strmid11.GetComponent<Image>().color);
               
            }
        }


    }


    // Update is called once per frame
    void FixedUpdate()
    {



    }
}