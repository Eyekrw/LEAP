using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreControl : MonoBehaviour
{
    public int score;
    public Text myScore;
    void Start()
    {
        myScore.text = "SCORE:0";
        myScore = GameObject.Find("Score").GetComponent<Text>();
    }

    public void ScoreChange(bool i)
    {
        if (i == true)
            score = score + Random.Range(5,7);
        else if (i == false)
            score = score - Random.Range(3,6);
    
      myScore.text = "SOCRE:" + score.ToString();
    }

}
