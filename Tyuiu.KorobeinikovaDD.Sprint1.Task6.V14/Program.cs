// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using Tyuiu.KorobeinikovaDD.Sprint1.Task6.V14.Lib;
DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value;
Console.WriteLine("Введите текст:");
value = Console.ReadLine();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ ПРОВЕРКИ:                                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.CheckLowerCaseRusLetters(value));

Console.ReadKey();
