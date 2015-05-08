using System;

class CheckForPlayCard
{
    static void Main()
    {
        string card = Console.ReadLine();
        int numbercard = 0;
        string yesorno = "no";
        try
        {
            numbercard = Convert.ToInt32(card);
            if (numbercard >= 2 && numbercard <= 10)
            {
                yesorno = "yes";
            }
        }
        catch
        {
            switch (card)
            {
                case "J":
                    yesorno = "yes";
                    break;
                case "Q":
                    yesorno = "yes";
                    break;
                case "K":
                    yesorno = "yes";
                    break;
                case "A":
                    yesorno = "yes";
                    break;
            }
        }
        Console.WriteLine(yesorno);
    }
}
