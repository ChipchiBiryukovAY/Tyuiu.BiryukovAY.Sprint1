using Tyuiu.BiryukovAY.Sprint1.Task5.V2.Lib;
namespace Tyuiu.BiryukovAY.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FahrenheitToCelsius_32F_Returns0C()
        {
            DataService ds = new DataService();

            int result = ds.FahrenheitToСelsius(32);

            Assert.AreEqual(0, result);
        }
    }
}