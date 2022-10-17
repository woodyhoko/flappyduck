using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject player;
    public TMPro.TextMeshProUGUI score_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(player.transform.position, Vector3.up, 50 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "pipe")
        {
            Destroy(collider.gameObject);
            ScoreManager.sscore++;
            if(score_text != null){
                score_text.text = "Score : " + ScoreManager.sscore.ToString();
            }
            this.GetComponentInParent<controller>().stars.Remove(gameObject);
            Destroy(gameObject);
            float angle = 2f * Mathf.PI / (float)this.GetComponentInParent<controller>().stars.Count;
            for (int i = -1; ++i < this.GetComponentInParent<controller>().stars.Count;){
                this.GetComponentInParent<controller>().stars[i].transform.position = this.GetComponentInParent<controller>().transform.position + new Vector3(Mathf.Cos(angle*i), 0, Mathf.Sin(angle*i));
            }
        }
    }
}
