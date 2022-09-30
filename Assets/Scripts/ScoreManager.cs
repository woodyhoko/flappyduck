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
	public static float startTime = Time.time;
	

	void Start()
	{
		// startTime = Time.time;
	}

	void Update()
	{
	}
}