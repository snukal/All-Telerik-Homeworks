using System;

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for v (v = 0 or v = 1) :");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for p :");
        int p = int.Parse(Console.ReadLine());

        if (v == 1)
            {
                n = n | ((1 << p)); // set 1 on position p
            }
        else if (v == 0)
        {
            n = n & (~(1 << p)); // set 0 on position p
            Console.WriteLine(n);
        }
        else if (v != 0 && v != 1)
        {
            Console.WriteLine("The value for v must be either 1 either 0");
        }
	      
    }
}