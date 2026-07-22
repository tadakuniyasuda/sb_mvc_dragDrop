using NUnit.Framework;

namespace ComboTest2 { 
    public class ComboTests2 
    {
        //[Test]
        //public void RegisterHit_ThreeTimes()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for(int i = 0; i<3; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    Assert.AreEqual(3, comboModel.HitNum);
        //}

        //[Test]
        //public void RegisterHitTriggers_OnHitFired()
        //{
        //    bool OnHitFired = false;
        //    ComboModel comboModel = new ComboModel();
        //    comboModel.OnHit += (int HitNum, ComboRank rank) => OnHitFired = true;
        //    comboModel.RegisterHit();
        //    Assert.IsTrue(OnHitFired);
        //}

        //[Test]
        //public void HitThreeTimes_ComboRankNormal()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for(int i = 0; i<3; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    Assert.AreEqual(ComboRank.Normal, comboModel.ComboRank);
        //}


        //[Test]
        //public void HitFiveTime_ComboRankNormal()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    Assert.AreEqual(ComboRank.Normal, comboModel.ComboRank);
        //}
        //[Test]
        //public void HitSixTime_ComboRankNormal()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for (int i = 0; i < 6; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    Assert.AreEqual(ComboRank.Great, comboModel.ComboRank);
        //}

        //[Test]
        //public void HitNineTime_ComboRankNormal()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for (int i = 0; i < 9; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    Assert.AreEqual(ComboRank.Great, comboModel.ComboRank);
        //}
        //[Test]
        //public void HitTenTime_ComboRankNormal()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    Assert.AreEqual(ComboRank.Amazing, comboModel.ComboRank);
        //}
        //[Test]
        //public void HitElevenTime_ComboRankNormal()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for (int i = 0; i < 11; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    Assert.AreEqual(ComboRank.Amazing, comboModel.ComboRank);
        //}

        //[Test]
        //public void Reset_AfterCombo_ComboShouldBeZero()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    comboModel.ResetCombo();
        //    Assert.AreEqual(0, comboModel.HitNum);
        //}
        //[Test]
        //public void Reset_AfterCombo_RankShouldBeNormal()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for (int i = 0; i < 50; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    comboModel.ResetCombo();
        //    Assert.AreEqual(ComboRank.Normal, comboModel.ComboRank);
        //}

        //[Test]
        //public void Reset_ThenThreeTimesHitCounted()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for (int i = 0; i < 3; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    comboModel.ResetCombo();
        //    for (int i = 0; i < 3; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    Assert.AreEqual(3, comboModel.HitNum);
        //}

        //[Test]
        //public void Reset_Then6TimesHitCounted()
        //{
        //    ComboModel comboModel = new ComboModel();
        //    for (int i = 0; i < 3; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    comboModel.ResetCombo();
        //    for (int i = 0; i < 6; i++)
        //    {
        //        comboModel.RegisterHit();
        //    }
        //    Assert.AreEqual(ComboRank.Great, comboModel.ComboRank);
        //}
    }

}