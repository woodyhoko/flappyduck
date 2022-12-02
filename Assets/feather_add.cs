using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class feather_add : MonoBehaviour
{

    public TMP_Text ateText;
    public int level_require = 5;
    // Start is called before the first frame update
    void Start()
    {
        ateText.text = GlobalData.Instance.feather_num.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            //Physics.gravity = new Vector3(0, -9.81f, 0);
            //each time becomes 1.2 * original
            Destroy(gameObject);
            GlobalData.Instance.feather_num++;
            if (ateText != null)
            {
                ateText.text = GlobalData.Instance.feather_num.ToString();
            }
        }
    }
}
