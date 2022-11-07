using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;
public class ScoreManager : MonoBehaviour {
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
	public static bool killedByBound = false;
	public static float startTime = Time.time;
	
	public static bool level1 = false;
	public static bool level1Passed = false;
	
	public static bool level20 = false;
	public static bool level20Passed = false;
	
	public static bool level21 = false;
	public static bool level21Passed = false;
	
	public static bool level22 = false;
	public static bool level22Passed = false;
	
	public static bool level23 = false;
	public static bool level23Passed = false;
	
	public static bool level24 = false;
	public static bool level24Passed = false;
	
	public static bool level30 = false;
	public static bool level30Passed = false;
	
	public static bool level31 = false;
	public static bool level31Passed = false;
	public static bool level40 = false;
	public static bool level40Passed = false;
	public static int star_upgrade = 0;

	public static bool tutorial = false;

	void Start()
	{
		// startTime = Time.time;
	}

	void Update()
	{
	}
}
