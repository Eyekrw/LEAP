using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeFilePath : MonoBehaviour
{
    public string[] filePath;
    public string presentFilePath;
    public int fn;

    void Start()
    {
        filePath = new string[5];
        filePath[0] = "C:/Users/yegirl/UnityProjects/test_leap/Assets/Story/script1.txt";
        filePath[1] = "C:/Users/yegirl/UnityProjects/test_leap/Assets/Story/NewMT.txt";
    }
    void Update()
    {
        presentFilePath = filePath[fn];
    }
}
