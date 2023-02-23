using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeObjects : MonoBehaviour
{
    public GameObject controller;

    public string nText;
    public string nImg;
    public string nBack;
    public string nSel;

    GameObject background;
    GameObject characters;

    public GameObject presentC;
    public GameObject presentB;

    //배경
    public GameObject auditorium;
    public GameObject ecc;
    public GameObject newteo_audi;
    public GameObject pcroom;
    public GameObject phewroad;
    public GameObject poscorridor;
    public GameObject opendoor;
    public GameObject poscolass;
    public GameObject attendance;
    public GameObject coffeeslow;
    public GameObject regretcoffee;
    public GameObject damto;
    public GameObject damto_front;
    public GameObject blackout;
    public GameObject helpcat;
    public GameObject helpbear;
    public GameObject drunkenbear;
    public GameObject dormitory;
    public GameObject pheasant;
    public GameObject pheasantattack;
    public GameObject pheasantwhere;
    public GameObject mainlibrary;
    public GameObject happystudy;
    public GameObject gocafe;

    //등장인물들
    public GameObject skipC;
    
    public GameObject people;
    
    public GameObject mc;
    
    public GameObject president;
    
    public GameObject professor1;
    public GameObject professor2;
    
    public GameObject bear_normal;
    public GameObject bear_happy;
    public GameObject bear_sad;
    public GameObject bear_angry;
    public GameObject bear_curious;
    public GameObject bear_surprise;
    public GameObject bear_sleepy;
    public GameObject bear_tired;
    public GameObject bear_cheerup;
    public GameObject bear_cheerup2;

    public GameObject senior_normal;
    public GameObject senior_happy;
    public GameObject senior_angry;

    public GameObject cat_normal;
    public GameObject cat_happy;
    public GameObject cat_sad;
    public GameObject cat_angry;
    public GameObject cat_surprise;
    public GameObject cat_curious;

    public GameObject hog_normal;
    public GameObject hog_happy;
    public GameObject hog_sad;
    public GameObject hog_angry;
    public GameObject hog_surprise;
    public GameObject hog_curious;

    public GameObject professor2_normal;
    public GameObject professor2_angry;
    public GameObject professor2_happy;
    public GameObject professor2_sad;
    public GameObject professor2_curious;
    public GameObject professor2_surprise;

    void Start()
    {
        //nText = controller.GetComponent<controlN>().nText;
        //nImg = controller.GetComponent<controlN>().nImg;
        //nBack = controller.GetComponent<controlN>().nBack;
        //nSel = controller.GetComponent<controlN>().nSel;
    }
    void Update()
    {
        //nText = controller.GetComponent<controlN>().nText;
        //nImg = controller.GetComponent<controlN>().nImg;
        //nBack = controller.GetComponent<controlN>().nBack;
        //nSel = controller.GetComponent<controlN>().nSel;
    }

    public void changeB()
    {
        nBack = controller.GetComponent<controlN>().nBack;
        presentB.SetActive(false);
        if (nBack == "auditorium")
        {
            auditorium.SetActive(true);
            presentB = auditorium;
        }
        else if (nBack == "ecc")
        {
            ecc.SetActive(true);
            presentB = ecc;
        }
        else if (nBack == "newteo_audi")
        {
            newteo_audi.SetActive(true);
            presentB = newteo_audi;
        }
        else if (nBack == "pcroom")
        {
            pcroom.SetActive(true);
            presentB = pcroom;
        }
        else if (nBack == "phewroad")
        {
            phewroad.SetActive(true);
            presentB = phewroad;
        }
        else if (nBack == "poscorridor")
        {
            poscorridor.SetActive(true);
            presentB = poscorridor;
        }
        else if (nBack == "opendoor")
        {
            opendoor.SetActive(true);
            presentB = opendoor;
        }
        else if (nBack == "poscolass")
        {
            poscolass.SetActive(true);
            presentB = poscolass;
        }
        else if (nBack == "attendance")
        {
            attendance.SetActive(true);
            presentB = attendance;
        }
        else if (nBack == "coffeeslow")
        {
            coffeeslow.SetActive(true);
            presentB = coffeeslow;
        }
        else if (nBack == "regretcoffee")
        {
            regretcoffee.SetActive(true);
            presentB = regretcoffee;
        }
        else if (nBack == "damto")
        {
            damto.SetActive(true);
            presentB = damto;
        }
        else if (nBack == "damto_front")
        {
            damto_front.SetActive(true);
            presentB = damto_front;
        }
        else if (nBack == "blackout")
        {
            blackout.SetActive(true);
            presentB = blackout;
        }
        else if (nBack == "helpcat")
        {
            helpcat.SetActive(true);
            presentB = helpcat;
        }
        else if (nBack == "helpbear")
        {
            helpbear.SetActive(true);
            presentB = helpbear;
        }
        else if (nBack == "drunkenbear")
        {
            drunkenbear.SetActive(true);
            presentB = drunkenbear;
        }
        else if (nBack == "dormitory")
        {
            dormitory.SetActive(true);
            presentB = dormitory;
        }
        else if (nBack == "pheasant")
        {
            pheasant.SetActive(true);
            presentB = pheasant;
        }
        else if (nBack == "pheasantattack")
        {
            pheasantattack.SetActive(true);
            presentB = pheasantattack;
        }
        else if (nBack == "pheasantwhere")
        {
            pheasantwhere.SetActive(true);
            presentB = pheasantwhere;
        }
        else if (nBack == "mainlibrary")
        {
            mainlibrary.SetActive(true);
            presentB = mainlibrary;
        }
        else if (nBack == "happystudy")
        {
            happystudy.SetActive(true);
            presentB = happystudy;
        }
        else if (nBack == "gocafe")
        {
            gocafe.SetActive(true);
            presentB = gocafe;
        }
    }
    public void changeA()
    {
        nImg = controller.GetComponent<controlN>().nImg;
        Debug.Log(nImg);
        presentC.SetActive(false);
        if (nImg.Equals("narration"))
        {
            Debug.Log("hello");
            skipC.SetActive(true);
            presentC = skipC;
        }
        else if (nImg.Equals("people"))
        {
            people.SetActive(true);
            presentC = people;
        }
        else if (nImg.Equals("mc"))
        {
            mc.SetActive(true);
            presentC = mc;
        }
        else if (nImg.Equals("president"))
        {
            president.SetActive(true);
            presentC = president;
        }
        else if (nImg.Equals("professor1"))
        {
            professor1.SetActive(true);
            presentC = professor1;
        }
        else if (nImg.Equals("professor2"))
        {
            professor2.SetActive(true);
            presentC = professor2;
        }
        else if (nImg.Equals("bear_normal"))
        {
            bear_normal.SetActive(true);
            presentC = bear_normal;
        }
        else if (nImg.Equals("bear_happy"))
        {
            bear_happy.SetActive(true);
            presentC = bear_happy;
        }
        else if (nImg.Equals("bear_sad"))
        {
            bear_sad.SetActive(true);
            presentC = bear_sad;
        }
        else if (nImg.Equals("bear_angry"))
        {
            bear_angry.SetActive(true);
            presentC = bear_angry;
        }
        else if (nImg.Equals("bear_curious"))
        {
            bear_curious.SetActive(true);
            presentC = bear_curious;
        }
        else if (nImg.Equals("bear_surprise"))
        {
            bear_surprise.SetActive(true);
            presentC = bear_surprise;
        }
        else if (nImg.Equals("bear_sleepy"))
        {
            bear_sleepy.SetActive(true);
            presentC = bear_sleepy;
        }
        else if (nImg.Equals("bear_tired"))
        {
            bear_tired.SetActive(true);
            presentC = bear_tired;
        }
        else if (nImg.Equals("bear_cheerup"))
        {
            bear_cheerup.SetActive(true);
            presentC = bear_cheerup;
        }
        else if (nImg.Equals("bear_cheerup2"))
        {
            bear_cheerup2.SetActive(true);
            presentC = bear_cheerup2;
        }
        else if (nImg.Equals("senior_normal"))
        {
            senior_normal.SetActive(true);
            presentC = senior_normal;
        }
        else if (nImg.Equals("senior_happy"))
        {
            senior_happy.SetActive(true);
            presentC = senior_happy;
        }
        else if (nImg.Equals("senior_angry"))
        {
            senior_angry.SetActive(true);
            presentC = senior_angry;
        }
        else if (nImg.Equals("cat_normal"))
        {
            cat_normal.SetActive(true);
            presentC = cat_normal;
        }
        else if (nImg.Equals("cat_happy"))
        {
            cat_happy.SetActive(true);
            presentC = cat_happy;
        }
        else if (nImg.Equals("cat_sad"))
        {
            cat_sad.SetActive(true);
            presentC = cat_sad;
        }
        else if (nImg.Equals("cat_angry"))
        {
            cat_angry.SetActive(true);
            presentC = cat_angry;
        }
        else if (nImg.Equals("cat_surprise"))
        {
            cat_surprise.SetActive(true);
            presentC = cat_surprise;
        }
        else if (nImg.Equals("cat_curious"))
        {
            cat_curious.SetActive(true);
            presentC = cat_curious;
        }
        else if (nImg.Equals("hog_normal"))
        {
            hog_normal.SetActive(true);
            presentC = hog_normal;
        }
        else if (nImg.Equals("hog_happy"))
        {
            hog_happy.SetActive(true);
            presentC = hog_happy;
        }
        else if (nImg.Equals("hog_sad"))
        {
            hog_sad.SetActive(true);
            presentC = hog_sad;
        }
        else if (nImg.Equals("hog_angry"))
        {
            hog_angry.SetActive(true);
            presentC = hog_angry;
        }
        else if (nImg.Equals("hog_surprise"))
        {
            hog_surprise.SetActive(true);
            presentC = hog_surprise;
        }
        else if (nImg.Equals("hog_curious"))
        {
            hog_curious.SetActive(true);
            presentC = hog_curious;
        }
        else if (nImg.Equals("professor2_normal"))
        {
            professor2_normal.SetActive(true);
            presentC = professor2_normal;
        }
        else if (nImg.Equals("professor2_surprise"))
        {
            professor2_surprise.SetActive(true);
            presentC = professor2_surprise;
        }
        else if (nImg.Equals("professor2_happy"))
        {
            professor2_happy.SetActive(true);
            presentC = professor2_happy;
        }
        else if (nImg.Equals("professor2_angry"))
        {
            professor2_angry.SetActive(true);
            presentC = professor2_angry;
        }
        else if (nImg.Equals("professor2_sad"))
        {
            professor2_sad.SetActive(true);
            presentC = professor2_sad;
        }
        else if (nImg.Equals("professor2_curious"))
        {
            professor2_curious.SetActive(true);
            presentC = professor2_curious;
        }
    }
}
