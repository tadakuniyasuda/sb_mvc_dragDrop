using UnityEngine;

public class CounterPresenter : MonoBehaviour
{
    readonly CounterModel model;
    readonly CounterView view;

    public CounterPresenter (CounterModel model, CounterView view)
    {
        this.model = model;
        this.view = view;

        view.OnButtonClicked += HandleButtonClicked;
        model.OnCountChanged += HandleCountChanged;
        view.UpdateDisplay(model.Count);
    }

    void HandleButtonClicked()
    {
        model.Increment();
    }

    void HandleCountChanged(int newCount)
    {
        view.UpdateDisplay(newCount);
    }
}