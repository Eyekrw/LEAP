using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//버튼누르는거 인식하고 스코어 올리는 코드입니다
public class GetAirdrop : MonoBehaviour, IPointerDownHandler
{
    public GameObject AirdropSpace;

    private RectTransform rectTransform;

    public void Start()
    {
        GameObject AirdropSpace = GameObject.Find("AirDrop");
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");

        this.AirdropPopup();
        //GameObject.Find("PopUp").GetComponent<RhythmPopup>().popupText.SetActive(true);


    }
    public void AirdropPopup()
    {
        
        GameObject.Find("AirDrop").SetActive(true);
    }



}
