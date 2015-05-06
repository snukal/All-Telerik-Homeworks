using System;
using System.Linq;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose type: ");
        int num = int.Parse(Console.ReadLine());

        
        switch (num)
        {
            case 1:
                Console.WriteLine("Integer --> 1");
                Console.WriteLine("Please enter integer number: ");
                int integerNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(integerNumber + 1);
                break;
            case 2:
                Console.WriteLine("Double --> 2");
                Console.WriteLine("Please enter double number: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 3:
                Console.WriteLine("String --> 3");
                Console.WriteLine("Please enter integer number: ");
                string stringEntr = Console.ReadLine();
                Console.WriteLine(stringEntr + "*");
                break;
            default:
                break;  
        }

    }
}