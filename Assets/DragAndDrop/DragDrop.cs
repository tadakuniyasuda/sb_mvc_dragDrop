using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;


public class DragDrop : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler, IDropHandler
{
    Transform transform;
   void Start()
    {
        transform = GetComponent<Transform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position += new Vector3(eventData.delta.x/100, eventData.delta.y/100, 0);

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer Down");

    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("[DragDrop.cs] Dropped");
    }

    //public void 
}
