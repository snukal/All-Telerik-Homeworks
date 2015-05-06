using System;
//  You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).


class SortsByLength
{
    static void Main()
    {

        string[] array = { "Messi", "RobinVanPersie", "Berbatov", "Isko", "HristoStoichkov" };

        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
    }
}