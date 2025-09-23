using Tyuiu.BiryukovAY.Sprint1.Task1.V8.Lib;
namespace Tyuiu.BiryukovAY.Sprint1.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(6.28, res);

        }
    }
}
