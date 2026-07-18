using UnityEngine;
using System;

namespace HPTest {
    public class HealthPresenter { 
    //    : IDisposable
    //{
    //    readonly HealthModel _model;
    //    readonly IHealthDisplay _view;

    //    public HealthPresenter(HealthModel model, IHealthDisplay view)
    //    {
    //        _model = model;
    //        _view = view;
    //        _model.OnDied += HandleChangeHealth;
    //        _model.OnChanged += HandleChangeHealth;
    //    }

    //    void HandleChangeHealth(int value)
    //    {
    //        string message = $"HP: {value}/{_model.MaxHealth}";
    //        if(value <= 30)
    //        {
    //            _view.isDanger = true;

    //            if(value <= 0)
    //            {
    //                _view.Died();
    //            }
    //        }

            
    //    }

    //    void HandleDeath()
    //    {
    //        _view
    //    }

    //    public void Dispose()
    //    {
    //        _model.OnDied -= HandleDeath;
    //        _model.OnChanged -= HandleChangeHealth;
    //    }
    }
}