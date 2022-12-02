using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockShadow : MonoBehaviour
{
    public bool clone = false;
    void Start()
    {
        Invoke("Destroy", 1f);
    }

    private void Destroy(){
        if (clone){
            Destroy(gameObject);
        }
    }
}
