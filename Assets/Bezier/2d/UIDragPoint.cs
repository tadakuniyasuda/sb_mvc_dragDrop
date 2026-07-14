using UnityEngine;
using UnityEngine.EventSystems;

public class UIDragPoint : MonoBehaviour, IDragHandler
{
    public UIBezierCurve curve;

    public void OnDrag(PointerEventData e)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)transform.parent, e.position, e.pressEventCamera, out Vector2 local);
        ((RectTransform)transform).anchoredPosition = local;
        curve.SetVerticesDirty();   // triggers OnPopulateMesh rebuild
    }
}