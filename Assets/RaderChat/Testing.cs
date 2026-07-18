using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] UI_StatsRaderChart _uiStatsRaderChart;
    Stats stats;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stats= new Stats(10,2);
        _uiStatsRaderChart.SetStats(stats);

        

        //CMDebug.ButtonUI(new Vector2(200, 20), "ATK++", () => stats.IncreaseAttackStatAmount);
        //CMDebug.ButtonUI(new Vector2(200, -20), "ATK++", () => stats.DecreaseAttackStatAmount);
    }

    public void IncreaseAttack()
    {
        stats.IncreaseStatAmount(Stats.Type.Attack);
    }

    public void DecreaseAttack()
    {
        stats.DecreaseStatAmount(Stats.Type.Attack);
    }

    public void IncreaseDefense()
    {
        stats.IncreaseStatAmount(Stats.Type.Defense);
    }

    public void DecreaseDefense()
    {
        stats.DecreaseStatAmount(Stats.Type.Defense);
    }

}
