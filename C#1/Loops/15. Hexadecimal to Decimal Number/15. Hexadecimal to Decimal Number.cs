using System;

class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();

        int lastIndex = input.Length - 1;

        long dec = 0;
        for (int i = 0; i < input.Length; i++, lastIndex--)
        {
            int currentNumberInHex;
            switch (input[i])
            {
                case 'A':
                    currentNumberInHex = 10;
                    break;
                case 'B':
                    currentNumberInHex = 11;
                    break;
                case 'C':
                    currentNumberInHex = 12;
                    break;
                case 'D':
                    currentNumberInHex = 13;
                    break;
                case 'E':
                    currentNumberInHex = 14;
                    break;
                case 'F':
                    currentNumberInHex = 15;
                    break;
                default:
                    currentNumberInHex = int.Parse(input[i].ToString());
                    break;
            }
            long hexSum = 1;
            for (int j = 0; j < lastIndex; j++)
            {
                hexSum *= 16;
            }
            hexSum *= currentNumberInHex;
            dec += hexSum;
        }
        Console.WriteLine(dec);
    }
}