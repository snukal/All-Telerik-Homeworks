using System;
class AppearanceCount
{
    static void Main(string[] args)
    {
        int[] array = { 2,9,8,6,7,9,6,5,9,6};
        Console.WriteLine("Enter number: ");
        int number = Int32.Parse(Console.ReadLine());
        int count = Count(array, number);
        Console.WriteLine("{0} appears {1} times in the array", number, count);

    }
    static int Count(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}