using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingEffect : MonoBehaviour
{
    //텍스트 타이핑효과 관련
    public float delay;
    public float Skip_delay;
    public int cnt;
    public Text txt;

    public bool text_exit;
    public bool text_full;
    public bool text_cut;

    string nText;          //textValue[n] 가져오기
    string currentText;
    public GameObject controller;
    void Start()
    {

    }
    void Update()
    {
        if (text_exit == true)
        {
            gameObject.SetActive(false);
        }
    }
    public void Get_Typing(string nText)
    {
        text_exit = false;
        text_full = false;
        text_cut = false;

        StartCoroutine(ShowText(nText));
    }
    public void End_Typing(string nText)
    {
        if (text_full == true)
        {
            text_full = false;
            text_cut = false;
            StartCoroutine(ShowText(nText));
        }
        else
        {
            text_cut = true;
        }
    }
    public IEnumerator ShowText(string nText)
    {
        if (controller.GetComponent<controlN>().nExit == 1)
        {
            text_exit = true;
            StopCoroutine("ShowText");
        }
        else
        {
            currentText = "";
            for (int i = 0; i < nText.Length; i++)
            {
                if (text_cut == true)
                {
                    break;
                }
                currentText = nText.Substring(0, i + 1);
                txt.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(delay);  //한글자씩 쳐질 때 딜레이
            }
            Debug.Log("End typing");
            txt.GetComponent<Text>().text = nText;
            yield return new WaitForSeconds(Skip_delay); // 그 다음 텍스트로 넘어갈 때 딜레이

            Debug.Log("Waiting Enter");
            text_full = true;
        }
    }
}
