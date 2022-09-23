using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider mSlider;
    private HealthSystem healthSystem;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Setup(HealthSystem healthSystem)
    {
        this.healthSystem = healthSystem;
        healthSystem.OnHealthChanged += HealthSystem_OnHealthChanged;
    }
    private void HealthSystem_OnHealthChanged(object sender,System.EventArgs e)
    {
        //Debug.Log("system check");
        mSlider.value -= 0.25f;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
