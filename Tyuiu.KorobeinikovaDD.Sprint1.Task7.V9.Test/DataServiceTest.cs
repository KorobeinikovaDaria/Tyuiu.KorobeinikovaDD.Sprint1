using Tyuiu.KorobeinikovaDD.Sprint1.Task7.V9.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 2.073;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}