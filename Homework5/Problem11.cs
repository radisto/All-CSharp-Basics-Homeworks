using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        DateTime start = DateTime.Parse("13:00:00");
        DateTime end = DateTime.Parse("3:00:00");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "hh:mm tt", CultureInfo.InvariantCulture);
        if (date.TimeOfDay < start.TimeOfDay && date.TimeOfDay >= end.TimeOfDay)
        {
            Console.WriteLine("non-beer time");
        }
        else
        {
            Console.WriteLine("beer time");
        }
    }
}
