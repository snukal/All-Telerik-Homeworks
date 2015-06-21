/*
Problem 6. Divisible by 7 and 3
Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/ 

namespace Divisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DivisingMain
    {
        public static int[] DevideLINQ(int[] nums)
        {
            var devideNums =
                from num in nums
                where num % 21 == 0
                select num;
            return devideNums.ToArray();
        }
        public static int[] DevideExtension (int[] nums)
        {
            var devideNums =
                nums.Where(num => num % 21 == 0).ToArray();
            return devideNums;
        }
        
        static void Main()
        {
            //List<int> Listence = new List<int>
            //{ 1, 5, 6, 68, 7, 3218, 21 , 58, 33 };
            int[] numbers = Enumerable.Range(1, 100).ToArray();

            System.Console.WriteLine(string.Join(", ", DevideLINQ(numbers)));

            Console.WriteLine(new String('-', 14));

            System.Console.WriteLine(string.Join(", ", DevideExtension(numbers)));
        }

        
    }
}
