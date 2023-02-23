using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class memojang : MonoBehaviour
{
    //배경넘기는거
    GameObject backgrounds = new GameObject();
    GameObject characters = new GameObject();
    [HideInInspector]
    public GameObject presentB = new GameObject();
    [HideInInspector]
    public GameObject presentC = new GameObject();
    [HideInInspector]
    public int flag;
    string now;
    public GameObject maintext;

    //배경
    public GameObject auditorium;
    public GameObject ecc;

    //캐릭터
    public GameObject people;
    public GameObject mc;
    public GameObject president;
    public GameObject professor1;
    public GameObject bear_normal;
    public GameObject bear_happy;
    public GameObject bear_sad;
    public GameObject bear_angry;

    //선택지
    public GameObject selectfood;
    public GameObject uchandong;
    public GameObject gwakkin;
    public GameObject salad;

    //텍스트 타이핑효과 관련
    public float delay;
    public float Skip_delay;
    public int cnt;
    public Text txt;

    public bool text_exit;
    public bool text_full;
    public bool text_cut;

    //텍스트 메모장으로부터 불러오기
    int n = 0;
    int stop = 0;
    string filePath;
    string currentText;
    string[] textValue;

    void Start()
    {
        //배경넘기기
        backgrounds = GameObject.Find("backgrounds");
        characters = GameObject.Find("characters");
        presentC = characters.transform.Find("skipC").gameObject;
        //flag = 0;

        //텍스트 메모장으로부터 불러오기
        filePath = "C:/Users/yegirl/UnityProjects/test_leap/Assets/Story/script1.txt";
        textValue = System.IO.File.ReadAllLines(filePath);
        Get_Typing(textValue);
    }
    void Update()
    {
        if (text_exit == true)
        {
            gameObject.SetActive(false);
        }
    }
    public void Get_Typing(string[] textValue)
    {
        text_exit = false;
        text_full = false;
        text_cut = false;
        n = 0;

        now = textValue[n];
        if (now == "<auditorium>")
        {
            presentB = backgrounds.transform.Find("auditorium").gameObject;
            presentB.SetActive(true);
            n++;
            now = textValue[n];
            if (now == "<narration>")
            {
                n++;
            }
        }

        StartCoroutine(ShowText(textValue));
    }
    public void Read()
    {
        //if (textValue.Length > 0)
        //{
        //    Debug.Log(textValue[n]);
        //    n++;
        //}
        if (text_full == true)
        {
            n++;
            presentC.SetActive(false);
            text_full = false;
            text_cut = false;

            //캐릭터, 배경관련
            now = textValue[n];
            if (now == "<auditorium>")
            {
                presentB.SetActive(false);
                auditorium.SetActive(true);
                presentB = auditorium;
                n++;
                //stop = 1;
            }
            else if (now == "<ecc>")
            {
                presentB.SetActive(false);
                ecc.SetActive(true);
                presentB = ecc;
                n++;
                //stop = 1;
            }
            if (now == "<narration>")
            {
                n++;
                //stop = 1;
            }
            else if (now == "<people>")
            {
                people.SetActive(true);
                presentC = people;
                n++;
                //stop = 1;
            }
            else if (now == "<mc>")
            {
                mc.SetActive(true);
                presentC = mc;
                n++;
                //stop = 1;
            }
            else if (now == "<president>")
            {
                president.SetActive(true);
                presentC = president;
                n++;
                //stop = 1;
            }
            else if (now == "<professor1>")
            {
                professor1.SetActive(true);
                presentC = professor1;
                n++;
                //stop = 1;
            }
            else if (now == "<bear_normal>")
            {
                bear_normal.SetActive(true);
                presentC = bear_normal;
                n++;
                //stop = 1;
            }
            else if (now == "<bear_happy>")
            {
                bear_happy.SetActive(true);
                presentC = bear_happy;
                n++;
                if (textValue[n] == "<select_food>")
                {
                    //selectfood.SetActive(true);
                    uchandong.SetActive(true);
                    gwakkin.SetActive(true);
                    salad.SetActive(true);
                    maintext.GetComponent<Button>().interactable = false;
                    //stop = 1;
                    n++;
                }
                //stop = 1;
            }
            else if (now == "<bear_sad>")
            {
                bear_sad.SetActive(true);
                presentC = bear_sad;
                n++;
                //stop = 1;
            }
            else if (now == "<bear_angry>")
            {
                bear_angry.SetActive(true);
                presentC = bear_angry;
                n++;
                //stop = 1;
            }
            else if (now == "<next_scene>")
            {
                SceneManager.LoadScene("NewMT");
            }
            StartCoroutine(ShowText(textValue));
            //flag++;
        }
        else
        {
            text_cut = true;
        }
    }
    IEnumerator ShowText(string[] fullText)
    {
        if (n >= textValue.Length)
        {
            text_exit = true;
            StopCoroutine("ShowText");
        }
        else if (stop == 1)
        {
            text_full = true;
            stop = 0;
            StopCoroutine("ShowText");
        }
        else
        {
            currentText = "";
            for (int i = 0; i < fullText[n].Length; i++)
            {
                if (text_cut == true)
                {
                    break;
                }
                currentText = fullText[n].Substring(0, i + 1);
                txt.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(delay);  //한글자씩 쳐질 때 딜레이
            }
            Debug.Log("End typing");
            txt.GetComponent<Text>().text = fullText[n];
            yield return new WaitForSeconds(Skip_delay); // 그 다음 텍스트로 넘어갈 때 딜레이

            Debug.Log("Waiting Enter");
            text_full = true;
        }
    }
}
