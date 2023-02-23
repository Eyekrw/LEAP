using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckContinue : MonoBehaviour
{
    public void checkContinue()
    {
        if (staticNums.n == 46)
        {
            staticContinues.Enroll.GetComponent<Button>().interactable = true;
        }
        else if (staticNums.n == 114)
        {
            staticContinues.Newteo.GetComponent<Button>().interactable = true;
        }
    }
}
