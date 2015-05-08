using System;

class DigitsAsWord
{
    static void Main()
    {
        int intnumber;
        string number = Console.ReadLine();
        string[] zerotonine = new string[10] {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
        try
        {
            intnumber = Convert.ToInt32(number);
            Console.WriteLine(zerotonine[intnumber]);
        }
        catch
        {
            Console.WriteLine("not a digit");
        }
    }
}
