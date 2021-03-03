using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMesh textScore;
    private double score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(textScore);
    }

    // Update is called once per frame
    void Update()
    {
        score += 0.01;
        Debug.Log(score);
        textScore.text = "Score: " + score.ToString();
    }
}
