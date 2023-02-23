using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoretextExo : MonoBehaviour
{
    public Text ScoreExo;
    void Awake()
    {
        ScoreExo = GameObject.Find("Score100").GetComponent<Text>();
    }

    
    public void ScoreExoChange(int i)
    {
        ScoreExo.text = "" +i.ToString();
       // myScore.text = "SOCRE:" + score.ToString();
    }

}
