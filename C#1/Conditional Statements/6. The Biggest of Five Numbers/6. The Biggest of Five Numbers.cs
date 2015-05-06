using System;

class TheBiggestOfFiveNumbersFirstVerson
{
    static void Main()
    {
        Console.WriteLine("Enter values for the five numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double maxNum = Math.Max(a, (Math.Max(b,(Math.Max(c,(Math.Max(d,e)))))));
        if ((a > b) && (a > c) && (a > d) && (a>e))
        {
            Console.WriteLine("Bigest number is {0}", maxNum);            
        }
        else if ((b > a) && (b > c) && (b > d) && (b > e))
        {
            Console.WriteLine("Bigest number is {0}", maxNum);   
        }
        else if ((c > b) && (c > a) && (c > d) && (c > e))
        {
            Console.WriteLine("Bigest number is {0}", maxNum); 
        }
        else if ((d > b) && (d > c) && (d > a) && (d > e))
        {
            Console.WriteLine("Bigest number is {0}", maxNum);   
        }
        else if ((e > b) && (e > c) && (e > d) && (a < e))
        {
            Console.WriteLine("Bigest number is {0}", maxNum);   
        }
    }
}
