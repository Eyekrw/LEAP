using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBC : MonoBehaviour
{
    //현재 string
    public string now;
    public int n;

    //배경
    public GameObject backgrounds;
    public GameObject presentB;
    public GameObject auditorium;
    public GameObject ecc;

    //캐릭터
    public GameObject characters;
    public GameObject presentC;
    public GameObject people;
    public GameObject mc;
    public GameObject president;
    public GameObject professor1;
    public GameObject bear_normal;
    public GameObject bear_happy;
    public GameObject bear_sad;
    public GameObject bear_angry;
    // Start is called before the first frame update
    void Start()
    {
        n = 0;
        //now = GameObject.Find("backgrounds").GetComponent<memojang>().now;
        //backgrounds = GameObject.Find("backgrounds").GetComponent<memojang>().backgrounds;
        //characters = GameObject.Find("backgrounds").GetComponent<memojang>().characters;
        
        //배경
        auditorium = backgrounds.transform.Find("auditorium").gameObject;
        ecc = backgrounds.transform.Find("ecc").gameObject;

        //캐릭터
        people = characters.transform.Find("people").gameObject;
        mc = characters.transform.Find("mc").gameObject;
        president = characters.transform.Find("president").gameObject;
        professor1 = characters.transform.Find("professor1").gameObject;
        bear_normal = characters.transform.Find("bear_normal").gameObject;
        bear_happy = characters.transform.Find("bear_happy").gameObject;
        bear_sad = characters.transform.Find("bear_sad").gameObject;
        bear_angry = characters.transform.Find("bear_angry").gameObject;
    }

    public void ChangeBackCha()
    {
        if (now == "<auditorium>")
        {
            presentB.SetActive(false);
            auditorium.SetActive(true);
            presentB = auditorium;
            n++;
        }
        else if (now == "<ecc>")
        {
            presentB.SetActive(false);
            ecc.SetActive(true);
            presentB = ecc;
            n++;
        }
        if (now == "<narration>")
        {
            presentC.SetActive(false);
            n++;
        }
        else if (now == "<people>")
        {
            presentC.SetActive(false);
            people.SetActive(true);
            presentC = people;
            n++;
        }
        else if (now == "<mc>")
        {
            presentC.SetActive(false);
            mc.SetActive(true);
            presentC = mc;
            n++;
        }
        else if (now == "<president>")
        {
            presentC.SetActive(false);
            president.SetActive(true);
            presentC = president;
            n++;
        }
        else if (now == "<professor1>")
        {
            presentC.SetActive(false);
            professor1.SetActive(true);
            presentC = professor1;
            n++;
        }
        else if (now == "<bear_normal>")
        {
            presentC.SetActive(false);
            bear_normal.SetActive(true);
            presentC = bear_normal;
            n++;
        }
        else if (now == "<bear_happy>")
        {
            presentC.SetActive(false);
            bear_happy.SetActive(true);
            presentC = bear_happy;
            n++;
        }
        else if (now == "<bear_sad>")
        {
            presentC.SetActive(false);
            bear_sad.SetActive(true);
            presentC = bear_sad;
            n++;
        }
        else if (now == "<bear_angry>")
        {
            presentC.SetActive(false);
            bear_angry.SetActive(true);
            presentC = bear_angry;
            n++;
        }
    }
}
