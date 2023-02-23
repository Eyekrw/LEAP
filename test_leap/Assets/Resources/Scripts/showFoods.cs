using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showFoods : MonoBehaviour
{
    public GameObject uchandong_ex;
    public GameObject gwakkin_ex;
    public GameObject salad_ex;

    public GameObject uchandong_img;
    public GameObject gwakkin_img;
    public GameObject salad_img;

    public void showF()
    {
        if (gameObject == uchandong_ex)
        {
            if (uchandong_img.activeSelf)
            {
                uchandong_img.SetActive(false);
            }
            else
            {
                uchandong_img.SetActive(true);
                gwakkin_img.SetActive(false);
                salad_img.SetActive(false);
            }
        }
        else if (gameObject == gwakkin_ex)
        {
            if (gwakkin_img.activeSelf)
            {
                gwakkin_img.SetActive(false);
            }
            else
            {
                gwakkin_img.SetActive(true);
                uchandong_img.SetActive(false);
                salad_img.SetActive(false);
            }
        }
        else if (gameObject == salad_ex)
        {
            if (salad_img.activeSelf)
            {
                salad_img.SetActive(false);
            }
            else
            {
                salad_img.SetActive(true);
                uchandong_img.SetActive(false);
                gwakkin_img.SetActive(false);
            }
        }
    }

    //private void OnMouseDown()
    //{
    //    if (gameObject == uchandong_ex)
    //    {
    //        uchandong_img.SetActive(true);
    //    }
    //    else if (gameObject == gwakkin_ex)
    //    {
    //        gwakkin_img.SetActive(true);
    //    }
    //    else if (gameObject == salad_ex)
    //    {
    //        salad_img.SetActive(true);
    //    }
    //}
    //private void OnMouseExit()
    //{
    //    if (gameObject == uchandong_ex)
    //    {
    //        uchandong_img.SetActive(false);
    //    }
    //    else if (gameObject == gwakkin_ex)
    //    {
    //        gwakkin_img.SetActive(false);
    //    }
    //    else if (gameObject == salad_ex)
    //    {
    //        salad_img.SetActive(false);
    //    }
    //}

}
