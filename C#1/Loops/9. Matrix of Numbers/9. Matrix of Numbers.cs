using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Matrix");
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i + j + " ");
            }
            Console.WriteLine();  
        }
    }
}