using System;

/* We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
 * Assume that repeating the same subset several times is not a problem.
 */

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Enter 5 real numbers!");
        
        Console.Write("a = ");
        int a= int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());
        int count = 0;
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, a + b + c + d + e);
            count++;
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, c, d, a + b + c + d);
            count++;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, c, e, a + b + c + e);
            count++;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, d, e, a + b + d + e);
            count++;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, c, d, e, a + c + d + e);
            count++;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", b, c, d, e, b + c + d + e);
            count++;
        }

        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, d, e, c + d + e);
            count++;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", b, d, e, b + d + e);
            count++;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", b, c, e, b + c + e);
            count++;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", b, c, d, b + c + d);
            count++;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, d, e, a + d + e);
            count++;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, c, e, a + c + e);
            count++;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, c, d, a + c + d);
            count++;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, e, a + b + e);
            count++;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, d, a + b + d);
            count++;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c,  a + b + c);
            count++;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", d, e, d + e);
            count++;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", c, e, c + e);
            count++;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", c, d, c + d);
            count++;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", b, e, b + e);
            count++;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", b, d, b + d);
            count++;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", b, c, b + c);
            count++;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", a, e, a + e);
            count++;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", a, d, a + d);
            count++;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", a, c, a + c);
            count++;
        }
        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            count++;
        }
        if (count == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }
}

