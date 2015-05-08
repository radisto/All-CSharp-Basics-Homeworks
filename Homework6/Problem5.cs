using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        char[] suits = "♣♦♥♠".ToCharArray();
        string card = null;
        for (int i = 2; i < 15; i++)
        {
            if (i < 11)
            {
                card = i.ToString();
            }
            else
            {
                switch (i)
                {
                    case 11:
                        card = "J";
                        break;
                    case 12:
                        card = "Q";
                        break;
                    case 13:
                        card = "K";
                        break;
                    case 14:
                        card = "A";
                        break;
                }
            }
            for (int j = 0; j < 4; j++)
            {
                Console.Write(card + suits[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
