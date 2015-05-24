using System;

//Write an expression that extracts from given integer n the value of given bit at index p.

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for p:");
        int p = int.Parse(Console.ReadLine());
        int i = 1;

        int mask = i << p;
        if ((i & mask)> 0)
        {
            int n1 = n = 1;  
        }
        Console.Write("The bit with index {0}", p);
        Console.Write(" is: ");
        Console.WriteLine((n & mask) != 0 ? 1 : 0);

    }
}