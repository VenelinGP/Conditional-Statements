using System;

// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.

class Sort3NumbersWithNestedIfs
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
        double temp;
        if (b > a)
        {
            temp = a;
            a = b;
            b = temp;

            if (c > b)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if (b > a)
            {
                temp = a;
                a = b;
                b = temp;
            }
        }
        else if (c > a)
        {
            temp = a;
            a = c;
            c = temp;
            if (c > b)
            {
                temp = b;
                b = c;
                c = temp;
            }
        }
        else
        {
            if (c > b)
            {
                temp = b;
                b = c;
                c = temp;
            }
        }
        Console.WriteLine("{0} {1} {2}", a, b, c);
    }
}