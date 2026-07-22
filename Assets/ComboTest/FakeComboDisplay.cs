
namespace ComboTest { 
    public class FakeComboDisplay : IComboDisplay
    {
        public int LastComboNum;
        public ComboRank LastRank;
        public int ShowCallCount;
        public void Show(int ComboNum, ComboRank rank)
        {
            LastComboNum = ComboNum;
            LastRank = rank;
            ShowCallCount++;
        }

        public void ShowComboEnded(int finalCount, ComboRank finalRank)
        {
            LastComboNum = finalCount;
            LastRank = finalRank;
        }
    }

}