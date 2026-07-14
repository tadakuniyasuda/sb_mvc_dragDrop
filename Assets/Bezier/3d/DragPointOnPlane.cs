using UnityEngine;

public class DragPointOnPlane : MonoBehaviour
{
    public Camera cam;
    Transform grabbed;
    Plane dragPlane;

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out RaycastHit hit))
        {
            grabbed = hit.transform;
            // Plane facing the camera, passing through the grabbed point.
            // Use Vector3.up instead if you want dragging along the ground.
            dragPlane = new Plane(-cam.transform.forward, grabbed.position);
        }

        if (grabbed != null && Input.GetMouseButton(0)
            && dragPlane.Raycast(ray, out float dist))
        {
            grabbed.position = ray.GetPoint(dist);
        }

        if (Input.GetMouseButtonUp(0)) grabbed = null;
    }
}