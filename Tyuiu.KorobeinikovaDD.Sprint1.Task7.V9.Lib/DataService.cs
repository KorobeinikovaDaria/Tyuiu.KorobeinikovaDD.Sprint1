
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KorobeinikovaDD.Sprint1.Task7.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            var a = Math.Pow(x, 3);
            var c = Math.Exp(x);
            var d = Math.Pow(y, 2);
            var n = Math.Pow(x, 2);
            var w = c - ((d + Math.Cos(a) + 12 * x * y - 3 * n) / (Math.Cos(a + 3) + 18 * y - 1));
            return Math.Round(w, 3);
        }
    }
}
