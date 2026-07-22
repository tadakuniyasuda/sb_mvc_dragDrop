using System;

namespace HPTest {
    public class HealthPresenter : IDisposable
    { 
        readonly HealthModel _model;
        readonly IHealthDisplay _view;

        public HealthPresenter(HealthModel model, IHealthDisplay view)
        {
            _model = model;
            _view = view;
            _model.OnDied += HandleDeath;
            _model.OnChanged += HandleChangeHealth;
        }

        void HandleChangeHealth(int value)
        {
            bool isDanger = value <= (0.3 * _model.MaxHealth);
            string message = $"HP: {value}/{_model.MaxHealth}";


            if (isDanger)
            {
                message += $"   Warning!";
            }


            _view.Show(message, isDanger);
        }

        void HandleDeath()
        {
            string message = "Gameover!";
            _view.Show(message, false);
        }

        public void Dispose()
        {
            _model.OnDied -= HandleDeath;
            _model.OnChanged -= HandleChangeHealth;
        }
    }
}