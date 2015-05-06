using System;

class SumIntegers
{
    static void Main()
    {
        Console.Write("Please enter a sequence: ");
        string number = Console.ReadLine();

        string[] B = number.Split(' ');

        int Result = 0;
        

        foreach (string s in B)
        {
            int temp = 0;
            temp = int.Parse(s);
            Result += temp;
        }
        Console.WriteLine("The result is " + Result);

    }
}
