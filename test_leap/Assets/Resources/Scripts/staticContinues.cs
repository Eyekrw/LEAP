using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticContinues : MonoBehaviour
{
    static public GameObject Enroll;
    static public GameObject Newteo;

    void Start()
    {
        Enroll = GameObject.Find("Enroll").gameObject;
        Newteo = GameObject.Find("Newteo").gameObject;
    }
}
