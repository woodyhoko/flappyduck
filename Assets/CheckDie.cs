using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using PlayFab;
using PlayFab.ClientModels;

public class CheckDie : MonoBehaviour
{
    public bool islevel = true;
    public bool hasRock = false;
    public GameObject Canvas;
    public TMP_Text title;
    public GameObject replay;
    public GameObject next_level;

    public bool updatedLeaderBoardValue = false;

    public bool loggedin = false;
    public bool updatedName = false;

    public bool enteredname = false;
    public int minScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        if (!islevel)
            Login();
    }

    // Update is called once per frame
    void Update()
    {
        if (loggedin && !updatedName)
        {
            updatedName = true;
            updateDisplayName();
        }

        if (transform.position.y < -10 || transform.position.z < -5 || transform.position.x < -8 || transform.position.x > 8)
        {
            if (this.tag == "Player")
            {
                ScoreManager.killedByBound = true;
                ScoreManager.killedByCeil = false;
                ScoreManager.killedByWater = false;
                if (islevel)
                {
                    level_game_over();
                }
                else
                {
                    level_game_over();
                    //playfabManager.GetLeaderboard();
                }
            }
            else
            {
                Destroy(this);
            }

        }
        if (GlobalData.Instance.cube_health <= 0)
        {
            if (this.tag == "Player")
            {
                if (islevel)
                {
                    level_game_over();
                }
                else
                {
                    level_game_over();
                }
            }
            else
            {
                Destroy(this);
            }
        }
    }

    // private void OnTriggerEnter(Collider collider)
    // {
    // if (collider.gameObject.tag == "ceil" || collider.gameObject.tag == "pipe")
    // {
    //     if (this.tag == "Player")
    //     {
    //         if (collider.gameObject.tag == "pipe")
    //         {
    //             // GlobalData.Instance.cube_health -= 1;
    //             int hp = GlobalData.Instance.cube_health;
    //             if (hp >= 0)
    //                 GlobalData.Instance.hearts[hp].SetActive(false);
    //             if (hp <= 0f)
    //             {
    //                 ScoreManager.killedByWater = false;
    //                 ScoreManager.killedByPipe = true;
    //                 ScoreManager.killedByCeil = false;
    //                 ScoreManager.killedByBound = false;
    //                 if (islevel)
    //                     level_game_over();
    //                 else
    //                     level_game_over(); // FindObjectOfType<GameManager>().EndGame();
    //             }
    //         }
    //         else if (collider.gameObject.tag == "ceil")
    //         {
    //             ScoreManager.killedByCeil = true;
    //             ScoreManager.killedByPipe = false;
    //             ScoreManager.killedByWater = false;
    //             ScoreManager.killedByBound = false;
    //             Debug.Log("ceil");
    //             if (islevel)
    //                 level_game_over();
    //             else
    //                 level_game_over(); //FindObjectOfType<GameManager>().EndGame();
    //             //playfabManager.SendLeaderBoard(ScoreManager.sscore);
    //             //playfabManager.GetLeaderboard();
    //         }
    //     }
    //     else
    //     {
    //         int size = GlobalData.Instance.cloned_list.Count;

    //         for (int i = 0; i < size; i++)
    //         {
    //             if (GlobalData.Instance.cloned_list[i] == this)
    //             {
    //                 GlobalData.Instance.cloned_list.RemoveAt(i);
    //             }
    //         }
    //         Destroy(this);
    //     }

    // }
    // }
    // private void OnCollisionEnter(Collision collision)
    // {
    // if (collision.gameObject.tag == "water" && this.tag == "Player")
    // {
    //     // GlobalData.Instance.cube_health -= 1;
    //     GlobalData.Instance.hearts[GlobalData.Instance.cube_health].SetActive(false);
    //     if (GlobalData.Instance.cube_health <= 0f)
    //     {
    //         ScoreManager.killedByWater = true;
    //         ScoreManager.killedByPipe = false;
    //         ScoreManager.killedByCeil = false;
    //         ScoreManager.killedByBound = false;
    //         if (islevel)
    //         {
    //             level_game_over();
    //         }
    //         else
    //         {
    //             level_game_over();
    //             // FindObjectOfType<GameManager>().EndGame();
    //         }
    //     }
    //     Destroy(collision.gameObject);
    //     Debug.Log("get hit by water");
    // }
    // }


    private void level_game_over()
    {
        Time.timeScale = 0;
        if (!islevel && ScoreManager.sscore > minScore)
        {
            // Time.timeScale = 1;
            GlobalData.Instance.destroy();
            SceneManager.LoadScene("inputUserName");
        }
        Canvas.SetActive(true);
        // Debug.Log(islevel);

        GameObject background = Canvas.GetComponent<Transform>().Find("Background").gameObject;
        GameObject dizzy = Canvas.GetComponent<Transform>().Find("Dizzy").gameObject;
        if(dizzy!=null)
            dizzy.SetActive(false);
        background.SetActive(true);

        if (islevel)
        {
            title.text = "Game Over";
            replay.SetActive(true);
            next_level.SetActive(false);
            return;
        }
        
        if (!islevel)
        {
            TMP_Text score = background.GetComponent<Transform>().Find("Score").GetComponent<TMP_Text>();
            score.GetComponent<TMPro.TextMeshProUGUI>().text = "Score : " + ScoreManager.sscore.ToString();
            title.text = "Game Over";
            replay.SetActive(true);
            next_level.SetActive(false);
        }
        
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


    public void OnError(PlayFabError error)
    {
        Debug.Log("Error while logging in/creating account");
        Debug.Log(error.GenerateErrorReport());
    }

    public void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        print(result.ToString());
        Debug.Log("successful leaderboard sent");
    }

    public void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            // CustomId = SystemInfo.deviceUniqueIdentifier,
            CustomId = ScoreManager.username,
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
        loggedin = true;
        var request = new GetLeaderboardRequest
        {
            StatisticName = "flappyduck",
            StartPosition = 0,
            MaxResultsCount = 5
        };
        PlayFabClientAPI.GetLeaderboard(request, OnLeaderboardGet, OnError);
    }

    public void OnLeaderboardGet(GetLeaderboardResult result)
    {
        minScore = result.Leaderboard[4].StatValue;
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
