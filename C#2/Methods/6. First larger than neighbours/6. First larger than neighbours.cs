using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] array = { 2, 22, 35, 68, 45, 11 };
        int postion = CheckingNeighbours(array);
        if (postion > 0)
        {
            Console.WriteLine("The element is on postion " + postion);
        }
        else
        {
            Console.WriteLine("No such element exists");
        }
    }

    static int CheckingNeighbours(int[] array)
    {
        int postion;
        postion = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1]) 
            {
                postion = i;
                break;
            }
        }
        return postion;

    }
}