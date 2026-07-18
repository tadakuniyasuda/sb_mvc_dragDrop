using NUnit.Framework;

public class CounterPresenterTests 
{
    [Test]
    public void Increment_ViewReceivesTranslateMessage()
    {
        var model = new Counter();
        var fakeView = new FakeDisplay();
        var presenter = new _CounterPresenter(model, fakeView);

        model.Increment();

        Assert.AreEqual("The count is 1", fakeView.LastMessage);
        Assert.AreEqual(1, fakeView.ShowCallCount);
    }

    [Test]
    public void Dispose_StopsForwardingToView()
    {
        var model = new Counter();
        var fakeView = new FakeDisplay();
        var presenter = new _CounterPresenter(model, fakeView);

        presenter.Dispose();
        model.Increment();

        Assert.AreEqual(0, fakeView.ShowCallCount);
    }

}
