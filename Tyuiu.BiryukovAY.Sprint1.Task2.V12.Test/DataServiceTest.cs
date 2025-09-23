using Tyuiu.BiryukovAY.Sprint1.Task2.V12.Lib;

namespace Tyuiu.BiryukovAY.Sprint1.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateParallelepipedVolume_WithPositiveNumbers_ReturnsCorrectVolume()
        {
            var calculator = new DataService();
            int длина = 2;
            int ширина = 3;
            int высота = 4;
            int res = calculator.CalculateParallelepipedVolume(длина, ширина, высота);
            Assert.AreEqual(24, res);
        }
    }
}