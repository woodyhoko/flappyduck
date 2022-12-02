using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen : MonoBehaviour
{
    float oxygen = 100f;
    public GameObject oxyUI;
    RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {
        rt = (RectTransform)oxyUI.transform;
        rt.sizeDelta = new Vector2(oxygen, 10f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        oxygen--;
        rt.sizeDelta = new Vector2(oxygen, 10f);
    }
}
