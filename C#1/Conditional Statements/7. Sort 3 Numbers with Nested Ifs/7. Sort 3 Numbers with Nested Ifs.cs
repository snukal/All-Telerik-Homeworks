using System;

class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {

        Console.WriteLine("Enter values for the three numbers: ");
        Console.Write("Number a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Number b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Number c:");
        double c = double.Parse(Console.ReadLine());

        if ((a>b) && (a>c))
        {
            if (b>c)
            {
                Console.WriteLine("Result: {0} {1} {2}", a, b, c);
            }
            else
	        {
                Console.WriteLine("Result: {0} {1} {2}", a, c, b);
	        }
        }
        else if ((a < b) && (a < c))
        {
            if (b < c)
            {
                Console.WriteLine("Result: {0} {1} {2}", c, b, a);
            }
            else
            {
                Console.WriteLine("Result: {0} {1} {2}", b, c, a);
            }
        }
        else if ((a > b) && (a < c))
        {
            Console.WriteLine("Result: {0} {1} {2}", c, a, b);
        }
        else if ((a > c) && (a < b))
	    {
            Console.WriteLine("Result: {0} {1} {2}", b, a, c);
	    }
        
    }
}