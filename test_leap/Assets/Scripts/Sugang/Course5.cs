using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;         
public class Course5 : MonoBehaviour
{
    public GameObject Five;
    private GameObject OXtext;
    private RectTransform rectTransform;
    public float FivePos;
    private Vector2 vector2;
    public Text oorx5;
    void Start(){
        oorx5.text = "X";
    }
    void Awake()
    {
         rectTransform = GetComponent<RectTransform>();
         OXtext = transform.Find("OX").gameObject;
         //Debug.Log(transform.GetChild(1).name);
    }

   
    public void Test5()
    {
        FivePos = this.rectTransform.position.y;
        //Debug.Log(FivePos);
        if(FivePos >0.8 && FivePos < 3.5){
            oorx5.text = "O";
            GameObject.Find("FinishButton").GetComponent<TestButton>().howmanyclear += 1;
        }
        else{
           oorx5.text = "X";
        }
        transform.GetChild(1).gameObject.SetActive(true);
    }
}
