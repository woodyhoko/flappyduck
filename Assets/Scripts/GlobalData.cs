using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour
{
    public static GlobalData Instance;

    public float starRotateSpeed;
    public bool shoot = false;
    public int shoot_freq = 50;
    public int shoot_timestep = 0;
    public float move_forward_limit = 4.0f;
    public float move_speed = 0.08f;
    public int update_max_limit = 6;
    public int ate = 0;
    public bool choosen_powerCard = false;
    public float world_speed = 1f;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
  
}
