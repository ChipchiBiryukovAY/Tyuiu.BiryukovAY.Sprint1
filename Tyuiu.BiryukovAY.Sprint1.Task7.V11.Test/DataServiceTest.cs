using Tyuiu.BiryukovAY.Sprint1.Task7.V11.Lib;
namespace Tyuiu.BiryukovAY.Sprint1.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate_WithValidValues_ReturnsCorrectResult()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(1, 2);

            Assert.IsFalse(double.IsNaN(result));
            Assert.IsFalse(double.IsInfinity(result));
        }
    }
}