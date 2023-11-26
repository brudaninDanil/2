using System;

class Program
{
    static void Main()
    {
        double x, y, a, b;

        Console.WriteLine("Введите x, a и b:");
        string[] input = Console.ReadLine().Split(' ');
        x = Convert.ToDouble(input[0]);
        a = Convert.ToDouble(input[1]);
        b = Convert.ToDouble(input[2]);

        if (a < b)
        {
            y = a / b + 1;
        }
        else if (a == b)
        {
            y = -1;
        }
        else
        {
            y = (a * b - 5) / a;
        }

        Console.WriteLine($"x=  {y.ToString("0.0")}");
    }
}