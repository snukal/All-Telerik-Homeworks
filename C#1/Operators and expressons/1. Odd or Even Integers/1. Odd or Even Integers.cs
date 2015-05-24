using System;

//Write an expression that checks if given integer is odd or even.

class OddorEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        bool result = number % 2 == 0;

        if (result == true)
            {
                Console.WriteLine("The number is odd!");
            }
        else
            {
                Console.WriteLine("The number is even!");
            }



    }
}