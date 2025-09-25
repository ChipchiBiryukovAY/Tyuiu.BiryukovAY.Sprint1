namespace Tyuiu.BiryukovAY.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckLastWordRepetition_WithRepeatedLastWord_ReturnsTrue()
        {
            var checker = new DataService();
            bool result = checker.CheckLastWordRepetition("привет мир привет");
            Assert.IsTrue(result);
        }
    }
}
