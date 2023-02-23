using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       
public class Course2 : MonoBehaviour
{
    public GameObject Two;
    private GameObject OXtext;
    private RectTransform rectTransform;
    public float TwoPos;
    private Vector2 vector2;
    public Text oorx2;
    void Start(){
        oorx2.text = "X";
    }
    void Awake()
    {
         rectTransform = GetComponent<RectTransform>();
         OXtext = transform.Find("OX").gameObject;
         //Debug.Log(transform.GetChild(1).name);
    }

    
    public void Test2()
    {
        TwoPos = this.rectTransform.position.y;
        //Debug.Log(TwoPos);
        if(TwoPos >2.23 && TwoPos < 3.2){
            oorx2.text = "O";
            GameObject.Find("FinishButton").GetComponent<TestButton>().howmanyclear += 1;
        }
        else{
           oorx2.text = "X";
        }
        transform.GetChild(1).gameObject.SetActive(true);
    }
}
