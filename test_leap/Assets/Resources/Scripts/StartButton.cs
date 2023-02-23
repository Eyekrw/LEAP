using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject controller;
    public GameObject canvas;
    public GameObject objects;
    public GameObject startButton;
    public GameObject maintextButton;

    public TypingEffect typingEffect;
    public changeObjects changeOs;
    public selectObjects selectOs;
    public changeScene changeS;
    // Start is called before the first frame update
    void Start()
    {
        typingEffect = canvas.GetComponent<TypingEffect>();
        changeOs = objects.GetComponent<changeObjects>();
        selectOs = canvas.GetComponent<selectObjects>();
        changeS = controller.GetComponent<changeScene>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartB()
    {
        startButton.SetActive(false);
        maintextButton.SetActive(true);
        typingEffect.Get_Typing(controller.GetComponent<controlN>().nText);
        changeOs.changeA();
        changeOs.changeB();
        selectOs.selectB();
        changeS.changeS();
    }
}
