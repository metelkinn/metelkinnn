using System;

class Program
{
    static void Main()
    {

        Console.Write("Введите число: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double result = 2 * Math.Sin(x) + 3 * Math.Cos(x);
        Console.WriteLine("Результат: " + result);
    }
}