using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindowButton : MonoBehaviour
{
    public GameObject controller;

    public GameObject maintext;
    public GameObject characters;

    public GameObject openWindow;
    public GameObject unOpenWindow;

    public void OpenWindow()
    {
        openWindow.SetActive(false);
        unOpenWindow.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);
        staticNums.mental_gauge--;

        maintext.GetComponent<executeButton>().nButton();
    }
    public void UnOpenWindow()
    {
        staticNums.n += 15;
        openWindow.SetActive(false);
        unOpenWindow.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);
        staticNums.mental_gauge++;

        maintext.GetComponent<executeButton>().nButton();
    }
}
