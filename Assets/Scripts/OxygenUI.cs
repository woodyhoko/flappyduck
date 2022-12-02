using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OxygenUI : MonoBehaviour
{
    float ox = 500f;
    public GameObject oxyUI;
    RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {
        rt = (RectTransform)oxyUI.transform;
        rt.sizeDelta = new Vector2(ox, 20f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ox -= 1f;
        rt.sizeDelta = new Vector2(ox, 20f);
        if(ox<=0f)
        {
            SceneManager.LoadScene("portal");
        }
    }
}
