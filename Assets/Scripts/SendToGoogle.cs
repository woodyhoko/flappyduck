using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Globalization;
using UnityEngine.UI;
using UnityEditor;

public class SendToGoogle : MonoBehaviour
{
    [SerializeField]private string URL;
    private int _testInt;
    private bool _testBoolean;
    private long _sessionID;
	private int _bigger;
	private int _smaller;
	private int _faster;
	private int _longer;
	private int _invisible;
	private int _shooting;
	private bool _killedByWater;
	private float _playtime;

	private bool _level1;
    
    private void Awake()
    {
        // Assign sessionID to identify playtests
        _sessionID = DateTime.Now.Ticks;
        Send();
    }
    
    public void Send()
    {
        // Assign variables
        _playtime = Time.time - ScoreManager.startTime;
        ScoreManager.startTime = Time.time;
        _testInt = ScoreManager.sscore;
        _testBoolean = ScoreManager.killedByRock;
        _bigger = ScoreManager.biggerCube;
		_smaller = ScoreManager.smallerCube;
		_faster = ScoreManager.faster;
		_longer = ScoreManager.longer;
		_invisible = ScoreManager.invisible;
		_shooting = ScoreManager.shooter;
		_killedByWater = ScoreManager.killedByWater;
		_level1 = ScoreManager.level1;
			
		StartCoroutine(Post(_sessionID.ToString(), _testInt.ToString(), _testBoolean.ToString(), _bigger.ToString(),
		_smaller.ToString(), _shooting.ToString(), _faster.ToString(), _longer.ToString(), _invisible.ToString(),
		_playtime.ToString("f2"), _killedByWater.ToString(), _level1.ToString()));

    }

    private IEnumerator Post(string sessionID, string testInt, string testBool, string bigger, string smaller, string shooting,
		string faster, string longer, string invisible, string playtime, string killByWater, string level1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.694322186", sessionID);
        form.AddField("entry.686730480", testInt);
        form.AddField("entry.1535048751", testBool);
		form.AddField("entry.1474800409", bigger);
		form.AddField("entry.1218406618", smaller);
		form.AddField("entry.1464185704", shooting);
		form.AddField("entry.397715220", faster);
		form.AddField("entry.453491236", longer);
		form.AddField("entry.33886605", invisible);
		form.AddField("entry.210980662", playtime);
		form.AddField("entry.713560671", killByWater);
		form.AddField("entry.391653921", level1);
        
        // Send responses and verify result
        using (UnityWebRequest www = UnityWebRequest.Post(URL, form))
        {
            yield return www.SendWebRequest();
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }
        }
    }
}
