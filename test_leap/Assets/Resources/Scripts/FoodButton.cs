using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FoodButton : MonoBehaviour
{
    public GameObject selectfood;
    public GameObject uchandong;
    public GameObject gwakkin;
    public GameObject salad;
    public GameObject maintext;
    public GameObject characters;

    public GameObject uchandong_img;
    public GameObject gwakkin_img;
    public GameObject salad_img;

    void Start()
    {
        //uchandong = selectfood.transform.Find("uchandong").gameObject;
        //gwakkin = selectfood.transform.Find("gwakkin").gameObject;
        //salad = selectfood.transform.Find("salad").gameObject;
    }
    void Update()
    {
        //if (Input.touchCount > 0)
        //{
        //    uchandong.SetActive(false);
        //    gwakkin.SetActive(false);
        //    salad.SetActive(false);
        //    maintext.SetActive(true);
        //    characters.SetActive(true);
        //}
    }

    public void openButton()
    {
        uchandong.SetActive(true);
        gwakkin.SetActive(true);
        salad.SetActive(true);
        maintext.GetComponent<Button>().interactable = false;
    }
    public void closeButton()
    {
        uchandong.SetActive(false);
        gwakkin.SetActive(false);
        salad.SetActive(false);
        maintext.SetActive(true);
        characters.SetActive(true);
        uchandong_img.SetActive(false);
        gwakkin_img.SetActive(false);
        salad_img.SetActive(false);

        maintext.GetComponent<executeButton>().nButton();

    }

    //private void OnMouseDown()
    //{
    //    uchandong.SetActive(false);
    //    gwakkin.SetActive(false);
    //    salad.SetActive(false);
    //    maintext.SetActive(true);
    //    characters.SetActive(true);
    //}
}
