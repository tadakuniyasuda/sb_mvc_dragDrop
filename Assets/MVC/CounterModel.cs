

using System;

public class CounterModel 
{
    public int Count { get; private set; }
    public event Action<int> OnCountChanged;

    public void Increment()
    {
        Count++;
        OnCountChanged?.Invoke(Count);
    }
}


