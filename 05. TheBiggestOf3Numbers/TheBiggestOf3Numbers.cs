using System;

// Write a program that finds the biggest of three numbers.

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 real numbers!");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (b > a)
        {
            a = b;
        }
        if (c > a)
        {
            a = c;
        }
        Console.WriteLine("The biggest number is {0}", a);
    }
}