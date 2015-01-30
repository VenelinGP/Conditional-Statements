using System;
// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
class NumberAsWords
{
    static void Main()
    {
        ConsoleKeyInfo presX;
        do
        {
            Console.Write("Please enter a number in the range [0…999]: ");
            string strNumber = Console.ReadLine();
            int number;
            int x = 0;
            bool result = int.TryParse(strNumber, out number);
            // int number = int.Parse(Console.ReadLine());
            if (result == false)
            {
                x = 1;
                number = 0;
            }
            int c = number % 10;
            number = number / 10;
            int b = number % 10;
            number = number / 10;
            int a = number % 10;
            number = a * 100 + b * 10 + c;
            string wordOfHundreds = "";
            string wordOfTens = "";
            string wordOfOnes = "";
            string join = " and ";
            string space = " ";

            switch (a)
            {
                case 1:
                    wordOfHundreds = "one hundred";
                    break;
                case 2:
                    wordOfHundreds = "two hundred";
                    break;
                case 3:
                    wordOfHundreds = "three hundred";
                    break;
                case 4:
                    wordOfHundreds = "four hundred";
                    break;
                case 5:
                    wordOfHundreds = "five hundred";
                    break;
                case 6:
                    wordOfHundreds = "six hundred";
                    break;
                case 7:
                    wordOfHundreds = "seven hundred";
                    break;
                case 8:
                    wordOfHundreds = "eight hundred";
                    break;
                case 9:
                    wordOfHundreds = "nine hundred";
                    break;
                default:
                    wordOfHundreds = "";
                    join = "";
                    break;
            }

            switch (b)
            {
                case 2:
                    wordOfTens = "twenty";
                    break;
                case 3:
                    wordOfTens = "thirty";
                    break;
                case 4:
                    wordOfTens = "forty";
                    break;
                case 5:
                    wordOfTens = "fifty";
                    break;
                case 6:
                    wordOfTens = "sixty";
                    break;
                case 7:
                    wordOfTens = "seventy";
                    break;
                case 8:
                    wordOfTens = "eighty";
                    break;
                case 9:
                    wordOfTens = "ninety";
                    break;
                default:
                    wordOfTens = "";
                    break;
            }

            switch (c)
            {
                case 1:
                    wordOfOnes = "one";
                    break;
                case 2:
                    wordOfOnes = "two";
                    break;
                case 3:
                    wordOfOnes = "three";
                    break;
                case 4:
                    wordOfOnes = "four";
                    break;
                case 5:
                    wordOfOnes = "five";
                    break;
                case 6:
                    wordOfOnes = "six";
                    break;
                case 7:
                    wordOfOnes = "seven";
                    break;
                case 8:
                    wordOfOnes = "eight";
                    break;
                case 9:
                    wordOfOnes = "nine";
                    break;
                default:
                    wordOfOnes = "";
                    break;
            }
            if (a == 0 && b == 0 && c == 0)
            {
                wordOfHundreds = "";
                wordOfTens = "";
                space = "";
                wordOfOnes = "zero";
                if(x == 1)
                {
                    wordOfOnes = "";
                }
            }
            if (b == 0 && c == 0)
            {
                join = "";
            }
            if (b == 0)
            {
                space = "";
            }
            if (b == 1)
            {
                wordOfOnes = "";
                number = b * 10 + c;
                switch (number)
                {
                    case 11:
                        wordOfTens = "eleven";
                        break;
                    case 12:
                        wordOfTens = "twelve";
                        break;
                    case 13:
                        wordOfTens = "thirteen";
                        break;
                    case 14:
                        wordOfTens = "fourteen";
                        break;
                    case 15:
                        wordOfTens = "fifteen";
                        break;
                    case 16:
                        wordOfTens = "sixteen";
                        break;
                    case 17:
                        wordOfTens = "seventeen";
                        break;
                    case 18:
                        wordOfTens = "eighteen";
                        break;
                    case 19:
                        wordOfTens = "nineteen";
                        break;
                    default:
                        Console.WriteLine("ten");
                        break;
                }
            }
            Console.WriteLine("{0}{1}{2}{3}{4}", wordOfHundreds, join, wordOfTens, space, wordOfOnes);
            //Press (CTRL+x to EXIT)
            presX = Console.ReadKey();

        } while (!(presX.Key == ConsoleKey.X && presX.Modifiers == ConsoleModifiers.Control));
    }
}
