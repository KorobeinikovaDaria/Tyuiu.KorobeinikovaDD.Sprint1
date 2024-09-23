

using Tyuiu.KorobeinikovaDD.Sprint1.Task4.V12.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint1.Task4.V12.Test
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
            double wait = 0.001;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
            
        }
    }
}