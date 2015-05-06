using System;
class Program
{
    static void Main()
    {

        int[] arr = {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};

        int element = 0;
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int tempElement = arr[i];
            int tempCount = 0;
            for (int p = 0; p < arr.Length; p++)
            {
                if (arr[p] == tempElement)
                {
                    tempCount++;
                }
            }
            if (tempCount > count)
            {
                count = tempCount;
                element = tempElement;
            }
        }
        Console.WriteLine("The most freaquent number is {0} -> {1} times in the array", element, count);
    }
}
