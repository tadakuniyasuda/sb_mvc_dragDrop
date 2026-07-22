using System;

namespace ComboTest { 
    public class ComboModel 
    {
        public int HitNum { get; private set; } = 0;
        public ComboRank comboRank { get; private set; } = ComboRank.Normal;

        public event Action<int> OnHit;
        public event Action<int, ComboRank> OnComboEnded;

        public ComboModel() {
            HitNum = 0;
        }

        public void RegisterHit()
        {
            HitNum++;
            OnHit?.Invoke(HitNum);
        }

        public void ResetCombo()
        {
            if(HitNum >0)
            {
                OnComboEnded?.Invoke(HitNum, comboRank);
            }
            HitNum = 0;
        }

        
 
    }

}