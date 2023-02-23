using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//버튼누르는거 인식하고 스코어 올리는 코드입니다
public class AcceptButton : MonoBehaviour, IPointerDownHandler
{

    public GameObject Acceptbutton;

    private RectTransform AirdropRectTransform;

    public void Start()
    {
        GameObject Acceptbutton = GameObject.Find("accept");
    }
    private void Awake()
    {
        AirdropRectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");

        this.AirdropAccept();
        //GameObject.Find("PopUp").GetComponent<RhythmPopup>().popupText.SetActive(true);


    }
    public void AirdropAccept()
    {
        GameObject.Find("AirDrop").SetActive(false);

    }


}