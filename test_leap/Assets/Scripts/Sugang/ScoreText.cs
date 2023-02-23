using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text SugangScore;
    void Awake()
    {
        SugangScore = GameObject.Find("Score15").GetComponent<Text>();
    }

    
    public void ScoreChange(int i)
    {
        SugangScore.text = "" +i.ToString();
       // myScore.text = "SOCRE:" + score.ToString();
    }

}
