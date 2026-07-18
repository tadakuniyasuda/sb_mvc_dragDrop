using UnityEngine;

public class UI_StatsRaderChart : MonoBehaviour
{

    [SerializeField] Material radarMaterial;
    [SerializeField] Texture2D radarTexture2D;

    private Stats stats;
    [SerializeField] CanvasRenderer randarMeshCanvasRenderer;

    void Awake()
    {
        if (randarMeshCanvasRenderer == null)
        {
            randarMeshCanvasRenderer = transform.Find("RaderMesh").GetComponent<CanvasRenderer>();
        }
    }

    public void SetStats(Stats stats)
    {
        this. stats  = stats;
        
        // delegate
        stats.OnStatsChanged += Stats_OnStatsChanged;

        UpdateStatsVisual();
    }

    // 
    private void Stats_OnStatsChanged(object sender, System.EventArgs e)
    {
        UpdateStatsVisual();
    }
    public void UpdateStatsVisual()
    {
        //transform.Find("AttackBar").localScale = new Vector3(1, stats.GetStatAmountNormalized(Stats.Type.Attack));
        //transform.Find("DefenseBar").localScale = new Vector3(1, stats.GetStatAmountNormalized(Stats.Type.Defense));

        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[6];
        Vector2[] uv = new Vector2[6];
        int[] triangles = new int[3*5];

        float angleIncrement = 360 / 5;
        float radarChartSize = 145f;

        Vector3 attackVertex =  Quaternion.Euler(0, 0, -angleIncrement * 0) * Vector3.up * radarChartSize * stats.GetStatAmountNormalized(Stats.Type.Attack); ;
        int attackVertexIndex = 1;
        Vector3 defenseVertex = Quaternion.Euler(0, 0, -angleIncrement * 1) * Vector3.up * radarChartSize * stats.GetStatAmountNormalized(Stats.Type.Defense);
        int dfenseVertexIndex = 2;
        Vector3 speedVertex = Quaternion.Euler(0, 0, -angleIncrement * 2) * Vector3.up * radarChartSize * stats.GetStatAmountNormalized(Stats.Type.Speed);
        int speedVertexIndex = 3;
        Vector3 manaVertex = Quaternion.Euler(0, 0, -angleIncrement * 3) * Vector3.up * radarChartSize * stats.GetStatAmountNormalized(Stats.Type.Mana);
        int manaVertexIndex = 4;
        Vector3 healthVertex = Quaternion.Euler(0, 0, -angleIncrement * 4) * Vector3.up * radarChartSize * stats.GetStatAmountNormalized(Stats.Type.Health);
        int healthVertexIndex = 5;

        uv[0] = Vector2.zero;
        uv[attackVertexIndex] = Vector2.one;
        uv[dfenseVertexIndex] = Vector2.one;
        uv[speedVertexIndex] = Vector2.one;
        uv[manaVertexIndex] = Vector2.one;
        uv[healthVertexIndex] = Vector2.one;

        vertices[0] = Vector3.zero;
        vertices[attackVertexIndex] = attackVertex;
        vertices[dfenseVertexIndex] = defenseVertex;
        vertices[speedVertexIndex] = speedVertex;
        vertices[manaVertexIndex] = manaVertex;
        vertices[healthVertexIndex] = healthVertex;

        triangles[0] = 0;
        triangles[1] = attackVertexIndex;
        triangles[2] = dfenseVertexIndex;

        triangles[3] = 0;
        triangles[4] = dfenseVertexIndex;
        triangles[5] = speedVertexIndex;

        triangles[6] = 0;
        triangles[7] = speedVertexIndex;
        triangles[8] = manaVertexIndex;

        triangles[9] = 0;
        triangles[10] = manaVertexIndex;
        triangles[11] = healthVertexIndex;

        triangles[12] = 0;
        triangles[13] = healthVertexIndex;
        triangles[14] = attackVertexIndex;


        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;

        randarMeshCanvasRenderer.SetMesh(mesh);
        randarMeshCanvasRenderer.SetMaterial(radarMaterial, radarTexture2D);
    }
}
