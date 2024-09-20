// See https://aka.ms/new-console-template for more information

using Tyuiu.KorobeinikovaDD.Sprint1.Task0.V12.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("***********************************************************************");
Console.WriteLine("* Спринт #1                                                           *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                    *");
Console.WriteLine("* Задание #0                                                          *");
Console.WriteLine("* Вариант #12                                                         *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                *");
Console.WriteLine("***********************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                            *");
Console.WriteLine("* Написать программу, которая вычисляет выражение (5*2 - 2) / 4 * 3   *");
Console.WriteLine("* и печатает результат на экране.                                     *");
Console.WriteLine("*                                                                     *");
Console.WriteLine("***********************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
Console.WriteLine("***********************************************************************");
Console.WriteLine("* (5*2 - 2) / 4 * 3                                                   *");
Console.WriteLine("***********************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                          *");
Console.WriteLine("***********************************************************************");


Console.WriteLine(ds.Calculate());
Console.ReadKey();