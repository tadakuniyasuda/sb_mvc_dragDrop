using System;


public class _CounterPresenter : IDisposable
{
    readonly Counter _model;
    readonly IDisplay _view;

    public _CounterPresenter(Counter model, IDisplay view)
    {
        _model = model;
        _view = view;
        _model.OnChanged += HandleChanged;
    }

    void HandleChanged(int value)
    {
        string message = $"The count is {value}";
        if(value %3 == 0)
        {
            message += "🎉";
        }

        _view.Show(message);
    }
    public void Dispose()
    {
        _model.OnChanged -= HandleChanged;
    }
}
