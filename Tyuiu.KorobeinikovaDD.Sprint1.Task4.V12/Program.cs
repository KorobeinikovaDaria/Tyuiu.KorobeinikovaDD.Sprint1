// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint1.Task4.V12.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #24                                                             *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
Console.WriteLine("* и вычисляет результат по формуле                                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x;
Console.WriteLine("Введите значение числа x:");
x = Convert.ToDouble(Console.ReadLine());
double y;
Console.WriteLine("Введите значение числа y:");
y = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.Calculate(x, y));

Console.ReadKey(); 


