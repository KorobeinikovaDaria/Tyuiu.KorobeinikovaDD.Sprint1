// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint1.Task5.V6.Lib;
DataService ds = new DataService();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int k;
Console.WriteLine("Введите значение числа k:");
k = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Значение переменной n:" + ds.Calculate(k));

Console.ReadKey();
