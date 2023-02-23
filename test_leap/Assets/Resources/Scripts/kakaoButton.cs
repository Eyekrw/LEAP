using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kakaoButton : MonoBehaviour
{
    public GameObject kakao_things; //카카오 관련 ㄴ배경들
    public GameObject kakaoback;      //글들이 있는 배경
    public GameObject kakaotext; // 글 넘기는 용도의 버튼(투명함)
    public GameObject startkakao;     //카톡모양 버튼(맨 처음 버튼)
    public GameObject maintext;
    public GameObject iknow;     //인터넷 시계가 뭔지 안다고 답하는 버튼
    public GameObject idont; // 인터넷 시계가 뭔지 모른다고 답하는 버튼
    public GameObject characters;
    public GameObject objects;

    public GameObject kakaostory;
    public GameObject kakaostory2;

    public GameObject startbutton;

    Vector3 now;
    //float jump = 0;
    int n = 1;

    bool kakao_end = false;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void startKakao()
    {
        startkakao.SetActive(false);
        //maintext.SetActive(false);
        maintext.GetComponent<Button>().interactable = false;
        maintext.SetActive(false);
        characters.SetActive(false);
        kakaotext.SetActive(true);
        kakao_things.SetActive(true);
        objects.GetComponent<changeObjects>().presentB.SetActive(false);

    }
    public void kakao()
    {
        now = kakaoback.transform.localPosition;
        if (n == 1)
        {
            now.y += 1.1f;
        }
        else if (n == 2)
        {
            now.y += 1.47f;
        }
        else if (n == 3)
        {
            now.y += 1.78f;
        }
        else if (n == 4)
        {
            now.y += 1.1f;
            iknow.SetActive(true);
            idont.SetActive(true);
            kakaotext.SetActive(false);
        }
        else if (n == 5)
        {
            now.y += 2.65f;
        }
        else if (n == 6)
        {
            now.y += 1.47f;
        }
        else if (n == 7)
        {
            now.y += 2.57f;
        }
        else if (n == 8)
        {
            now.y += 1.1f;
        }
        else if (n == 9)
        {
            now.y += 1.14f;
            n = 14;
            kakao_end = true;
        }
        else if (n == 10)
        {
            now.y += 1.47f;
        }
        else if (n == 11)
        {
            now.y += 1.16f;
        }
        else if (n == 12)
        {
            now.y += 1.82f;
        }
        else if (n == 13)
        {
            now.y += 1.16f;
            kakao_end = true;
        }
        kakaoback.transform.localPosition = now;
        n++;
        if (kakao_end && n == 15)
        {
            maintext.SetActive(true);
            maintext.GetComponent<Button>().interactable = true;
            characters.SetActive(true);
            kakaotext.SetActive(false);
            kakao_things.SetActive(false);
            maintext.GetComponent<executeButton>().nButton();
        }
    }
    // 인터넷 시계? 그건 왜 키는거야 이 두 문장을 합쳐서 말풍선으로, 두줄로.
    public void IKnow()
    {
        kakaotext.SetActive(true);
        iknow.SetActive(false);
        idont.SetActive(false);
        kakaostory.SetActive(false);
        kakaostory2.SetActive(true);
        n += 5;
    }
    public void IDont()
    {
        kakaotext.SetActive(true);
        iknow.SetActive(false);
        idont.SetActive(false);
    }
}
