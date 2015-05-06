using System;

class GetLargestNumber
{
    
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Max value is " + GetMax(GetMax(firstNum,secondNum),thirdNum));
    }

    static int GetMax( int aNum, int bNum)
    {
        int biggerNum = bNum;
        if (aNum > bNum)
        {
            biggerNum = aNum;   
        }
        return biggerNum;
    }
}
