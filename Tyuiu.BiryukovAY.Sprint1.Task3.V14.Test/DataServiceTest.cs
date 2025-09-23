using Tyuiu.BiryukovAY.Sprint1.Task3.V14.Lib;
namespace Tyuiu.BiryukovAY.Sprint1.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ReverseNumber_123_Returns321()
        {
            var lib = new DataService();
            double result = lib.ReverseNumber(123);
            Assert.AreEqual(321, result);
        }
    }
}