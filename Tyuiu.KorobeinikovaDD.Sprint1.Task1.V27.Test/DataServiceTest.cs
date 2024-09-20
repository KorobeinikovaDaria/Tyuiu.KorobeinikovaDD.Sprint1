
using Tyuiu.KorobeinikovaDD.Sprint1.Task1.V27.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint1.Task1.V27.Test
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
            var res = ds.Calculate(-4, 2);
            Assert.AreEqual(-1, res);
        }
    }
}