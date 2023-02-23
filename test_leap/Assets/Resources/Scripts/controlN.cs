using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

//B는 배경, A는 등장인물, S는 선택지, N은 다음씬
public class controlN : MonoBehaviour
{
    //public int n = 0;

    public string text;
    public string img;
    public string back;
    public string sel;

    public string[] textValue;
    public string[] ImgValue;
    public string[] BackValue;
    public string[] SelValue;

    TextAsset TextfilePath;
    TextAsset ImgfilePath;
    TextAsset BackfilePath;
    TextAsset SelfilePath;

    public string nText;
    public string nImg;
    public string nBack;
    public string nSel;

    [HideInInspector]
    public int nExit;
    public GameObject controller;
    public GameObject canvas;
    public GameObject objects;
    public GameObject startButton;
    public GameObject maintextButton;

    public TypingEffect typingEffect;
    public changeObjects changeOs;
    public selectObjects selectOs;
    public changeScene changeS;

    void Start()
    {
        TextfilePath = Resources.Load("Storys/changeText") as TextAsset;
        ImgfilePath = Resources.Load("Storys/changeImage") as TextAsset;
        BackfilePath = Resources.Load("Storys/changeBackgrounds") as TextAsset;
        SelfilePath = Resources.Load("Storys/changeSelection") as TextAsset;

        text = TextfilePath.text;
        img = ImgfilePath.text;
        back = BackfilePath.text;
        sel = SelfilePath.text;

        textValue = text.Split('\n');
        ImgValue = img.Split('\n');
        BackValue = back.Split('\n');
        SelValue = sel.Split('\n');
        
        for(int i = 0; i < textValue.Length; i++)
        {
            textValue[i] = textValue[i].Replace("\r", "");
        }
        for (int i = 0; i < ImgValue.Length; i++)
        {
            ImgValue[i] = ImgValue[i].Replace("\r", "");
            ImgValue[i] = ImgValue[i].Replace(" ", "");
        }
        for (int i = 0; i < BackValue.Length; i++)
        {
            BackValue[i] = BackValue[i].Replace("\r", "");
            BackValue[i] = BackValue[i].Replace(" ", "");
        }
        for (int i = 0; i < SelValue.Length; i++)
        {
            SelValue[i] = SelValue[i].Replace("\r", "");
            SelValue[i] = SelValue[i].Replace(" ", "");
        }

        nText = textValue[staticNums.n];
        nImg = ImgValue[staticNums.n];
        nBack = BackValue[staticNums.n];
        nSel = SelValue[staticNums.n];

        typingEffect = canvas.GetComponent<TypingEffect>();
        changeOs = objects.GetComponent<changeObjects>();
        selectOs = canvas.GetComponent<selectObjects>();
        changeS = controller.GetComponent<changeScene>();

        startgame();

        //if (staticNums.n != 0)
        //{
        //    startButton.GetComponent<StartButton>().StartB();
        //}
    }
    public void startgame()
    {
        maintextButton.SetActive(true);
        typingEffect.Get_Typing(nText);
        changeOs.changeA();
        changeOs.changeB();
        selectOs.selectB();
        changeS.changeS();
    }
}