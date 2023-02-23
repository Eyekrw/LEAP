using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public GameObject controller;

    public void changeS()
    {
        if (controller.GetComponent<controlN>().nSel == "prodance")
        {
            staticNums.n++;
            SceneManager.LoadScene("Exo");        //교수님들 댄스 미니게임 씬
        }
        if (controller.GetComponent<controlN>().nSel == "suganggame")
        {
            staticNums.n++;
            SceneManager.LoadScene("Sugang");        //수강신청 미니게임 씬
        }
    }
    public void returnS()
    {
        SceneManager.LoadScene("FirstGrade1");
    }
    public void startS()
    {
        SceneManager.LoadScene("FirstGrade1");
        staticNums.n = 0;
        staticNums.mental_gauge = 0;
        staticNums.study_gauge = 0;

    }
    public void continueS()
    {
        SceneManager.LoadScene("ContinueMenu");
    }
    public void returnToMain()
    {
        SceneManager.LoadScene("startScene");
    }
}
