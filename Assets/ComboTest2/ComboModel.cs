
using System;

namespace ComboTest2 {

    public enum ComboRank
    {
        Normal,
        Great,
        Amazing
    }

    public class ComboModel
    {
        public int HitNum{ get; private set; } = 0;
        public ComboRank ComboRank { get; private set; } = ComboRank.Normal;

        public event Action<int, ComboRank> OnHit;

        public event Action<int, ComboRank> OnComboEnded;

        public void RegisterHit()
        {
            HitNum++;

            if (HitNum >= 10)
            {
                ComboRank = ComboRank.Amazing;
            }
            else if (HitNum < 10 && HitNum > 5)
            {
                ComboRank = ComboRank.Great;
            }
            else
            {
                ComboRank = ComboRank.Normal;
            }
            OnHit?.Invoke(HitNum, ComboRank);
        }

        public void ComboEnd()
        {
            if(HitNum >0)
            {
                OnComboEnded?.Invoke(HitNum, ComboRank);
            }
            HitNum = 0;
            ComboRank = ComboRank.Normal;
        }


    }
}