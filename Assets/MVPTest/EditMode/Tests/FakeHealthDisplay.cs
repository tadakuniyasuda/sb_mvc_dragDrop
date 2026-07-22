
using HPTest;
public class FakeHealthDisplay : IHealthDisplay
{
    public string LastMessage;
    public bool LastIsDanger = false;
    public int ShowCallCount;

    public void Show(string message, bool isDanger)
    {
        LastMessage = message;
        LastIsDanger = isDanger;
        ShowCallCount++;

    }
}
