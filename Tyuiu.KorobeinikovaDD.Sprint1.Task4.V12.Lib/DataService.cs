
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KorobeinikovaDD.Sprint1.Task4.V12.Lib
{
    public class DataService : ISprint1Task4V12
    {
        public double Calculate(double x, double y)
        {
            var c = 3.14 * x;
            var i = (x + Math.Sqrt(Math.Abs(y)));
            var res = Math.Sin(c) / i;
            return Math.Round(res, 3);
        }
    }
}
