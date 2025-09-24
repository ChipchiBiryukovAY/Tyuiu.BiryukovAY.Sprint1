using Tyuiu.BiryukovAY.Sprint1.Task4.V30.Lib;
namespace Tyuiu.BiryukovAY.Sprint1.Task4.V30.Test
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Calculate_WithSimpleValues_ReturnsCorrectResult()
        {
            DataService calculator = new DataService();
            double result = calculator.Calculate(1, 1);
            Assert.AreEqual(0.736, result, 0.001);
        }
    }
}
