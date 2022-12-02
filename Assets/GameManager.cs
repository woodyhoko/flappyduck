using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI score_text;
    bool gameEnded = false;
    public void EndGame(){
        if (gameEnded == false){
            gameEnded = true;
            Restart();
        }
    }
    void Restart(){
        if (GlobalData.Instance != null)
            GlobalData.Instance.destroy();
        SceneManager.LoadScene("gameover");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
