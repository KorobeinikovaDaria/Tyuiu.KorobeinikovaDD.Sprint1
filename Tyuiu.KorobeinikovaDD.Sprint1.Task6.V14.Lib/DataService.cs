using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KorobeinikovaDD.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            var b = -1;
            bool h = !value.Any(c => Char.IsUpper(c));
            var a = Convert.ToInt32(h);
            if (!Regex.IsMatch(value, @"\P{IsCyrillic}"))
            { b = 1; }
            else { b = 0; }

            if (a + b == 2)
            {
                return true;
            }
            else { return false; }
          
        }
    }
}
