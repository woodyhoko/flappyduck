using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Rigidbody rb;
    public bool clone = false;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(8, 9, false);
        if (clone){
            Invoke("DestroyFallingRock", 1f);
        }
        GameObject obj = (GameObject)Instantiate (gameObject);
        obj.GetComponent<BoxCollider>().isTrigger = true;
        obj.transform.SetParent(this.transform);
        obj.transform.position = obj.transform.position + new Vector3(0, -obj.transform.position.y -0.5f, 0);
        // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void OnCollisionEnter(Collision collision){
    //     if(collision.gameObject.tag == "Plane"){
    //         Invoke("DestroyFallingRock", 1f);
    //     }
    // }
    private void DestroyFallingRock(){
        Destroy(gameObject);
    }
    // private void OnTriggerEnter(Collider other)
    // {
    //     // if(other.tag == "Player") {
    //     //     FindObjectOfType<GameManager>().EndGame();
    //     // }
    //     // else 
    //     if(other.tag == "Plane") {
    //         Destroy(gameObject);
    //     }
    // }
}
