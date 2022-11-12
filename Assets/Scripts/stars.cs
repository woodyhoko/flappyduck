using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stars : MonoBehaviour
{
    public GameObject strmid10;
    public GameObject strrt10;
    public GameObject strlt10;
    public GameObject strmid20;
    public GameObject strrt20;
    public GameObject strlt20;
    public GameObject strmid21;
    public GameObject strrt21;
    public GameObject strlt21;
    public GameObject strmid22;
    public GameObject strrt22;
    public GameObject strlt22;
    public GameObject strmid23;
    public GameObject strrt23;
    public GameObject strlt23;
    public GameObject strmid24;
    public GameObject strrt24;
    public GameObject strlt24;
    public GameObject strmid30;
    public GameObject strrt30;
    public GameObject strlt30;
    public GameObject strmid31;
    public GameObject strrt31;
    public GameObject strlt31;
    public GameObject strmid40;
    public GameObject strrt40;
    public GameObject strlt40;

    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("STATS OF level 1 AFTERRR");
        Debug.Log(ScoreManager.cube_health);
       
        Debug.Log(ScoreManager.level1Passed);
        if (ScoreManager.level31 && ScoreManager.level31Passed)
        {
            if (ScoreManager.cube_health == 3)
            {
                strmid31.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strrt31.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt31.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  == 2)
            {
                strmid31.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt31.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  == 1)
            {
                strlt31.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }


        }
        else if (ScoreManager.level30 && ScoreManager.level30Passed)
        {
            Debug.Log("passed");
              if (ScoreManager.cube_health  == 3)
            {
                strmid30.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strrt30.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt30.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else   if (ScoreManager.cube_health  == 2)
            {
                strmid30.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt30.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  == 1)
            {
                strlt30.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
        }
        else if (ScoreManager.level21 && ScoreManager.level21Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.cube_health  == 3)
            {
                strmid21.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strrt21.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt21.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  == 2)
            {
                strmid21.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt21.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  == 1)
            {
                strlt21.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
        }
        else if (ScoreManager.level20 && ScoreManager.level20Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.cube_health  == 3)
            {
                strmid20.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strrt20.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt20.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  == 2)
            {
                strmid20.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt20.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  == 1)
            {
                strlt20.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
        }
        else if (ScoreManager.level22 && ScoreManager.level22Passed)
        {
            Debug.Log("passed");
           if (ScoreManager.cube_health  == 3)
            {
                strmid22.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strrt22.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt22.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  == 2)
            {
                strmid22.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt22.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
           else if (ScoreManager.cube_health  == 1)
            {
                strlt22.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
        }
        else if (ScoreManager.level23 && ScoreManager.level23Passed)
        {
            Debug.Log("passed");
           if (ScoreManager.cube_health  == 3)
            {
                strmid23.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strrt23.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt23.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  ==2 )
            {
                strmid23.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt23.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
           else if (ScoreManager.cube_health  == 1)
            {
                strlt23.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
        }
        else if (ScoreManager.level24 && ScoreManager.level24Passed)
        {
            Debug.Log("passed");
           if (ScoreManager.cube_health  == 3)
            {
                strmid24.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strrt24.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt24.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  ==2 )
            {
                strmid24.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt24.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
           else if (ScoreManager.cube_health  == 1)
            {
                strlt24.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
        }
        else if (ScoreManager.level1 && ScoreManager.level1Passed)
        {
            Debug.Log("passed level 1");
           if (ScoreManager.cube_health  == 3)
            {
                strmid10.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strrt10.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt10.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  ==2 )
            {
                strmid10.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt10.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
           else if (ScoreManager.cube_health  == 1)
            {
                strlt10.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
        }
        else if (ScoreManager.level40 && ScoreManager.level40Passed)
        {
            Debug.Log("passed");
           if (ScoreManager.cube_health  == 3)
            {
                strmid40.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strrt40.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt40.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
            else if (ScoreManager.cube_health  == 2)
            {
                strmid40.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
                strlt40.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
           else if (ScoreManager.cube_health  == 1)
            {
                strlt40.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
            }
        }


    }


    // Update is called once per frame
    void FixedUpdate()
    {



    }
}