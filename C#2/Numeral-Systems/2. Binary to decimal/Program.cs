using System;

class BinaryToDecimal
{
    static void Main()
    {
        string num = Console.ReadLine();

        int rezult = 0; 
        for (int i = 0; i < num.Length; i++)
        {
            if (num[num.Length- i -1 ]=='0')
            {
                continue;
            }
            rezult += (int)Math.Pow(2,i);
        }
        Console.WriteLine(rezult);
    }
}
