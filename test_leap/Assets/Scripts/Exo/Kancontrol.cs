using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// 상단에있는 칸.
public class Kancontrol : MonoBehaviour
{
   public GameObject Kan;
    public Sprite Oimg;
    public Sprite Ximg;
    public Sprite Upimg;
    public Sprite Downimg;
    public Sprite Leftimg;
    public Sprite Rightimg;
    
    public int kanstate;

    public int randomnumber;

    void Awake()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Oimg;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Ximg;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Upimg;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Downimg;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Leftimg;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Rightimg;
        this.NewArrow();

    }

    public void Oxtest(bool value){
        if(value== true){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Oimg;
        }else{
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Ximg;
        }
        
    }

    public void NewArrow() // 버튼에 넣은 lb rb ub db 스크립트에서 특정조건에따라 이 함수가 호출될시, 위쪽 가이드라인 변경.
    {
    
        randomnumber = Random.Range(1, 5);
        //Debug.Log("NewArrowed");
        switch (randomnumber)
        {
            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Upimg;
                kanstate = 1;
                break;

            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Downimg;
                kanstate = 2;
                break;

            case 3:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Leftimg;
                kanstate = 3;
                break;

            case 4:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Rightimg;
                kanstate = 4;
                break;

        }
    }
  
}
