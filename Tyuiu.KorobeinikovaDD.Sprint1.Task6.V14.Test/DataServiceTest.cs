using Tyuiu.KorobeinikovaDD.Sprint1.Task6.V14.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string value = "привет";
            DataService ds = new DataService();
            var res = ds.CheckLowerCaseRusLetters(value);
            Assert.AreEqual(true, res);
        }
    }
}