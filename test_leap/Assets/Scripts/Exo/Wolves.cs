using System.Security.Cryptography;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Wolves : MonoBehaviour
{
    public Sprite[]  wolves;
    public Vector2 wolfpos;
    public Transform wolftransform;
    public int whatwolf;
    public double whatwolfpos;
    void Awake()
    {
        wolftransform = GetComponent<Transform>();
        this.gameObject.GetComponent<SpriteRenderer>().sprite = wolves[0];
        this.gameObject.GetComponent<SpriteRenderer>().sprite = wolves[1];
        this.gameObject.GetComponent<SpriteRenderer>().sprite = wolves[2];
    }
    public void ChangeWolf(){ 
        whatwolf = Random.Range(0,3);
        
        this.gameObject.GetComponent<SpriteRenderer>().sprite = wolves[whatwolf];
    }
}
