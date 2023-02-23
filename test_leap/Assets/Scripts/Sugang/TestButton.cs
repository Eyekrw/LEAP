using System.Security.Cryptography;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//수강신청 미니게임에서 최종 확인버튼 누르면 스코어 나타나는 기능
public class TestButton : MonoBehaviour, IPointerDownHandler
{
    //[SerializeField] private Canvas canvas;
    public GameObject button;
    private RectTransform rectTransform;
    public int howmanyclear; // 수강신청 맞은갯수!

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown (PointerEventData eventData){
        //Debug.Log("OnPointerDown");
        
        //수강신청 맞은갯수 판별하는 코드 . howmanyclear
       
          StartCoroutine("Justrest");
        
    }

    private IEnumerator Justrest()
    {
        GameObject.Find("1_Major2").GetComponent<Course1>().Test1();
        yield return new WaitForSeconds(0.4f);
        GameObject.Find("2_Larts1").GetComponent<Course2>().Test2();
        yield return new WaitForSeconds(0.3f);
        GameObject.Find("3_Major1").GetComponent<Course3>().Test3();
        yield return new WaitForSeconds(0.2f);
        GameObject.Find("5_Larts2").GetComponent<Course5>().Test5();
        yield return new WaitForSeconds(0.3f);
        GameObject.Find("6_Sports").GetComponent<Course6>().Test6();
        yield return new WaitForSeconds(1.2f);
        //GameObject.Find("Slots").SetActive(false);
        //GameObject.Find("Courses").SetActive(false);
        
        
        GameObject.Find("BearDefault").GetComponent<BearSprite>().HappyOn(howmanyclear);
        
        Debug.Log(howmanyclear);
    }
}
