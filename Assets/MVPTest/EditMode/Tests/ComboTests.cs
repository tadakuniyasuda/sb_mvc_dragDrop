using NUnit.Framework;


namespace ComboTest { 

    
    public class ComboTests 
    {
        [Test]
        public void RegisterHit_IncrementHit()
        {
            ComboModel comboModel = new ComboModel();
            comboModel.RegisterHit();
            comboModel.RegisterHit();
            comboModel.RegisterHit();
            Assert.AreEqual(3, comboModel.HitNum);
        }

        [Test]
        public void ZeroHitNum_Reset()
        {
            ComboModel comboModel = new ComboModel();
            bool onComboEndedCalled = false;
            comboModel.OnComboEnded += (int hitNum, ComboRank currentRank) => onComboEndedCalled = true;
            comboModel.ResetCombo();
            Assert.IsFalse(onComboEndedCalled);
        }

        [Test]
        public void RegisterHit_Ignited()
        {
            ComboModel comboModel = new ComboModel();
            bool OnHitCalled = false;
            comboModel.OnHit += (int hit)=> OnHitCalled = true;
            comboModel.RegisterHit();
            Assert.IsTrue(OnHitCalled);
        }

        [Test]
        public void Reset_Ignited()
        {
            ComboModel comboModel = new ComboModel();
            bool onComboEndedCalled = false;
            comboModel.OnComboEnded += (int hitNum, ComboRank currentRank) => onComboEndedCalled = true;
            comboModel.RegisterHit();
            comboModel.RegisterHit();
            comboModel.RegisterHit();
            comboModel.ResetCombo();
            Assert.IsTrue(onComboEndedCalled);
        }

        //[Test]
        //public void ResetCombo_ReportsFinalHitCount()
        //{
        //    var comboModel = new ComboModel();
        //    int reportedCount = -1;
        //    comboModel.OnComboEnded += count => reportedCount = count;
        //    for(int i = 0; i<3; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }   

        //    comboModel.ResetCombo();
        //    Assert.AreEqual(3, reportedCount);
        //}

        [Test]
        public void ResetCombo_SetHitNumToZero()
        {
            var comboModel = new ComboModel();
            comboModel.RegisterHit();
            comboModel.RegisterHit();
            comboModel.RegisterHit();
            comboModel.ResetCombo();
            Assert.AreEqual(0, comboModel.HitNum);
        }
        [Test]
        public void Reset_AllowsNewComboToStartFresh()
        {
            var comboModel = new ComboModel();
            for (int i = 0; i < 3; i++)
            {
                comboModel.RegisterHit();
            }
            comboModel.ResetCombo();
            comboModel.RegisterHit();
            Assert.AreEqual(comboModel.HitNum, 1);
        }
    }

}