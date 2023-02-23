using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Course4 : MonoBehaviour
{
        public GameObject Four;
    private GameObject OXtext;
    private RectTransform rectTransform;
    public float FourPos;
    private Vector2 vector2;

    void Awake()
    {
         GameObject Four = new GameObject(); 
         rectTransform = GetComponent<RectTransform>();
         OXtext = transform.Find("OX").gameObject;
         Debug.Log(transform.GetChild(1).name);
    }

    void Update()
    {
        //vector2 = this.transform.position.y;
        FourPos = this.rectTransform.position.y;
        //Debug.Log(FourPos);
        if(FourPos >790 && FourPos < 960){
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else{
            transform.GetChild(1).gameObject.SetActive(false);
        }
        
    }
}
