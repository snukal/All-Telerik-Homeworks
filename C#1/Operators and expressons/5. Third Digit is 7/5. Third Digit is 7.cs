using System;

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.WriteLine("Enter the number");
        int number = int.Parse(Console.ReadLine());
        bool check = (number / 100) % 10 == 7;
        Console.WriteLine("The third digit frim right to left is: " + check);

    }
}