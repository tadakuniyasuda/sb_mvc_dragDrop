using UnityEngine;
using UnityEngine.UI;

public class UIBezierCurve : Graphic
{
    public RectTransform p0, p1, p2, p3;   // control point UI objects
    public float thickness = 4f;
    public int segments = 40;

    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();

        // Nothing to draw until all four control points exist.
        if (p0 == null || p1 == null || p2 == null || p3 == null)
            return;

        Vector2 prev = Evaluate(0f);
        for (int i = 1; i <= segments; i++)
        {
            Vector2 curr = Evaluate(i / (float)segments);
            AddSegment(vh, prev, curr);
            prev = curr;
        }
    }

    Vector2 Evaluate(float t)
    {
        // Convert control points into THIS graphic's local space
        Vector2 a = Local(p0), b = Local(p1), c = Local(p2), d = Local(p3);
        float u = 1f - t;
        return u * u * u * a + 3f * u * u * t * b + 3f * u * t * t * c + t * t * t * d;
    }

    Vector2 Local(RectTransform rt) =>
        (Vector2)transform.InverseTransformPoint(rt.position);

    void AddSegment(VertexHelper vh, Vector2 a, Vector2 b)
    {
        Vector2 normal = new Vector2(-(b.y - a.y), b.x - a.x).normalized * (thickness * 0.5f);
        int idx = vh.currentVertCount;
        UIVertex v = UIVertex.simpleVert;
        v.color = color;
        v.position = a - normal; vh.AddVert(v);
        v.position = a + normal; vh.AddVert(v);
        v.position = b + normal; vh.AddVert(v);
        v.position = b - normal; vh.AddVert(v);
        vh.AddTriangle(idx, idx + 1, idx + 2);
        vh.AddTriangle(idx, idx + 2, idx + 3);
    }
}