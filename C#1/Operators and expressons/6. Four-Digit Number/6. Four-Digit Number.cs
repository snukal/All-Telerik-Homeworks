using System;

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = number % 10;
        int restNumberTwo = number / 10;
        int secondDigit = restNumberTwo % 10;
        int restNumberThree = number / 100;
        int thirdDigit = restNumberThree % 10;
        int restNumberFour = number / 1000;
        int fourthDigit = restNumberFour % 10;

        Console.WriteLine("Number " + number);
        Console.WriteLine("Sum of digits " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
        Console.WriteLine("Reversed {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("Last digit in front {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
        Console.WriteLine("Second and third digits exchanged {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
    }
}