using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gaugecontrol : MonoBehaviour
{
    [HideInInspector]
    public int mental_gauge;
    [HideInInspector]
    public int study_gauge;
    public GameObject gameoverPanel;

    public static gaugecontrol Instance;

    private void Start()
    {
        //mental_gauge = GameObject.Find("gauge").GetComponent<DontDestroy>().mental_gauge;
        //study_gauge = GameObject.Find("gauge").GetComponent<DontDestroy>().study_gauge;
    }
    public void MentalUp()
    {
        staticNums.mental_gauge += 10;
    }
    public void MentalDown()
    {
        staticNums.mental_gauge -= 10;
        if (staticNums.mental_gauge < 0)
        {
            gameoverPanel.SetActive(true);
        }
    }
    public void StudyUp()
    {
        staticNums.study_gauge += 10;
    }
    public void StudyDown()
    {
        staticNums.study_gauge -= 10;
        if (staticNums.study_gauge < 0)
        {
            gameoverPanel.SetActive(true);
        }
    }
}
