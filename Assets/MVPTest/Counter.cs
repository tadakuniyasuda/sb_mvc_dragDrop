using System;

public class Counter
{
    public int Value { get; private set; } = 0;

    public event Action<int> OnChanged;
    public event Action OnReachedTen;
    public void Increment()
    {
        Value++;
        OnChanged?.Invoke(Value);

        if(Value >= 10)
        {
            OnReachedTen?.Invoke();
        }
    }

    

}