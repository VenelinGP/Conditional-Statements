using System;

// Write an if-statement that takes two double variables a and b and exchanges their values
// if the first one is greater than the second one. As a result print the values a and b, separated by a space.


class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter 2 real numbers:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double c = b;
            b = a;
            a = c;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}
