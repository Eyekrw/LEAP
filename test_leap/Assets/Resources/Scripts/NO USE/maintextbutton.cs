using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class maintextbutton : MonoBehaviour
{
    GameObject backG = new GameObject();
    [HideInInspector]
    public GameObject presentB = new GameObject();
    public int flag = 0;
    public int flag_memo;
    void Start()
    {
        backG = GameObject.Find("backgrounds");
        flag_memo = GameObject.Find("maintext").GetComponent<memojang>().flag;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextPage()
    {
        presentB = backG.transform.GetChild(flag).gameObject;
        presentB.SetActive(true);
        flag++;
        if (flag > 2)
        {
            SceneManager.LoadScene("save2");
        }
    }
}
