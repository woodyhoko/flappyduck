using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class ScoreUI : MonoBehaviour
{
    public RowUI RowUi;

    public ScoreManager scoreManger;
    // Start is called before the first frame update
    void Start()
    {
        scoreManger.AddScore(new Score("eran", 251));
        
        var scores = scoreManger.GetHighScores().ToArray();
        int min = Math.Min(3, scores.Length);
        for (int i = 0; i < min; i++)
        {
            var row = Instantiate(RowUi, transform).GetComponent<RowUI>();
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
