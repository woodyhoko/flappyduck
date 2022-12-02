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
	
	private bool _level10;
	private bool _level10Passed;
	
	private bool _level11;
	private bool _level11Passed;
	private bool _killedByCeil;
	private bool _killedByBound;
	
	private bool _level20;
	private bool _level20Passed;
	
	private bool _level21;
	private bool _level21Passed;
	
	private bool _level22;
	private bool _level22Passed;
	
	private bool _level23;
	private bool _level23Passed;
	
	private bool _level24;
	private bool _level24Passed;
	
	private bool _level30;
	private bool _level30Passed;
	
	private bool _level31;
	private bool _level31Passed;

	private int _star;

	private bool _tutorial;
	
    
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
		
		_killedByCeil = ScoreManager.killedByCeil;
		_killedByBound = ScoreManager.killedByBound;
		
		_level20 = ScoreManager.level20;
		_level20Passed = ScoreManager.level20Passed;
		_level21 = ScoreManager.level21;
		_level21Passed = ScoreManager.level21Passed;
		_level22 = ScoreManager.level22;
		_level22Passed = ScoreManager.level22Passed;
		_level23 = ScoreManager.level23;
		_level23Passed = ScoreManager.level23Passed;
		_level24 = ScoreManager.level24;
		_level24Passed = ScoreManager.level24Passed;
		_level30 = ScoreManager.level30;
		_level30Passed = ScoreManager.level30Passed;
		_level31 = ScoreManager.level31;
		_level31Passed = ScoreManager.level31Passed;
		_level10 = ScoreManager.level10;
		_level10Passed = ScoreManager.level10Passed;
		_level11 = ScoreManager.level11;
		_level11Passed = ScoreManager.level11Passed;
		_star = ScoreManager.star_upgrade;

		_tutorial = ScoreManager.tutorial;
			
		StartCoroutine(Post(_sessionID.ToString(), _testInt.ToString(), _testBoolean.ToString(), _bigger.ToString(),
		_smaller.ToString(), _shooting.ToString(), _faster.ToString(), _longer.ToString(), _invisible.ToString(),
		_playtime.ToString("f2"), _killedByWater.ToString(),_level11.ToString(), _level10.ToString(),_level11Passed.ToString(), _level10Passed.ToString(), _killedByCeil.ToString(),
		_killedByBound.ToString(), _level20.ToString(), _level20Passed.ToString(), _level21.ToString(), _level21Passed.ToString(),
		_level22.ToString(), _level22Passed.ToString(), _level23.ToString(), _level23Passed.ToString() , _level24.ToString(), _level24Passed.ToString(),
		_level30.ToString(), _level30Passed.ToString(), _level31.ToString(), _level31Passed.ToString(), _star.ToString(), _tutorial.ToString()));

    }

    private IEnumerator Post(string sessionID, string testInt, string testBool, string bigger, string smaller, string shooting,
		string faster, string longer, string invisible, string playtime, string killByWater,string level11, string level11Passed, string level10, string level10Passed, string killedByCeil,
		string killedByBound, string level20, string level20Passed, string level21, string level21Passed, string level22, string level22Passed,
		string level23, string level23Passed, string level24, string level24Passed, string level30, string level30Passed, string level31, string level31Passed,
		string star, string tutorial)
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
		form.AddField("entry.391653921", level10);
		form.AddField("entry.1194466425", level10Passed);
		form.AddField("entry.944290667", killedByCeil);
		form.AddField("entry.1076028124", killedByBound);
		
		form.AddField("entry.1915196900", level20);
		form.AddField("entry.302430152", level20Passed);
		form.AddField("entry.1149974626", level21);
		form.AddField("entry.379091483", level21Passed);
		form.AddField("entry.1257742777", level22);
		form.AddField("entry.369368199", level22Passed);
		form.AddField("entry.917567151", level23);
		form.AddField("entry.436920548", level23Passed);
		form.AddField("entry.1567845062", level24);
		form.AddField("entry.2014221535", level24Passed);
		form.AddField("entry.2136115158", level30);
		form.AddField("entry.1961638159", level30Passed);
		form.AddField("entry.1168613017", level31);
		form.AddField("entry.1648856046", level31Passed);
		
		form.AddField("entry.1079871274", star);
		form.AddField("entry.2038159315", tutorial);
        
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
