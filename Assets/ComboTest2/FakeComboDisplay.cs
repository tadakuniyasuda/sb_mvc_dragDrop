using System;

namespace ComboTest2 {
    public class FakeComboDisplay : IComboDisplay
    {
        public int LastComboNum;
        public ComboRank LastRank;
        public int ShowCallCount;

        public int LastEndNum;
        public ComboRank LastEndRank;
        public int EndedCallCount;

        public void Show(int combonum, ComboRank comborank)
        {
            LastComboNum = combonum;
            LastRank = comborank;
            ShowCallCount++;
        }

        public void ShowComboEnd(int comboNum, ComboRank comborank)
        {
            LastEndNum= comboNum;
            LastEndRank= comborank;
            EndedCallCount ++;
        }
    }
}