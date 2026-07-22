using System;
using ComboTest;

namespace ComboTest {

    public enum ComboRank
    {
        Normal, // 0
        Great,  //1
        Amazing //2
    }
    public class ComboPresenter : IDisposable
    {
        readonly ComboModel _model;
        readonly IComboDisplay _view;

        ComboRank currentRank;

        public ComboPresenter( ComboModel combomodel, IComboDisplay view )
        {
            _model = combomodel;
            _view = view;
            _model.OnHit += HandleHit;
            _model.OnComboEnded += HandleReset;
        }

        public void HandleHit(int hitnum)
        {

            if (hitnum >= 5 && hitnum < 10)
            {
                currentRank = ComboRank.Great;
            }else if (hitnum >= 10)
            {
                currentRank = ComboRank.Amazing;
            }
            else
            {
                currentRank = ComboRank.Normal;

            }
            _view.Show(hitnum, currentRank);

        }

        public void HandleReset(int hitnum, ComboRank currentRank)
        {
            _view.ShowComboEnded(hitnum, currentRank);
            ResetRank();
        }

        public void ResetRank()
        {
            currentRank = ComboRank.Normal;
        }

        public void Dispose()
        {
            _model.OnHit -= HandleHit;
            _model.OnComboEnded -= HandleReset;
        }

    }

}