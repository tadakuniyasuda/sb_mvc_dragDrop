using UnityEngine;
using UnityEngine.InputSystem;

public class RaySelector : MonoBehaviour
{
    readonly RaycastHit[] _hits = new RaycastHit[5];
    [SerializeField] float durationTime = 1.0f;
    float currentTime = 0.0f;
    // Update is called once per frame


    SelectableItem closestItem = null;
    float ClosestDist = 0.0f;

    void Update()
    {
        if(Mouse.current.leftButton.isPressed)
        {
            if (Time.time  > durationTime + currentTime)
            {

                //Debug.Log(Mouse.current.position.ReadValue());
                Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());

                int hitCount = Physics.RaycastNonAlloc(ray, _hits, 100f);
                Debug.Log(hitCount);
                if(hitCount > 0)
                { 
                    //Debug.Log("first : " + _hits[0].collider.gameObject.name);

                    for (int i = 0; i < hitCount; i++)
                    {
                        if (_hits[i].distance >ClosestDist )
                        {
                            closestItem = _hits[i].collider.GetComponent<SelectableItem>();
                            ClosestDist = _hits[i].distance;
                        }
                    }
                    Debug.Log($"The Closest item is: {closestItem.itemName} at {ClosestDist:F2}");
                    //SelectableItem item = _hits[i].collider.GetComponent<SelectableItem>();
                    //Debug.Log($"{i}: {_hits[i].collider.name} dist:{_hits[i].distance:F2} | SelectableItem Found: {item?.itemName: 'none'}");

                    currentTime += durationTime;
                }
            }
        }
    }
}
