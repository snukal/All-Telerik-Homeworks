using System;
using System.Threading;
using System.Globalization;
class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Result: ");
        if (a>0 && b>0 && c>0)
        {
            Console.WriteLine("+"); 
        }
        else if ((a > 0 && b < 0 && c < 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0))
        {
            Console.WriteLine("+");    
        }
        else if ((a>0 && b>0 && c<0) || (a>0 && b<0 && c>0) || (a<0 && b>0 && c>0) || (a<0 && b<0 && c<0))
        {
            Console.WriteLine("-");
        }
        else if (((a > 0 && b > 0 && c == 0) || (a > 0 && b == 0 && c > 0) || (a == 0 && b > 0 && c > 0)) || ((a == 0 && b > 0 && c == 0) || (a > 0 && b == 0 && c == 0) || (a == 0 && b == 0 && c > 0)) || (a == 0 && b == 0 && c == 0))
        {
            Console.WriteLine("0");
        }
    }
}
