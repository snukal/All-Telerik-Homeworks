using System;

class OddOrEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] splitedNumbers = input.Split(' ');
        int oddProd = 1;
        int evenProd = 1;

        for (int i = 0; i < splitedNumbers.Length; i++)
        {
            int tempNumber = int.Parse(splitedNumbers[i]);
            bool isOdd = (i + 1) % 2 != 0;
            bool isEven = (i + 1) % 2 == 0;

            if (isOdd)
            {
                oddProd *= tempNumber;
            }
            if (isEven)
            {
                evenProd *= tempNumber;
            }
        }
        if (oddProd == evenProd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("The product is {0}", oddProd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("Odd product is {0}", oddProd);
            Console.WriteLine("Even product is {0}", evenProd);
        }

    }
}