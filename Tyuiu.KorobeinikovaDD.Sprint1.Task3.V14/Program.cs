// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint1.Task3.V14.Lib;
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
Console.WriteLine("* и определяет число, полученное выписыванием в обратном порядке цифр     *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double number;
Console.WriteLine("Введите трехзначное число:");
number = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Число, полученное выписыванием в обратном порядке цифр: " + ds.ReverseNumber(number));

Console.ReadKey();

