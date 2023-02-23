using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;         

public class Course6 : MonoBehaviour
{
    public GameObject Six;
    private GameObject OXtext;
    private RectTransform rectTransform;
    public float SixPos;
    private Vector2 vector2;
    public Text oorx6;
    void Start(){
        oorx6.text = "X";
    }
    void Awake()
    {
         rectTransform = GetComponent<RectTransform>();
         OXtext = transform.Find("OX").gameObject;
         //Debug.Log(transform.GetChild(1).name);
    }

    
    public void Test6()
    {
        SixPos = this.rectTransform.position.y;
        //Debug.Log(SixPos);
        if(SixPos >-1 && SixPos < 4){
            oorx6.text = "O";
            GameObject.Find("FinishButton").GetComponent<TestButton>().howmanyclear += 1;
        }
        else{
           oorx6.text = "X";
        }
        transform.GetChild(1).gameObject.SetActive(true);
    }
}
