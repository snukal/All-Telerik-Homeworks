using System;
class BinarySearch
{
    //Write a program that finds the index of given element in a sorted array of integers by using the Binary search 
    //algorithm.

    static void Main()
    {
        Console.Write("Enter number of elements in array:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter elements of array, each on separate line:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        //binary search
        Console.WriteLine("element to search: ");
        int toSearch = int.Parse(Console.ReadLine());
        int begin = 0, end = n - 1;
        while (begin <= end)
        {
            int mid = (begin + end) / 2;
            if (toSearch == array[mid])
            {
                break;
            }
            else
            {
                if (toSearch > array[mid])
                {
                    begin = mid;
                }
                else
                {
                    end = mid;
                }

            }
        }
        int position = (begin + end) / 2;
        Console.WriteLine("number {0} is on {1} position in a sorted array", array[position], position);
    }
}