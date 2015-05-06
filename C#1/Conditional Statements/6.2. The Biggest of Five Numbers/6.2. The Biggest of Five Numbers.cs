using System;
using System.Linq;

class TheBiggestOfFiveNumbersSecondVersion
{
    static void Main()
    {
        Console.WriteLine("Enter values for the five numbers: ");
        double[] nums = new double[5];

            for (int i = 0; i < 5; i++)
            {
                nums[i] = double.Parse(Console.ReadLine());
            }

        double BiggestNumber = nums.Max();

        Console.WriteLine("The biggest number is {0}", BiggestNumber);
    }
}