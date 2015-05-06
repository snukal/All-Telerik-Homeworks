using System;

class LargerThan
{
    static void Main(string[] args)
    {
        int[] array = { 2, 22, 35, 68, 45, 11 };
        int postion = int.Parse(Console.ReadLine());
        if (CheckingNeighbours(array, postion))
        {
            Console.WriteLine("{0} is greater than {1} and {2} ", array[postion], array[postion - 1], array[postion + 1]);
        }
        else
        {
            Console.WriteLine("{0} is not greater than {1} and {2} ", array[postion], array[postion - 1], array[postion + 1]);
        }

    }

    static bool CheckingNeighbours(int[] array, int postion)
    {
        bool isGreater = false;
        if (postion < array.Length && postion > 0)
        {
            if (array[postion] > array[postion - 1] && array[postion] > array[postion + 1]) 
            {
                isGreater = true;
            }
        }
        else
        {
            Console.WriteLine("No neighbours");
            Environment.Exit(1);
        }
        return isGreater;

    }
}