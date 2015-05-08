using System;

class ExamSchedule
{
    static void Main()
    {
        int hour1 = int.Parse(Console.ReadLine());
        int minute1 = int.Parse(Console.ReadLine());
        string partofday = Console.ReadLine();
        int hour2 = int.Parse(Console.ReadLine());
        int minute2 = int.Parse(Console.ReadLine());
        bool amorpm = (partofday == "AM") ? true : false;
        int hour = hour1 + hour2;
        int minute = minute1 + minute2;
        if (minute > 59)
        {
            minute -= 60;
            hour += 1;
        }
        while (hour > 12)
        {
            hour -= 12;
            amorpm = !amorpm;
        }
        if (hour == 12)
        {
            amorpm = !amorpm;
        }
        Console.WriteLine(hour.ToString().PadLeft(2, '0') + ":" + minute.ToString().PadLeft(2, '0') + ":" + ((amorpm) ? "AM" : "PM"));
    }
}
