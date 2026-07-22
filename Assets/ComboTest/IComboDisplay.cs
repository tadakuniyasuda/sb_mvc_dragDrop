using ComboTest;
using System;

namespace ComboTest { 
    public interface IComboDisplay 
    {
        void Show(int ComboNum, ComboRank rank);

        void ShowComboEnded(int finalCount, ComboRank finalRank);
    }

}