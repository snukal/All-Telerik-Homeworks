using System;

////Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter value: ");
        int num = int.Parse(Console.ReadLine());
        
        if (num <= 3 && num >=1)
        {
           Console.WriteLine(num = num * 10);
           num = num / 10;
        }
        else if (num <= 6 && num >=4)
	    {
	    	Console.WriteLine(num = num * 100);
           num = num / 100; 
	    }
        else if (num <= 9 && num >=7)
	    {
	    	Console.WriteLine(num = num * 1000);
           num = num / 1000; 
	    }
        else if (num <= 0 || num >=10)
        {
            Console.WriteLine("Invalid score");
        }
      }
}
