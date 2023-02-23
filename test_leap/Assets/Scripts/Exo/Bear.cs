using System.Security.Cryptography;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Bear : MonoBehaviour
{
    public GameObject Bearnow;
    public Sprite HappybearImg1;
    public Sprite BearImg1;
    public Sprite SadbearImg1;
    public Sprite WhiteImg1;
    public SpriteRenderer spriteRenderer1;

    void Awake()
    {
        //spriteRenderer1.sprite = WhiteImg1;
        SpriteRenderer spriteRenderer1 = GetComponent<SpriteRenderer>();

    }

    public void BearOn(int i)
    {
        //spriteRenderer1.sprite = SadbearImg1;
        //Debug.Log(GameObject.Find("Score").GetComponent<ScoreControl>().score);
        transform.GetChild(2).gameObject.SetActive(true);
        transform.GetChild(6).gameObject.SetActive(true);
        StartCoroutine (ExoResulttextOn(i));
        //GameObject.Find("Score15").GetComponent<ScoreText>().ScoreChange(i);
        

    }
     private IEnumerator ExoResulttextOn(int i) // 다섯번째 버튼 눌렀을 때, 잠깐 쉬는타임!
    {
        yield return new WaitForSeconds(0.7f);
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        
        GameObject.Find("Score100").GetComponent<ScoretextExo>().ScoreExoChange(i); // 입학식무대 몇점이었어.
        yield return new WaitForSeconds(1.0f);

        if( i < 100){
        spriteRenderer1.sprite = SadbearImg1;
        transform.GetChild(3).gameObject.SetActive(true); // 맞은갯수 0,1개
        
        }else if (i >= 100 && i < 200) {
        spriteRenderer1.sprite = BearImg1;
        transform.GetChild(4).gameObject.SetActive(true); // 2,3개 
        }else{
        spriteRenderer1.sprite = HappybearImg1;
        transform.GetChild(5).gameObject.SetActive(true); // 4, 5개
        
        }
    }


    
}