using System;
using UnityEngine;

public class Stats
{
    // EventHandler
    public event EventHandler OnStatsChanged;

    public static int STAT_MIN = 0;
    public static int STAT_MAX = 20;

    public enum Type
    {
        Attack,
        Defense,
        Speed,
        Mana,
        Health
    }

    private SingleStat attackStat;
    private SingleStat defenseStat;
    private SingleStat speedStat;
    private SingleStat manaStat;
    private SingleStat healthStat;



    public Stats(int AttackStatAmount, int defenseStatAmount, int speedStatAmount, int manaStatAmount, int healthStatAmount)
    {
        attackStat = new SingleStat(AttackStatAmount);
        defenseStat = new SingleStat(defenseStatAmount);
        speedStat = new SingleStat(speedStatAmount);
        manaStat = new SingleStat(manaStatAmount);
        healthStat = new SingleStat(healthStatAmount);
    }

    private SingleStat GetSingleStat(Type statType)
    {
        switch(statType)
        {
            default:
            case Type.Attack: return attackStat;
            case Type.Defense: return defenseStat;
            case Type.Speed: return speedStat;
            case Type.Mana: return manaStat;
            case Type.Health: return healthStat;
        }
    }

    public void SetStatAmount(Type statType, int statAmount)
    {
        GetSingleStat(statType).SetStatAmount(statAmount);
        // invoke EventHandler
        OnStatsChanged?.Invoke(this, EventArgs.Empty);
    }

    public void IncreaseStatAmount(Type statType)
    {
        SetStatAmount(statType, GetStatAmount(statType)+1);
    }

    public void DecreaseStatAmount(Type statType)
    {
        SetStatAmount(statType, GetStatAmount(statType) - 1);
    }
    public int GetStatAmount(Type statType)
    {

        return GetSingleStat(statType).GetStatAmount();
    }

    public float GetStatAmountNormalized(Type statType)
    {

        return GetSingleStat(statType).GetStatAmountNormalized();
    }

    private class SingleStat
    {
        private int Stat;

        public SingleStat(int statAmount)
        {
            SetStatAmount(statAmount);
        }

        public void SetStatAmount(int attackStatAmount)
        {
            Stat = Mathf.Clamp(attackStatAmount, STAT_MIN, STAT_MAX);
        }

        public int GetStatAmount()
        {
            return Stat;
        }

        public float GetStatAmountNormalized()
        {
            return (float)Stat / STAT_MAX;
        }

    }
}
