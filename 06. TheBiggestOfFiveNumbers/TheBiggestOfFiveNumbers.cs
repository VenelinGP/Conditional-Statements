using System;

// Write a program that finds the biggest of five numbers by using only five if statements.

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 real numbers!");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());
        if (b > a)
        {
            a = b;
        }
        if (c > a)
        {
            a = c;
        }
        if (d > a)
        {
            a = d;
        }
        if (e > a)
        {
            a = e;
        }
        Console.WriteLine("The biggest number is {0}", a);
    }
}