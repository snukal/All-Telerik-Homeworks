using System;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();

        int lastIndex = input.Length - 1;

        long dec = 0;
        for (int i = 0; i < input.Length; i++, lastIndex--)
        {
            if (input[i].ToString().Contains("0"))
            {

            }
            else if (input[i].ToString().Contains("1"))
            {
                long binarySum = 1;
                for (int j = 0; j < lastIndex; j++)
                {
                    binarySum *= 2;
                }
                dec += binarySum;
            }
        }
        Console.WriteLine(dec);
    }
}