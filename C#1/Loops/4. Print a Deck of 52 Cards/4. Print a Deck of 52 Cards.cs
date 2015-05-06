using System;

class TheDeck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 5)
        {



            Console.WriteLine("The Deck of 52 cards:");
            int firstCard = 2;
            char A = 'A';
            char Q = 'Q';
            char K = 'K';
            char J = 'J';
            int row = 0;
            int colors = 4;
            for (int i = 1; i <= 13; i++)
            {

                for (int j = 1; j <= colors; j++)
                {
                    row++;
                    if (firstCard <= 10)
                    {


                        switch (row)
                        {
                            case 1: Console.Write("  {0} spades", firstCard); break;
                            case 2: Console.Write("  {0} clubs", firstCard); break;
                            case 3: Console.Write("  {0} hearts", firstCard); break;
                            case 4: Console.Write("  {0} diamonds ", firstCard); break;
                            default:
                                break;
                        }
                    }

                    else if (firstCard == 11)
                    {
                        switch (row)
                        {
                            case 1: Console.Write("  {0} spades", J); break;
                            case 2: Console.Write("  {0} clubs", J); break;
                            case 3: Console.Write("  {0} hearts", J); break;
                            case 4: Console.Write("  {0} diamonds ", J); break;
                            default:
                                break;
                        }
                    }
                    else if (firstCard == 12)
                    {
                        switch (row)
                        {
                            case 1: Console.Write("  {0} spades", Q); break;
                            case 2: Console.Write("  {0} clubs", Q); break;
                            case 3: Console.Write("  {0} hearts", Q); break;
                            case 4: Console.Write("  {0} diamonds ", Q); break;
                            default:
                                break;
                        }
                    }
                    else if (firstCard == 13)
                    {
                        switch (row)
                        {
                            case 1: Console.Write("  {0} spades", K); break;
                            case 2: Console.Write("  {0} clubs", K); break;
                            case 3: Console.Write("  {0} hearts", K); break;
                            case 4: Console.Write("  {0} diamonds ", K); break;
                            default:
                                break;
                        }
                    }
                    else //if (length == 14)
                    {
                        switch (row)
                        {
                            case 1: Console.Write("  {0} spades", A); break;
                            case 2: Console.Write("  {0} clubs", A); break;
                            case 3: Console.Write("  {0} hearts", A); break;
                            case 4: Console.Write("  {0} diamonds ", A); break;
                            default:
                                break;
                        }
                    }
                }
                row = 0;
                firstCard++;
                Console.WriteLine();
            }
        }
    }
}
