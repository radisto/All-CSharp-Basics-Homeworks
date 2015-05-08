using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("Please enter an integer");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(i + 1);
        }
        else if (n == 2)
        {
            Console.WriteLine("Please enter a double");
            double i = double.Parse(Console.ReadLine());
            Console.WriteLine(i + 1);
        }
        else if (n == 3)
        {
            Console.WriteLine("Please enter a string");
            string i = Console.ReadLine();
            Console.WriteLine(i + "*");
        }
        else
        {
            Console.WriteLine("You didn't enter 1, 2 or 3");
        }
    }
}
