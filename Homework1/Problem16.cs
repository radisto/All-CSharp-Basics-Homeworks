using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Submit your birthday using dd.mm.yyyy format\ne.g. January first 93 should be entered as 01.01.1993");
        string a = Console.ReadLine();
        string b = DateTime.Now.ToString("dd/MM/yyyy");
        int birthday = StringToInt(a,0);
        int currentday = StringToInt(b,0);
        int birthmonth = StringToInt(a, 3);
        int currentmonth = StringToInt(b, 3);
        int birthyear = (StringToInt(a, 6)) * 100 + StringToInt(a, 8);
        int currentyear = (StringToInt(b, 6)) * 100 + StringToInt(b, 8);
        if (currentmonth > birthmonth)
        {
            Console.WriteLine("You are {0} years old\nYou'll be {1} in 10 years", currentyear-birthyear, currentyear-birthyear+10);
        }
        else if (currentmonth < birthmonth)
        {
            Console.WriteLine("You are {0} years old\nYou'll be {1} in 10 years", currentyear - birthyear - 1, currentyear - birthyear + 9);
        }
        else if (currentmonth == birthmonth)
        {
            if (currentday > birthday)
            {
                Console.WriteLine("You are {0} years old\nYou'll be {1} in 10 years", currentyear - birthyear, currentyear - birthyear + 10);
            }
            else if (currentday < birthday)
            {
                Console.WriteLine("You are {0} years old\nYou'll be {1} in 10 years", currentyear - birthyear - 1, currentyear - birthyear + 9);
            }
            else if (currentday == birthday)
            {
                Console.WriteLine("Happy Birthday to you! You just turned {0} years old\nYou'll be {1} in 10 years", currentyear - birthyear, currentyear - birthyear + 10);
            }
        }
    }

    static int StringToInt(string strname, int position)
    {
        return (int)char.GetNumericValue(strname[position]) * 10 + (int)char.GetNumericValue(strname[position+1]);
    }
}
