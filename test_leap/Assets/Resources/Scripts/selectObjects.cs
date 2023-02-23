using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectObjects : MonoBehaviour
{
    public GameObject canvas;
    public GameObject controller;
    public GameObject maintext;
    public GameObject characters;
    public GameObject pauseBT;
    public GameObject end;

    public string nText;
    public string nImg;
    public string nBack;
    public string nSel;

    public GameObject gameOver;

    //선택지-selectfood
    public GameObject uchandong;
    public GameObject gwakkin;
    public GameObject salad;

    public GameObject uchandong_ex;
    public GameObject gwakkin_ex;
    public GameObject salad_ex;

    //선택지-askNewteo
    public GameObject ask;
    public GameObject notask;

    //카카오톡-kakao
    public GameObject startkakao;

    //선택지-runorlate
    public GameObject run;
    public GameObject late;

    //선택지-drinkornot
    public GameObject drink;
    public GameObject undrink;

    //선택지-openornot
    public GameObject open;
    public GameObject unopen;

    //선택지-cafeornot
    public GameObject cafe;
    public GameObject uncafe;

    public TypingEffect typingEffect;

    public int checkRestart;
    bool checkask;
    void Start()
    {
        checkask = false;
        nText = controller.GetComponent<controlN>().nText;
        nImg = controller.GetComponent<controlN>().nImg;
        nBack = controller.GetComponent<controlN>().nBack;
        nSel = controller.GetComponent<controlN>().nSel;

        typingEffect = canvas.GetComponent<TypingEffect>();
    }
    public void selectB()
    {
        if (controller.GetComponent<controlN>().nSel == "selectfood")
        {
            uchandong.SetActive(true);
            gwakkin.SetActive(true);
            salad.SetActive(true);
            uchandong_ex.SetActive(true);
            gwakkin_ex.SetActive(true);
            salad_ex.SetActive(true);
            maintext.SetActive(false);
            characters.SetActive(false);
        }
        else if (controller.GetComponent<controlN>().nSel == "askNewteo")
        {
            checkRestart = 46;
            //Debug.Log(controller.GetComponent<controlN>().nText);
            ask.SetActive(true);
            notask.SetActive(true);
            maintext.SetActive(false);
            characters.SetActive(false);
            typingEffect.text_full = true;
        }
        else if (controller.GetComponent<controlN>().nSel == "jump2")
        {
            staticNums.n += 3;
            checkask = true;
        }
        else if (controller.GetComponent<controlN>().nSel == "gameover_new")
        {
            if (checkask == false)
            {
                gameOver.SetActive(true);
                pauseBT.SetActive(false);
                controller.GetComponent<UIcontrol>().isRestart = true;
            }
        }
        else if (controller.GetComponent<controlN>().nSel == "kakao")
        {
            startkakao.SetActive(true);
            //typingEffect.text_full = true;
            maintext.GetComponent<Button>().interactable = false;
        }
        else if (controller.GetComponent<controlN>().nSel == "runorlate")
        {
            run.SetActive(true);
            late.SetActive(true);
            maintext.SetActive(false);
            characters.SetActive(false);
            typingEffect.text_full = true;
        }
        else if (controller.GetComponent<controlN>().nSel == "jump24")
        {
            staticNums.n += 24;
        }
        else if (controller.GetComponent<controlN>().nSel == "drinkornot")
        {
            drink.SetActive(true);
            undrink.SetActive(true);
            maintext.SetActive(false);
            characters.SetActive(false);
            typingEffect.text_full = true;
        }
        else if (controller.GetComponent<controlN>().nSel == "jump20")
        {
            staticNums.n += 20;
        }
        else if (controller.GetComponent<controlN>().nSel == "openornot")
        {
            open.SetActive(true);
            unopen.SetActive(true);
            maintext.SetActive(false);
            characters.SetActive(false);
            typingEffect.text_full = true;
        }
        else if (controller.GetComponent<controlN>().nSel == "jump8")
        {
            staticNums.n += 8;
        }
        else if (controller.GetComponent<controlN>().nSel == "cafeornot")
        {
            cafe.SetActive(true);
            uncafe.SetActive(true);
            maintext.SetActive(false);
            characters.SetActive(false);
            typingEffect.text_full = true;
        }
        else if (controller.GetComponent<controlN>().nSel == "jump9")
        {
            staticNums.n += 9;
        }
        else if (controller.GetComponent<controlN>().nSel == "ending")
        {
            end.SetActive(true);
        }
    }
}
