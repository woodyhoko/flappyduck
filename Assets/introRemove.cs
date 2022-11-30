using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introRemove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 1f);
    }

    private void Destroy()
    {

        Destroy(gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
