using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameEnded = false;
    public void EndGame(){
        if (gameEnded == false){
            gameEnded = true;
            Restart();
        }
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
