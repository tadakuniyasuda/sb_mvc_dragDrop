using System;

namespace ComboTest2 {
    public class ComboPresenter : IDisposable
    {
        readonly ComboModel _model;
        readonly IComboDisplay _display;

        public ComboPresenter(ComboModel model, IComboDisplay display)
        {
            _model = model;
            _display = display;
            _model.OnHit += HandleHit;
            _model.OnComboEnded += HandleEnd;
        }

        public void HandleHit(int combonum, ComboRank comborank)
        {
            _display.Show(combonum, comborank);

        }

        public void HandleEnd(int combonum, ComboRank comborank)
        {
            _display.ShowComboEnd(combonum, comborank);
        }

        public void Dispose()
        {
            _model.OnHit -= HandleHit;
            _model.OnComboEnded -= HandleEnd;

        }

    }

}