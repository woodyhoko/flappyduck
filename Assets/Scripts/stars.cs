using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stars : MonoBehaviour
{
    public GameObject strmid10;
    public GameObject strmid11;
    
    public GameObject strmid12;
    public GameObject strmid13;
    public GameObject strmid20;
    public GameObject strmid21;
    public GameObject strmid22;
    public GameObject strmid23;
    public GameObject strmid24;
    public GameObject strmid25;
    public GameObject strmid30;
    public GameObject strmid31;
    public GameObject strmid32;
    public GameObject strmid33;
    public GameObject strmid34;
    public GameObject strmid40;
    public GameObject strmid41;
  public GameObject strmid42;
  public GameObject strmid43;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ScoreManager.level20Passed);
        Debug.Log(ScoreManager.level21Passed);
        Debug.Log(ScoreManager.lvl20_perfect);
        Debug.Log(ScoreManager.lvl21_perfect);
        if (ScoreManager.level31Passed)
        {
            if (ScoreManager.lvl31_perfect == true)
            {
                strmid31.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            }


        }
         if (ScoreManager.level30Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.lvl30_perfect == true)
            {
                strmid30.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
            }
          
        }
         if ( ScoreManager.level20Passed)
         {
             Debug.Log(ScoreManager.lvl20_perfect);
             if (ScoreManager.lvl20_perfect == true)
             {
                 strmid20.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
             }
         }
         if ( ScoreManager.level21Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.lvl21_perfect == true)
            {
                strmid21.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            }
        }
         if ( ScoreManager.level22Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.lvl22_perfect == true)
            {
                strmid22.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                
            }
        }

         if ( ScoreManager.level23Passed)
        {
            Debug.Log("passed");
           if (ScoreManager.lvl23_perfect == true)
            {
                strmid23.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
            }
        }
         if ( ScoreManager.level24Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.lvl24_perfect == true)
            {
                strmid24.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
              
            }
        }
         if ( ScoreManager.level10Passed)
        {
            Debug.Log("passed level 1.0");
            if (ScoreManager.lvl10_perfect == true)
            {
                strmid10.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
              
            }
        }
         if ( ScoreManager.level40Passed)
        {
            Debug.Log(ScoreManager.cube_health);
            Debug.Log(ScoreManager.cube_health_org);
            if (ScoreManager.lvl40_perfect == true)
            {
                strmid40.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
              
            }
        }
         if ( ScoreManager.level41Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.lvl41_perfect == true)
            {
                strmid41.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                
            }
        }
         if ( ScoreManager.level42Passed)
        {
            Debug.Log(ScoreManager.cube_health);
            Debug.Log( ScoreManager.cube_health_org);
            if (ScoreManager.lvl42_perfect == true)
            {
                Debug.Log("passed");
                strmid42.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
            }
        }  if ( ScoreManager.level11Passed)
        {
            if (ScoreManager.lvl11_perfect == true)
            {
                strmid11.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                Debug.Log(strmid11.GetComponent<Image>().color);
               
            }
        }  if ( ScoreManager.level43Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.lvl43_perfect == true)
            {
                strmid43.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                
            }
        }
         if ( ScoreManager.level12Passed)
        {
            Debug.Log(" 1.2 passed");
            if  (ScoreManager.lvl12_perfect == true)
            {
                strmid12.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
            }
        } 
         if ( ScoreManager.level25Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.lvl25_perfect == true)
            {
                strmid25.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
            }
        }  if ( ScoreManager.level13Passed)
        {
            if (ScoreManager.lvl13_perfect == true)
            {
                strmid13.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                Debug.Log(strmid13.GetComponent<Image>().color);
               
            }
        }    if ( ScoreManager.level32Passed)
        {
            Debug.Log("passed");
            if (ScoreManager.lvl32_perfect == true)
            {
                strmid32.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
               
            }
        }  if ( ScoreManager.level33Passed)
        {
            if (ScoreManager.lvl33_perfect == true)
            {
                strmid33.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                Debug.Log(strmid33.GetComponent<Image>().color);
               
            }
        }
         if ( ScoreManager.level34Passed)
        {
            if (ScoreManager.lvl34_perfect == true)
            {
                strmid34.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                Debug.Log(strmid34.GetComponent<Image>().color);
               
            }
        }


    }


    // Update is called once per frame

}