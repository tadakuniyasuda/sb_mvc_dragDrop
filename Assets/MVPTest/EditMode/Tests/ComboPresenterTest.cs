using ComboTest;
using NUnit.Framework;

namespace ComboTest { 
public class ComboPresenterTest
{
    [Test]
    public void IncrementHit_ViewReceiveHitNum()
    {
        ComboModel model = new ComboModel();
        FakeComboDisplay fakeView  = new FakeComboDisplay();
        ComboPresenter presenter = new ComboPresenter(model, fakeView);
        for(int i = 0; i<5; i++)
        {
            model.RegisterHit();
        }
        Assert.AreEqual(5, fakeView.LastComboNum);
    }

    [Test]
    public void Reset_AndHitThreeTimes()
    {
        ComboModel model = new ComboModel();
        FakeComboDisplay fakeView = new FakeComboDisplay();
        ComboPresenter presenter = new ComboPresenter(model, fakeView);
        
        for (int i = 0; i < 5; i++)
        {
            model.RegisterHit();
        }

        model.RegisterHit();

        model.ResetCombo();

        for (int i = 0; i < 3; i++)
        {
            model.RegisterHit();
        }
        Assert.AreEqual(3, fakeView.LastComboNum);
    }

    [Test]
    public void IncrementHit_ViewReceiveHitRank()
    {
        ComboModel model = new ComboModel();
        FakeComboDisplay fakeView = new FakeComboDisplay();
        ComboPresenter presenter = new ComboPresenter(model, fakeView);

        model.RegisterHit();
        Assert.AreEqual(ComboRank.Normal, fakeView.LastRank);
    }


    [Test]
    public void HitFourTimes_viewRankNormal()
    {
        ComboModel model = new ComboModel();
        FakeComboDisplay fakeView = new FakeComboDisplay();
        ComboPresenter presenter = new ComboPresenter(model, fakeView);
        for (int i = 0; i < 4; i++)
        {
            model.RegisterHit();
        }
        Assert.AreEqual(ComboRank.Normal, fakeView.LastRank);
    }

    [Test]
    public void IncrementHit_viewRankGreat()
    {
        ComboModel model = new ComboModel();
        FakeComboDisplay fakeView = new FakeComboDisplay();
        ComboPresenter presenter = new ComboPresenter(model, fakeView);
        for (int i = 0; i < 5; i++)
        {
            model.RegisterHit();
        }
        Assert.AreEqual(ComboRank.Great, fakeView.LastRank);
    }

    [Test]
    public void HitNineTimes_viewRankGreat()
    {
        ComboModel model = new ComboModel();
        FakeComboDisplay fakeView = new FakeComboDisplay();
        ComboPresenter presenter = new ComboPresenter(model, fakeView);
        for (int i = 0; i < 9; i++)
        {
            model.RegisterHit();
        }
        Assert.AreEqual(ComboRank.Great, fakeView.LastRank);
    }
    [Test]
    public void IncrementHit_ViewRankAmazing()
    {
        ComboModel model = new ComboModel();
        FakeComboDisplay fakeView = new FakeComboDisplay();
        ComboPresenter presenter = new ComboPresenter(model, fakeView);
        for (int i = 0; i < 10; i++)
        {
            model.RegisterHit();
        }
        Assert.AreEqual(ComboRank.Amazing, fakeView.LastRank);
    }


    [Test]
    public void IncrementHit_ViewRankOverAmazing()
    {
        ComboModel model = new ComboModel();
        FakeComboDisplay fakeView = new FakeComboDisplay();
        ComboPresenter presenter = new ComboPresenter(model, fakeView);
        for (int i = 0; i < 50; i++)
        {
            model.RegisterHit();
        }
        Assert.AreEqual(ComboRank.Amazing, fakeView.LastRank);
    }

    [Test]
    public void IncrementHit_ShowCount()
    {
        ComboModel model = new ComboModel();
        FakeComboDisplay fakeView = new FakeComboDisplay();
        ComboPresenter presenter = new ComboPresenter(model, fakeView);
        for (int i = 0; i < 50; i++)
        {
            model.RegisterHit();
        }
        Assert.AreEqual(50, fakeView.ShowCallCount);
    }

    [Test]
    public void Dispose_StopsForwardingToView()
    {
        var model = new ComboModel();
        var fakeView = new FakeComboDisplay();
        var presenter = new ComboPresenter(model, fakeView);

        presenter.Dispose();
        model.RegisterHit();

        Assert.AreEqual(0, fakeView.ShowCallCount);
    }
}

}