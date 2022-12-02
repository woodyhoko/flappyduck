using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;
using System;

public class ScoreManager : MonoBehaviour
{
    public static int sscore = 0;

    public static int biggerCube = 0;
    public static int smallerCube = 0;
    public static int shooter = 0;
    public static int faster = 0;
    public static int longer = 0;
    public static int invisible = 0;
    public static bool killedByRock = false;
    public static bool killedByWater = false;
    public static bool killedByCeil = false;
    public static bool killedByPipe = false;
    public static bool killedByBound = false;
    public static float startTime = Time.time;

    public static bool level10 = false;
    public static bool level10Passed = false;
    public static bool lvl10_perfect = false; 
    public static bool level11 = false;
    public static bool level11Passed = false;
    public static bool lvl11_perfect = false; 

    public static bool level12 = false;
    
    public static bool level12Passed = false;
    public static bool lvl12_perfect = false; 

    public static bool level13 = false;
    public static bool level13Passed = false;
    public static bool lvl13_perfect = false; 

    public static bool level20 = false;
    public static bool level20Passed = false;
    public static bool lvl20_perfect = false; 
    public static bool level21 = false;
    public static bool level21Passed = false;
    public static bool lvl21_perfect = false; 
    public static bool level22 = false;
    public static bool level22Passed = false;
    public static bool lvl22_perfect = false; 

    public static bool level23 = false;
    public static bool level23Passed = false;
    public static bool lvl23_perfect = false; 

    public static bool level24 = false;
    public static bool level24Passed = false;
    public static bool lvl24_perfect = false; 
    public static bool level25 = false;
    public static bool level25Passed = false;
    public static bool lvl25_perfect = false; 

    public static bool level30 = false;
    public static bool level30Passed = false;
    public static bool lvl30_perfect = false; 

    public static bool level31 = false;
    public static bool level31Passed = false;
    public static bool lvl31_perfect = false; 
    public static bool level32 = false;
    public static bool level32Passed = false;
    public static bool lvl32_perfect = false; 
    public static bool level33 = false;
    public static bool level33Passed = false;
    public static bool lvl33_perfect = false; 
    public static bool level34 = false;
    public static bool level34Passed = false;
    public static bool lvl34_perfect = false; 

    public static bool level40 = false;
    public static bool level40Passed = false;
    public static bool lvl40_perfect = false; 
    public static bool level41 = false;
    public static bool level41Passed = false;
    public static bool lvl41_perfect = false; 
    public static bool level42 = false;
    public static bool level42Passed = false;
    public static bool lvl42_perfect = false; 
    public static bool level43 = false;
    public static bool level43Passed = false;
    public static bool lvl43_perfect = false; 
    public static int star_upgrade = 0;

    public static bool tutorial = false;

    public static float cube_health;
    public static float cube_health_org;
    public ScoreData sd;

    public static string username = "levelPlayer";

    void Start()
    {

        // startTime = Time.time;
    }

    void Awake()
    {

        sd = new ScoreData();
    }

    public IEnumerable<Score> GetHighScores()
    {
        return sd.scores.OrderByDescending(x => x.score);
    }

    public void AddScore(Score score)
    {
        sd.scores.Add(score);
    }

    void FixedUpdate()
    {

        Debug.Log("updating cube_health " + cube_health);
    }
}
