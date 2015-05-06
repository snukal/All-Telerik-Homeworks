using System;

class DecimalToBinary
{
    static void Main()
    {

        int num = int.Parse(Console.ReadLine());
        string devided = string.Empty; // mke the string empty
        int reminder = 0;

        while (num > 0)
        {
            num /= 2;
            reminder = num % 2;
            devided = reminder.ToString() + devided;// reminder is converted to string and then add to "devided"
        }
        Console.WriteLine(devided);
    }
}
