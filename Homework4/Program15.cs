using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        double work = d * 12 * (9 / 10.0) * (p / 100.0);
        int workFloored = (int)Math.Floor(work);
        Console.WriteLine(workFloored >= h ? "Yes" : "No");
        Console.WriteLine(workFloored - h);
    }
}