using System;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

class MultiplicationSign
{
    static void Main()
    {
        // sign 0 when a=0 || b = 0 || c = 0
        // sign + when a,b,c>0 || a,b<0, c>0 || a,c<0, b>0 || b,c<0, a>0
        // sign - when a,b,c<0 || a<0, b,c>0 || b<0, a,c>0 || c<0, a,b>0
        Console.WriteLine("Enter 3 real numbers!");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c < 0))
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}