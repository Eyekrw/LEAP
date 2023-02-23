using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AskButton : MonoBehaviour
{
    public GameObject controller;

    public GameObject maintext;
    public GameObject characters;

    public GameObject ask;
    public GameObject notask;

    void Start()
    {

    }
    public void Ask()
    {
        ask.SetActive(false);
        notask.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);

        maintext.GetComponent<executeButton>().nButton();
    }
    public void NotAsk()
    {
        Debug.Log(controller.GetComponent<controlN>().nText);

        staticNums.n += 14;
        ask.SetActive(false);
        notask.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);

        maintext.GetComponent<executeButton>().nButton();
    }
}
