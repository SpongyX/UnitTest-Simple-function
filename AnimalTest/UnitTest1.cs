using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AnimalTest
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void Cost_withvalid_amount()
        {
            double dailyCost = 3;
            double expected = 90;
            Animal animal = new Animal();

            animal.Cost(dailyCost);
            double actual = animal.AnimalCost;
            Assert.AreEqual(expected, actual);
        }
    }
}