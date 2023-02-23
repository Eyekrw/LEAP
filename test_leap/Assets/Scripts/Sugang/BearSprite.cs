using System.Security.Cryptography;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BearSprite : MonoBehaviour
{
    public GameObject Happybear;
    public Sprite HappybearImg;
    public Sprite BearImg;
    public Sprite SadbearImg;
    public Sprite WhiteImg;
    public SpriteRenderer spriteRenderer;

    void Awake()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = WhiteImg;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

    }

    public void HappyOn(int i)
    {
        if( i >= 0 && i < 2){
        this.gameObject.GetComponent<SpriteRenderer>().sprite = SadbearImg;
        transform.GetChild(2).gameObject.SetActive(true); // ë§žì?ê°?ˆ˜ 0,1ê°?        
        }else if (i >= 2 && i < 4) {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = BearImg;
        transform.GetChild(3).gameObject.SetActive(true); // 2,3ê°?
        }else{
        this.gameObject.GetComponent<SpriteRenderer>().sprite = HappybearImg;
        transform.GetChild(4).gameObject.SetActive(true); // 4, 5ê°?        
        }
        GameObject.Find("Courses").SetActive(false);
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(5).gameObject.SetActive(true);
        GameObject.Find("Score15").GetComponent<ScoreText>().ScoreChange(i);
        
    }


    
}
