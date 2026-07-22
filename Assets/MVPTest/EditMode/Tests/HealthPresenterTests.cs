using NUnit.Framework;
using HPTest;

    public class HealthPresenterTests 
    {

        [Test]
        public void LethalDamage_ShowsExactlyTwice()
        {
            var model = new HealthModel(20, 10);
            var fakeHealthDisplay = new FakeHealthDisplay();
            var healthPresenter = new HealthPresenter(model, fakeHealthDisplay);
            //model.TakeDamage(10);
            model.TakeDamage(10);
            healthPresenter.Dispose();
            Assert.AreEqual(2, fakeHealthDisplay.ShowCallCount);
        }

        [Test]
        public void LowHealth_SetsDangerFlag()
        {
            var model = new HealthModel(100, 50);
            var fakeHealthDisplay = new FakeHealthDisplay();
            var healthPresenter = new HealthPresenter(model, fakeHealthDisplay);
            model.TakeDamage(25);
            healthPresenter.Dispose();
            Assert.IsTrue(fakeHealthDisplay.LastIsDanger);

        }
    }

