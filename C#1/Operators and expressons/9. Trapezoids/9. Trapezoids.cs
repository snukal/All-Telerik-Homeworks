using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter value for a: ");
        double baseA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for b: ");
        double baseB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for h: ");
        double Height = double.Parse(Console.ReadLine());
        double AplusB = (double)(baseA + baseB);
        double SecretFormula = (double)((AplusB / 2) * Height);
        Console.WriteLine("The area of these trapezoid is = " +SecretFormula);

    }
}
