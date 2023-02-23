using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextSceneButton : MonoBehaviour, IPointerDownHandler
{
    public GameObject NextButton;
    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene("Firstgrade1");

    }
}
