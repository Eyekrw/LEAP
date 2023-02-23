using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//버튼누르는거 인식하고 스코어 올리는 코드입니다
public class DB : MonoBehaviour, IPointerDownHandler
{
    
    public GameObject Dbutton;
    private bool oorx;
    public static int Dnumber = 2;
    
      private RectTransform DrectTransform;

    private void Awake()
    {
        DrectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject.Find("GuideImg").GetComponent<Arrows>().stage += 1;
        GameObject.Find("Wolf").GetComponent<Wolves>().ChangeWolf();
        
        if (GameObject.Find("GuideImg").GetComponent<Arrows>().stage > 5)
        {
            GameObject.Find("GuideImg").GetComponent<Kancontrol1>().kanstagestate += 1;
            //Debug.Log (GameObject.Find("GuideImg").GetComponent<Kancontrol1>().kanstagestate);
            GameObject.Find("GuideImg").GetComponent<Arrows>().stage = 1; // 먼저 stage를 1로 바꾼뒤
             // 아직 kanstate 초기화 안 한 상태에서, 스코어변수 oorx 판정부터 해놓는다. 온포인터 마지막에서 스코어함수호출
             if(GameObject.Find("Kan5").GetComponent<Kancontrol>().kanstate == Dnumber){ 
                 GameObject.Find("Kan5").GetComponent<Kancontrol>().Oxtest(true);
                oorx = true;
            }else{
                GameObject.Find("Kan5").GetComponent<Kancontrol>().Oxtest(false);
                oorx = false;
            }// 현재상태 판정 다 되었으면, 그후에 초기화해야함.
            StartCoroutine("Justrest");
           
        }
        Debug.Log(GameObject.Find("GuideImg").GetComponent<Arrows>().stage);

        // ox 판별하는 코드
        if(GameObject.Find("GuideImg").GetComponent<Arrows>().stage==2){
            if(GameObject.Find("Kan1").GetComponent<Kancontrol>().kanstate == Dnumber){
                GameObject.Find("Kan1").GetComponent<Kancontrol>().Oxtest(true);
                oorx = true;
            }else{
                GameObject.Find("Kan1").GetComponent<Kancontrol>().Oxtest(false);
                
            }
        }
        if(GameObject.Find("GuideImg").GetComponent<Arrows>().stage==3){
            if(GameObject.Find("Kan2").GetComponent<Kancontrol>().kanstate == Dnumber){
                GameObject.Find("Kan2").GetComponent<Kancontrol>().Oxtest(true);
                oorx = true;
            }else{
                GameObject.Find("Kan2").GetComponent<Kancontrol>().Oxtest(false);
                oorx = false;
            }
        }
        if(GameObject.Find("GuideImg").GetComponent<Arrows>().stage==4){
            if(GameObject.Find("Kan3").GetComponent<Kancontrol>().kanstate == Dnumber){
                GameObject.Find("Kan3").GetComponent<Kancontrol>().Oxtest(true);
                oorx = true;
            }else{
                GameObject.Find("Kan3").GetComponent<Kancontrol>().Oxtest(false);
                oorx = false;
            }
        }
         if(GameObject.Find("GuideImg").GetComponent<Arrows>().stage==5){
            if(GameObject.Find("Kan4").GetComponent<Kancontrol>().kanstate == Dnumber){
                GameObject.Find("Kan4").GetComponent<Kancontrol>().Oxtest(true);
                oorx = true;
            }else{
                GameObject.Find("Kan4").GetComponent<Kancontrol>().Oxtest(false);
                oorx = false;
            }
        }

        GameObject.Find("Score").GetComponent<ScoreControl>().ScoreChange(oorx); // 스코어 올려줌


        if (GameObject.Find("GuideImg").GetComponent<Kancontrol1>().kanstagestate == 10)
        { // 조건만족시, 게임끝나는시점!
            GameObject.Find("BearNow").GetComponent<Bear>().BearOn(GameObject.Find("Score").GetComponent<ScoreControl>().score);
            GameObject.Find("ExoNow").SetActive(false);
            GameObject.Find("BearNow").SetActive(true);
        }
    }

    private IEnumerator Justrest() // 5번째칸 눌렀을때 실행. 
    {
        yield return new WaitForSeconds(0.3f);
        GameObject.Find("Kan1").GetComponent<Kancontrol>().NewArrow();
            GameObject.Find("Kan2").GetComponent<Kancontrol>().NewArrow();
            GameObject.Find("Kan3").GetComponent<Kancontrol>().NewArrow();
            GameObject.Find("Kan4").GetComponent<Kancontrol>().NewArrow();
            GameObject.Find("Kan5").GetComponent<Kancontrol>().NewArrow();
        
    }
        
    
}