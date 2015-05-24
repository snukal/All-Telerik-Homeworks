using System;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

    class DivideBySevenAndFive
{
    static void Main()
    {
       

        Console.WriteLine("Enter the number :");
        int takeNumm = int.Parse(Console.ReadLine());
        bool DevSeven = (takeNumm % 7) == 0;
        bool DevFive = (takeNumm % 5) == 0;
        if ((DevSeven == true) & (DevFive == true))
        {
            Console.WriteLine("The number CAN be devided by 7 and 5 at the same time");
        }
        else
        {
            Console.WriteLine("The number CAN'T be devided by 7 and 5 at the same time");
        }
    }
}