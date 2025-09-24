using Tyuiu.BiryukovAY.Sprint1.Task5.V2.Lib;

namespace Tyuiu.BiryukovAY.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class TemperatureConverterTests
    {
        [TestMethod]
        public void FahrenheitToCelsius_32F_Returns0C()
        {
            DataService converter = new DataService();

            int result = converter.FahrenheitToCelsius(32);

            Assert.AreEqual(0, result);
        }
    }
}
