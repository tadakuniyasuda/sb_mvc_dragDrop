using UnityEngine;

public class UI_StatsRaderChart : MonoBehaviour
{

    private Stats stats;

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
        transform.Find("AttackBar").localScale = new Vector3(1, stats.GetStatAmountNormalized(Stats.Type.Attack));
        transform.Find("DefenseBar").localScale = new Vector3(1, stats.GetStatAmountNormalized(Stats.Type.Defense));

    }
}
