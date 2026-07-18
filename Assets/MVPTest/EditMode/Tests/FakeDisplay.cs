public class FakeDisplay : IDisplay
{
    public string LastMessage;
    public bool LastEmphasis;
    public int ShowCallCount;

    //public void Show(string message, bool emphasis)
    //{
    //    LastMessage = message;
    //    LastEmphasis = emphasis;
    //    ShowCallCount++;
    //}

    public void Show(string message)
    {
        LastMessage = message;
        //LastEmphasis;
        ShowCallCount++;
}
}