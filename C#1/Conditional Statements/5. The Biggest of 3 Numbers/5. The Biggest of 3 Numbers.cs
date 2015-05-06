using System;

//Write a program that finds the biggest of three numbers.

class TheBiggestOfThreeNumbers
{
    static void Main()
    {

        Console.WriteLine("Enter values for the three numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.Write("Bigest number is:");
        Console.WriteLine(Math.Max(Math.Max(a,b),c));
    }
}
