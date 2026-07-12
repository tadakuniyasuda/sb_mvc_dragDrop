
using UnityEngine;

public class CounterInstaller
{
    [SerializeField] CounterView view;
    CounterPresenter presenter;

    void Awkae()
    {
        var model = new CounterModel();
        presenter = new CounterPresenter(model, view);
    }
}