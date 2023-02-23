using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       
public class Course3 : MonoBehaviour
{
    public GameObject Three;
    private GameObject OXtext;
    private RectTransform rectTransform;
    public float ThreePos;
    private Vector2 vector2;
    public Text oorx3;
    void Start(){
        oorx3.text = "X";
    }
    void Awake()
    {
         rectTransform = GetComponent<RectTransform>();
         OXtext = transform.Find("OX").gameObject;
         //Debug.Log(transform.GetChild(1).name);
    }

    
    public void Test3()
    {
        ThreePos = this.rectTransform.position.y;
        //Debug.Log(ThreePos);
        if(ThreePos >1.5 && ThreePos < 2.5){
            oorx3.text = "O";
            GameObject.Find("FinishButton").GetComponent<TestButton>().howmanyclear += 1;
        }
        else{
           oorx3.text = "X";
        }
        transform.GetChild(1).gameObject.SetActive(true);
    }
}

