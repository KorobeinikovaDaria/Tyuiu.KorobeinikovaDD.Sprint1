// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint1.Task2.V24.Lib;
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
Console.WriteLine("* и вычисляет квадрат разности                                            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x, y;
Console.WriteLine("Введите значение x:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение у:");
y = Convert.ToInt32(Console.ReadLine()); 


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Квадрат разницы чисел х, у: " + ds.CalculateDiffSquare(x, y));


Console.ReadKey();
