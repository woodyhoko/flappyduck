using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerator : MonoBehaviour
{
    public GameObject pipe;
    public GameObject fallingObj;

    // Start is called before the first frame update
    void Start()
    {
        // GameObject ppipe = (GameObject)Instantiate (pipe);
        // // var rotation = new Quaternion();
        // // rotation.eulerAngles = new Vector3(54.5f, 0, 0);
        // ppipe.transform.rotation = Quaternion.identity;
        // ppipe.transform.position = new Vector3(0, 1, 20);
        // Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
        // m_Rigidbody.velocity = new Vector3(0,0,-15f);
    }

    // Update is called once per frame
    void Update()
    {
        float randomNumber = Random.Range(0, 1f);
        if (randomNumber > 0.990f){
            GameObject ppipe = (GameObject)Instantiate (pipe);
            ppipe.transform.rotation = Quaternion.identity;
            ppipe.transform.position = new Vector3(Random.Range(-5, 5f), 1, 36);
            Rigidbody m_Rigidbody = ppipe.GetComponent<Rigidbody>();
            m_Rigidbody.velocity = new Vector3(0,0,-15f);
        }

        // check if generate a new falling stone
        if (randomNumber > 0.990f){
            GameObject rock = (GameObject)Instantiate (fallingObj);
            rock.transform.rotation = Quaternion.identity;
            rock.transform.position = new Vector3(Random.Range(-5, 5f), Random.Range(10, 20f), 36);
            Rigidbody rb_rock = rock.GetComponent<Rigidbody>();
            rb_rock.velocity = new Vector3(0,0,-15f);
        }
    }
}
