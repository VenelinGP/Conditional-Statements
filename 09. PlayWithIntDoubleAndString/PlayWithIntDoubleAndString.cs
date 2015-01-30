using System;

/* Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 * the variable is int or double, the program increases it by one.
 * If the variable is a string, the program appends * at the end.
 * Print the result at the console. Use switch statement
 */

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1 --> integer");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());
        } while (choice != 1 && choice != 2 && choice != 3);

        switch (choice)
        {
            case 1:
                Console.Write("Please enter a integer: ");
                int inputInt = int.Parse(Console.ReadLine());
                inputInt = inputInt + 1;
                Console.WriteLine("Output: {0}",inputInt);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                inputDouble = inputDouble + 1;
                Console.WriteLine("Output: {0}", inputDouble);
                break;
            default:
                Console.Write("Please enter a string: ");
                string inputString = Console.ReadLine();
                inputString = inputString + "*";
                Console.WriteLine("Output: {0}", inputString);
                break;
        }
    }
}

