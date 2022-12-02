using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_stop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject intro;
    void Start()
    {  
        Debug.Log(GlobalData.Instance.introShowed);
        if (!GlobalData.Instance.introShowed) {

            GlobalData.Instance.introShowed = true;
            Time.timeScale = 0;
            intro.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
