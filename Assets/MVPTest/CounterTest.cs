using UnityEngine;
//using UnityEngine.InputSystem;

public class CounterTest : MonoBehaviour
{
    Counter _counter;
    _CounterPresenter _presenter;

    void Start()
    {
        _counter = new Counter();

        IDisplay display = GetComponent<LabelDisplay>();
        _presenter = new _CounterPresenter(_counter, display);

        
    }

    void Update()
    {
        //if(Keyboard.current.spaceKey.wasPressedThisFrame)
        //{
        //    _counter.Increment();
        //}
    }

    void OnDestroy()
    {
        _presenter?.Dispose();
    }
}
