using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());
        double plays = (3.0 / 4 * (48 - hometown) + holidays * 2.0 / 3 + hometown) * (year == "leap" ? 1.15 : 1);
        Console.WriteLine(Math.Floor(plays));
    }
}
