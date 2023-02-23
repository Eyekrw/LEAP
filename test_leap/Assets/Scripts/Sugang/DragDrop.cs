using System.Security.Cryptography;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//오브젝트에 드래그 드롭 기능 부여하는 컴포넌트
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;
    public RectTransform rectTransformRn;
    private CanvasGroup canvasGroup;
    private Vector2 vector2;

    private void Awake()
    {
        
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag (PointerEventData eventData){
        Debug.Log ("OnBeginDrag");

        rectTransformRn = this.GetComponent<RectTransform>();
     //   canvasGroup.alpha = .6f;
     //   canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag (PointerEventData eventData){
        // Debug.Log ("OnDrag");

        vector2 = eventData.delta / canvas.scaleFactor;
        vector2.x = 0;
       
        // Debug.Log(vector2);
        rectTransformRn.anchoredPosition += vector2;
    }

    public void OnEndDrag (PointerEventData eventData){
        //Debug.Log ("OnendDrag");
    }

    public void OnPointerDown (PointerEventData eventData){
       // Debug.Log ("OnPointerDown");
    }

    public void OnDrop(PointerEventData eventData){
      //  throw new System.NotImplementedException();
    }
    
}
