using Tyuiu.BiryukovAY.Sprint1.Task6.V12.Lib;
namespace Tyuiu.BiryukovAY.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckLastWordRepetition_WithRepeatedLastWord_ReturnsTrue()
        {

            DataService ds = new DataService();

            bool result = ds.CheckLastWordRepetiton("привет мир привет");

            Assert.IsTrue(result);
        }
    }
}
