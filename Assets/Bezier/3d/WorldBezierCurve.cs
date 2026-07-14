using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class WorldBezierCurve : MonoBehaviour
{
    public Transform p0, p1, p2, p3;
    public int segments = 40;
    LineRenderer line;

    void Awake() => line = GetComponent<LineRenderer>();

    void Update()
    {
        line.positionCount = segments + 1;
        for (int i = 0; i <= segments; i++)
        {
            float t = i / (float)segments;
            float u = 1f - t;
            Vector3 pos = u * u * u * p0.position + 3f * u * u * t * p1.position
                        + 3f * u * t * t * p2.position + t * t * t * p3.position;
            line.SetPosition(i, pos);
        }
    }
}