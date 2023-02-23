using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class executeButton : MonoBehaviour
{
    public GameObject canvas;
    public GameObject objects;
    public GameObject controller;

    public TypingEffect typingEffect;
    public changeObjects changeOs;
    public selectObjects selectOs;
    public changeScene changeS;
    public controlN controln;
    void Start()
    {
        typingEffect = canvas.GetComponent<TypingEffect>();
        changeOs = objects.GetComponent<changeObjects>();
        selectOs = canvas.GetComponent<selectObjects>();
        changeS = controller.GetComponent<changeScene>();
        controln = controller.GetComponent<controlN>();
    }
    public void nButton()
    {
        Debug.Log(staticNums.n);
        if (typingEffect.text_full == true)
        {
            staticNums.n++;
            controln.nText = controln.textValue[staticNums.n];
            controln.nImg = controln.ImgValue[staticNums.n];
            controln.nBack = controln.BackValue[staticNums.n];
            controln.nSel = controln.SelValue[staticNums.n];
            changeOs.changeA();
            changeOs.changeB();
            selectOs.selectB();
            changeS.changeS();
        }
        typingEffect.End_Typing(controln.nText);
    }
}
