using NUnit.Framework;
using HPTest;

public class HealthModelTests 
{
    [Test]
    public void TakeDamage_ReducesHealth()
    {
        var model = new HealthModel();
        model.TakeDamage(10);
        Assert.AreEqual(40, model.Health);
    }
}
