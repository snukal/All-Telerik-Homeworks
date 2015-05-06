using System;
using System.Linq;

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Enter a simbol: ");
        var card = Console.ReadLine();
        Console.Write( "Valid card sign? --->" );
        if (card.GetType() == typeof(int))
        {
            int card1 = Convert.ToInt32(card);
            if (Enumerable.Range(1, 10).Contains(card1))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else
        {
            string card2 = card.ToString();
            if ((card2 == "Q" || card2 == "K" || card2 == "J" || card2 == "A"))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
