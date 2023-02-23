using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextSceneButtonfromExo : MonoBehaviour, IPointerDownHandler
{
    public GameObject NextButtonfromExo;
    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene("FirstGrade1");

    }
}
