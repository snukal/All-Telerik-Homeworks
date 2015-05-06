using System;

class CompareArrays
{
    static void Main()
    {
        int[] Arr1 = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < Arr1.Length;i++)
        {
            Arr1[i] = int.Parse(Console.ReadLine());
        }
        int[] Arr2 = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < Arr2.Length;i++) 
        {
            Arr2[i] = int.Parse(Console.ReadLine());
        }
        int biggerArr = 0;      

        if (Arr1.Length  < Arr2.Length) // check which of the two Arrays is bigger or are they equal!
        {
            biggerArr = Arr2.Length;
        }
        else if (Arr2.Length  < Arr1.Length)
        {
            biggerArr = Arr1.Length;
        }
        else
        {
            biggerArr = Arr1.Length;
        }
        for (int i = 0; i < biggerArr; i++)
        {
            if (Arr1[i] != Arr2[i])
            {
                Console.WriteLine("Different elements for index " + i);
            }
            else
            {
                Console.WriteLine("Elements for index {0} are equal ", i);
            }
        }

    }
}
