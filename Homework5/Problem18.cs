using System;

class MagicDates
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int magicweight = int.Parse(Console.ReadLine());
        int weight = 0;
        int a1 = 0, a2 = 0, b1 = 0, b2 = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0;
        bool counter = true;
        for (int year = start; year <= end; year++)
        {
            c1 = year / 1000;
            c2 = year % 1000 / 100;
            c3 = year % 100 / 10;
            c4 = year % 10;
            for (int month = 1; month <= 12; month++)
            {
                if (month < 10)
                {
                    b1 = 0;
                    b2 = month;
                }
                else
                {
                    b1 = month / 10;
                    b2 = month % 10;
                }
                for (int day = 1; day <= 31; day++)
                {
                    if (month == 2 && day > 28)
                    {
                        if (day == 29 && (year - 1900) % 4 != 0)
                        {
                            if (year == 2100 || year == 1900)
                            {
                                continue;
                            }
                            continue;
                        }
                        else if (day > 29)
                        {
                            continue;
                        }
                    }
                    if ((day == 31) && (month == 4 || month == 6 || month == 9 || month == 11))
                    {
                        continue;
                    }
                    if (day < 10)
                    {
                        a1 = 0;
                        a2 = day;
                    }
                    else
                    {
                        a1 = day / 10;
                        a2 = day % 10;
                    }
                    weight = a1 * a2 + a1 * b1 + a1 * b2 + a1 * c1 + a1 * c2 + a1 * c3 + a1 * c4 + a2 * b1 + a2 * b2 + a2 * c1 + a2 * c2 + a2 * c3 + a2 * c4 + b1 * b2 + b1 * c1 + b1 * c2 + b1 * c3 + b1 * c4 + b2 * c1 + b2 * c2 + b2 * c3 + b2 * c4 + c1 * c2 + c1 * c3 + c1 * c4 + c2 * c3 + c2 * c4 + c3 * c4;
                    if (weight == magicweight)
                    {
                        counter = false;
                        Console.WriteLine(a1 + "" + a2 + "-" + b1 + "" + b2 + "-" + c1 + "" + c2 + "" + c3 + "" + c4);
                    }
                }
            }
        }
        if (counter)
        {
            Console.WriteLine("No");
        }
    }
}
