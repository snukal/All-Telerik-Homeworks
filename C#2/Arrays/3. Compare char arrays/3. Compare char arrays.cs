using System;
class CompareCharArrays
{
    static void Main()
    {
        char[] Arr1 = new char[int.Parse(Console.ReadLine())];
        for (int i = 0; i < Arr1.Length; i++)
        {
            Arr1[i] = char.Parse(Console.ReadLine());
        }
        char[] Arr2 = new char[int.Parse(Console.ReadLine())];
        for (int i = 0; i < Arr2.Length; i++)
        {
            Arr2[i] = char.Parse(Console.ReadLine());
        }
        int biggerArr = 0;

        if (Arr1.Length < Arr2.Length) // check which of the two Arrays is bigger or are they equal!
        {
            biggerArr = Arr2.Length;
        }
        else if (Arr2.Length < Arr1.Length)
        {
            biggerArr = Arr1.Length;
        }
        else
        {
            biggerArr = Arr1.Length;
        }
        for (int i = 0; i <biggerArr; i++)
        {
            int n = 0;
            int m = 0;

            char symbol1 = (char)Arr1[i];
            int chara1 = symbol1 - 'a';
            n = chara1;
            char symbol2 = (char)Arr2[i];
            int chara2 = symbol2 - 'a';
            m = chara2;

            if (n !=m)
            {
                if (n<m)
                {
                    Console.WriteLine("Arr1 is first!");
                    break;
                }
                else if (n > m)
                {
                    Console.WriteLine("Arr2 is first!");
                    break;
                }
            }
            
        }
    }
}
