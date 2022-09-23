using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Globalization;

public class SendToGoogle : MonoBehaviour
{
    [SerializeField]private string URL;
    private int _testInt;
    private bool _testBoolean;
    private long _sessionID;
    
    private void Awake()
    {
        // Assign sessionID to identify playtests
        _sessionID = DateTime.Now.Ticks;
        Send();
    }
    
    public void Send()
    {
        // Assign variables
        // _testInt = UnityEngine.Random.Range(0, 101);
        _testInt = ScoreManager.sscore;
        _testBoolean = true;
        
        StartCoroutine(Post(_sessionID.ToString(), _testInt.ToString(), _testBoolean.ToString()));
    }

    private IEnumerator Post(string sessionID, string testInt, string testBool)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.694322186", sessionID);
        form.AddField("entry.686730480", testInt);
        form.AddField("entry.1535048751", testBool);
        
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
