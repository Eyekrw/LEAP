using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CafeButton : MonoBehaviour
{
    public GameObject controller;

    public GameObject maintext;
    public GameObject characters;

    public GameObject cafe;
    public GameObject uncafe;

    public void Cafe()
    {
        staticNums.n += 13;
        cafe.SetActive(false);
        uncafe.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);
        staticNums.mental_gauge++;
        staticNums.study_gauge--;

        maintext.GetComponent<executeButton>().nButton();
    }
    public void UnCafe()
    {
        cafe.SetActive(false);
        uncafe.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);
        staticNums.mental_gauge--;
        staticNums.study_gauge++;

        maintext.GetComponent<executeButton>().nButton();
    }
}
