using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkButton : MonoBehaviour
{
    public GameObject controller;

    public GameObject maintext;
    public GameObject characters;

    public GameObject drink;
    public GameObject undrink;

    public void Drink()
    {
        staticNums.n += 10;
        drink.SetActive(false);
        undrink.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);
        staticNums.study_gauge--;
        staticNums.mental_gauge++;

        maintext.GetComponent<executeButton>().nButton();
    }
    public void Undrink()
    {
        drink.SetActive(false);
        undrink.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);
        staticNums.mental_gauge--;
        staticNums.study_gauge++;

        maintext.GetComponent<executeButton>().nButton();
    }
}
