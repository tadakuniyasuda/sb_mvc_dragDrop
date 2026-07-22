using NUnit.Framework;
using HPTest;


public class HealthModelTests 
{
    [Test]
    public void TakeDamage_ReducesHealth()
    {
        var model = new HealthModel(120, 50);
        model.TakeDamage(30);
        Assert.AreEqual(20, model.Health);
    }
    [Test]
    public void TakeDamage_DoesNotGoBelowZero()
    {
        var model = new HealthModel(10, 5);
        model.TakeDamage(1000);
        Assert.AreEqual(0, model.Health);
    }

     [Test]
     public void TakeDamage_FiresOnDied_WhenHealthReachesZero()
    {
        var model = new HealthModel(100, 10);
        bool diedCalled = false;

        model.OnDied += () => diedCalled = true;

        model.TakeDamage(10000000);

        Assert.IsTrue(diedCalled);
    }
    [Test]
    public void TakeDamage_DoesNotFireOnDied_WhenHealRemains()
    {
        var model = new HealthModel();
        bool diedCalled = false;

        model.OnDied += ()=> diedCalled = true;

        model.TakeDamage(1);
        Assert.IsFalse(diedCalled);
    }

}
