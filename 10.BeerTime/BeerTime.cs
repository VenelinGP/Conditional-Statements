using System;
using System.Globalization;


/* A beer time is after 1:00 PM and before 3:00 AM
 * Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and 
 * AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if 
 * the time cannot be parsed. Note: You may need to learn how to parse dates and times.
 */

class BeerTime
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.InvariantCulture;

        DateTime startTime = DateTime.ParseExact("01:00 PM", "hh:mm tt", culture);
        DateTime beforMidnight = DateTime.ParseExact("12:59 PM", "hh:mm tt", culture);
        DateTime afterMidnight = DateTime.ParseExact("00:00 AM", "hh:mm tt", culture);
        DateTime endTime = DateTime.ParseExact("03:00 AM", "hh:mm tt", culture);

        Console.Write("Enter time in format \"hh:mm tt\": ");
        string inputTime = Console.ReadLine();
        
        DateTime userTime = DateTime.Parse(inputTime);
        DateTime result;   
        
        bool check = DateTime.TryParseExact(inputTime, "h:mm tt", culture, DateTimeStyles.None, out result);
        
        if (check)
        {
            bool a = (userTime >= startTime) && (userTime <= beforMidnight);
            bool b = (userTime >= afterMidnight) && (userTime < endTime);
            if ((userTime >= startTime && userTime <= beforMidnight) || (userTime >= afterMidnight && (userTime < endTime)))
            {
                Console.WriteLine("Beer Time");
            }
            else
            {
                Console.WriteLine("Non-Beer Time");
            }
        }
        else
        {
            Console.WriteLine("Invalid time");
        }
    }
}
