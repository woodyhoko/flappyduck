using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class readInput : MonoBehaviour
{
    private string input;
    public bool loggedIn = false;
    public bool getData = false;

    public bool doneWithName = false;

    public GameObject goBack;
    public GameObject leaderboard;
    public GameObject afterText;
    
    public GameObject title;
    public GameObject inputBox;
    
    void Start()
    {
        goBack.SetActive(false);
        leaderboard.SetActive(false);
        afterText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void readStringInput(string name)
    {
        ScoreManager.username = name;
        input = name;
        doneWithName = true;
        Login(name);
    }
    
    public void Login(string name)
    {
        var request = new LoginWithCustomIDRequest
        {
            // CustomId = SystemInfo.deviceUniqueIdentifier,
            CustomId = name,
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
    }
    
    public void OnSuccess(LoginResult result)
    {
        Debug.Log("Successful login/account create!");
        loggedIn = true;
        updateDisplayName();
        SendLeaderBoard(ScoreManager.sscore);
    }
    
    public void OnError(PlayFabError error)
    {
        Debug.Log("Error while logging in/creating account");
        Debug.Log(error.GenerateErrorReport());
    }

    public void SendLeaderBoard(int score)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName = "flappyduck",
                    Value = score
                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    }
    
    public void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("successful leaderboard sent");
        goBack.SetActive(true);
        leaderboard.SetActive(true);
        afterText.SetActive(true);
        title.SetActive(false);
        inputBox.SetActive(false);
        getData = true;
    }
    
    public void updateDisplayName()
    {
        var request = new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = ScoreManager.username,
        };
        PlayFabClientAPI.UpdateUserTitleDisplayName(request, OnDisplayNameUpdate, OnError);
    }
    
    void OnDisplayNameUpdate(UpdateUserTitleDisplayNameResult result)
    {
        Debug.Log("updated display name");
    }
    
}
