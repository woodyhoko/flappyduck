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
    public bool move_forward = false;
    public float move_speed = 0.08f;
    public int update_max_limit = 12;
    public int ate = 0;
    public bool choosen_powerCard = false;
    public float plane_width = 10;
    public float world_speed = 1f;
    public float star_size = 0.1f;
    public Vector3 player_localScale = new Vector3(1f, 1f, 1f);
    public int world = 1;
    public int star_num = 0;
    public int[] cloned_cubes = new int[] { 0, 0 };
    public int number_of_cloned_cube = 0;
    public List<GameObject> cloned_list = new List<GameObject>();
    public List<GameObject> hearts = new List<GameObject>();
    // dizzness
    public bool dizzy = false;
    public int numTotalHit = 10;
    public int numNeedHit = 0;

    //cube health
    public int cube_health = 5;

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

    public void destroy()
    {
        Destroy(gameObject);
    }

    

}
