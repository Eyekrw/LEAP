using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIcontrol : MonoBehaviour
{
    public GameObject pause_panel;
    public GameObject gameover_panel;
    public GameObject canvas;
    public GameObject maintext;
    public GameObject pauseBuT;
    bool isPause;
    public bool isRestart;
    public selectObjects SO;
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        SO = canvas.GetComponent<selectObjects>();
        isPause = false;
        isRestart = false;
        pause_panel.SetActive(false);
    }
    void Update()
    {
        if (isPause == false || isRestart == false)
        {
            Time.timeScale = 1;
            return;
        }
        if (isPause == true || isRestart == true)
        {
            Time.timeScale = 0;
            return;
        }
    }
    public void pauseBT()
    {
        pause_panel.SetActive(true);
        isPause = true;
    }
    public void continueBT()
    {
        pause_panel.SetActive(false);
        isPause = false;
    }
    public void restartBT()
    {
        staticNums.n = SO.checkRestart;
        maintext.GetComponent<executeButton>().nButton();
        pauseBuT.SetActive(true);
        gameover_panel.SetActive(false);
        isRestart = false;
    }
    public void saveBT()
    {
        PlayerPrefs.SetInt("save_point", staticNums.n);
        PlayerPrefs.SetInt("mental_point", staticNums.mental_gauge);
        PlayerPrefs.SetInt("study_point", staticNums.study_gauge);
    }
    public void loadBT()
    {
        staticNums.n = PlayerPrefs.GetInt("save_point");
        staticNums.mental_gauge = PlayerPrefs.GetInt("mental_point");
        staticNums.study_gauge = PlayerPrefs.GetInt("study_point");

        SceneManager.LoadScene("FirstGrade1");
    }
}
