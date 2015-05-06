using System;


class FormatingANumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("{0,15} , {1,15} , {2,15} , {3,15}", "Decimal", "Percentage", "Hexadecimal", "Exponent Notation");
        Console.WriteLine();
        Console.Write("{0,15:D} , {0,15:P} , {0,15:X} , {0,15:E2}", a);
        Console.WriteLine();
    }
}