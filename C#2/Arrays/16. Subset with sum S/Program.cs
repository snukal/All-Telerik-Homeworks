using System;
class SubsetWithSumS
{
    static void Main()
    {
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };

        int S = 14;
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (sum<S)
            {
                sum += arr[i];
            }
            
        }

    }
}