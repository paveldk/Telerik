using System;

class Cards
{
    static void Main()
    {
        /*Write a program that prints all possible cards from a standard deck of
         * 52 cards (without jokers). The cards should be printed with their
         * English names. Use nested for loops and switch-case.*/

        string[] cards = new String[] {"ace","two","three","four","five","six","seven","eight","nine","ten","jack","queen","king"};

        string[] suit = new String[] { "clubs", "diamonds", "hearts", "spades" };

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j <= 12; j++)
            {
                switch (i)
                {
                    case 0 :
                        Console.WriteLine(cards[j] + " of " + suit[i]);
                        break;
                    case 1:
                        Console.WriteLine(cards[j] + " of " + suit[i]);
                        break;
                    case 2:
                        Console.WriteLine(cards[j] + " of " + suit[i]);
                        break;
                    case 3:
                        Console.WriteLine(cards[j] + " of " + suit[i]);
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
