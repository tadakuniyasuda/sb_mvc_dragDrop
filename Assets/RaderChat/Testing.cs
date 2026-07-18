using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] UI_StatsRaderChart _uiStatsRaderChart;
    Stats stats;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stats= new Stats(20,18, 19,17, 18);
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

    public void IncreaseSpeed()
    {
        stats.IncreaseStatAmount(Stats.Type.Speed);
    }

    public void DecreaseSpeed()
    {
        stats.DecreaseStatAmount(Stats.Type.Speed);
    }
    public void IncreaseMana()
    {
        stats.IncreaseStatAmount(Stats.Type.Mana);
    }

    public void DecreaseMana()
    {
        stats.DecreaseStatAmount(Stats.Type.Mana);
    }
    public void IncreaseHealth()
    {
        stats.IncreaseStatAmount(Stats.Type.Health);
    }

    public void DecreaseHealth()
    {
        stats.DecreaseStatAmount(Stats.Type.Health);
    }
}
