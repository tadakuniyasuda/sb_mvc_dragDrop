using System;

namespace HPTest
{
    public class HealthModel
    {
        public int MaxHealth { private set; get; } = 100;

        public int Health { private set; get; } = 50;

        public HealthModel(int maxHealth =100, int health = 50)
        {
            MaxHealth = maxHealth;
            Health = health;
        }

        public event Action OnDied;
        public event Action<int> OnChanged;
        public void TakeDamage(int amount)
        {
            Health = Math.Max(Health - amount, 0);
            OnChanged?.Invoke(Health);
            if(Health <=0)
            {

                OnDied?.Invoke();
            }
        }

        public void Heal(int amount)
        {
            Health = Math.Min(Health + amount, MaxHealth);
            OnChanged?.Invoke(Health);
        }

    }
}