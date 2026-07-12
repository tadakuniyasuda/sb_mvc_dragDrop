using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Dropped");
        if(eventData.pointerDrag !=null)
        {
            eventData.pointerDrag.GetComponent<Transform>().position = GetComponent<Transform>().position;
            //eventData.pointerDrag.GetComponent<Transform>().position = GetComponent<Transform>().position;
        
        }

        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
