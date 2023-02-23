using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       
public class Course1 : MonoBehaviour
{
   public GameObject One;
    private GameObject OXtext;
    private RectTransform rectTransform;
    public float OnePos;
    private Vector2 vector2;
    public Text oorx1;
    void Start(){
        oorx1.text = "X";
    }
    void Awake()
    {
         rectTransform = GetComponent<RectTransform>();
         OXtext = transform.Find("OX").gameObject;
         //Debug.Log(transform.GetChild(1).name);
    }

    public void Test1()
    {
        OnePos = this.rectTransform.position.y;
        //Debug.Log(OnePos);
        if(OnePos >2.9348 && OnePos < 3.95){
            oorx1.text = "O";
            GameObject.Find("FinishButton").GetComponent<TestButton>().howmanyclear += 1;
        }
        else{
           oorx1.text = "X";
        }
        transform.GetChild(1).gameObject.SetActive(true);
    }
}
