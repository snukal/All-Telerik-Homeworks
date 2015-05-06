using System;

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

class Program
{
    static void Main()
    {
        Console.Write("Enter value for a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b:");
        double b = double.Parse(Console.ReadLine());

        if (a>b)
        {
            Console.WriteLine("");
            Console.WriteLine("{0} {1}", a, b);
        }
        else if (a==b)
        {
            Console.WriteLine("");
            Console.WriteLine("Numbers are equal!");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("{0} {1}", b, a);
        }
    }
}