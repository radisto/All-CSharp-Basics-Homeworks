using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());
        double plays = (52 - hometown) * 2 / 3 + holidays / 2 + hometown + (leap == "t" ? 3 : 0);
        Console.WriteLine(Math.Floor(plays));
    }
}
