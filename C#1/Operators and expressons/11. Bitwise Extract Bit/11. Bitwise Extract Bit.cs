using System;

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

class BitwiseExtractBit
{
    static void Main()
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int i = 1;

        int mask = i << p;
        if ((i & mask) > 0)
        {
            int n1 = n = 1;
        }
        Console.Write("Bit #3 is:");
        Console.WriteLine((n & mask) != 0 ? 1 : 0);

    }
}
