// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint1.Task7.V9.Lib;
DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x;
x = Convert.ToDouble(Console.ReadLine());
double y;
y = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.Calculate(x, y));

Console.ReadKey();