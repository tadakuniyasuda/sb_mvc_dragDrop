using HPTest;
using UnityEngine;
using UnityEngine.InputSystem;

public class HealthTest : MonoBehaviour
{
    HealthModel _model;
    IHealthDisplay _view;
    HealthPresenter healthPresenter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _model = new HealthModel();
        _view = GetComponent<HealthDisplay>();
        healthPresenter = new HealthPresenter(_model, _view);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        //if (Input.GetKeyDown(KeyCode.Space))
        {
            _model.TakeDamage(10);
        }

        if (Keyboard.current.hKey.wasPressedThisFrame)
        //if (Input.GetKeyDown(KeyCode.H))
        {
            _model.Heal(5);
        }
    }

    void OnDestroy()
    {
        healthPresenter?.Dispose();
    }
}
