using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunButton : MonoBehaviour
{
    public GameObject controller;

    public GameObject maintext;
    public GameObject characters;

    public GameObject run;
    public GameObject late;

    public void Run()
    {
        run.SetActive(false);
        late.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);
        staticNums.study_gauge++;

        maintext.GetComponent<executeButton>().nButton();
    }
    public void Late()
    {
        staticNums.n += 20;
        run.SetActive(false);
        late.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);
        staticNums.mental_gauge++;

        maintext.GetComponent<executeButton>().nButton();
    }
}
