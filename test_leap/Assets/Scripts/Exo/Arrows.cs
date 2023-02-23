using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrows : MonoBehaviour //스테이지....
{
    // Start is called before the first frame update
    public int stage =1;
    public GameObject GuideImg;
    

    private void Awake()
    {
        stage = 1;
    }
        void Start()
    {
        Debug.Log (stage);


    }

    public void ImgChange()
    {  // stage 가 1로 초기화될때, 위에 가이드용 화살표 다섯개를 랜덤으로 바꿔줌.
        Debug.Log("ImgChanged");
        
    }

}
