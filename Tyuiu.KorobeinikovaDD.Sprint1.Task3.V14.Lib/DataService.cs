using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KorobeinikovaDD.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            int a = (((int)number % 10) * 100);
            int b = ((int)number / 100);
            int c = (((((int)number % 100) / 10)) * 10);
            return a + b + c ;
        }
    }
}
