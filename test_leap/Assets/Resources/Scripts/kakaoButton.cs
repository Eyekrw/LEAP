using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kakaoButton : MonoBehaviour
{
    public GameObject kakao_things; //īī�� ���� ������
    public GameObject kakaoback;      //�۵��� �ִ� ���
    public GameObject kakaotext; // �� �ѱ�� �뵵�� ��ư(������)
    public GameObject startkakao;     //ī���� ��ư(�� ó�� ��ư)
    public GameObject maintext;
    public GameObject iknow;     //���ͳ� �ð谡 ���� �ȴٰ� ���ϴ� ��ư
    public GameObject idont; // ���ͳ� �ð谡 ���� �𸥴ٰ� ���ϴ� ��ư
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
    // ���ͳ� �ð�? �װ� �� Ű�°ž� �� �� ������ ���ļ� ��ǳ������, ���ٷ�.
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
