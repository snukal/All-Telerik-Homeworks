using System;
    
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] arrN = new int[n];
        int sum = 0;
        for (int i = 0; i < arrN.Length; i++)
        {
            arrN [i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrN);
        for (int i = arrN.Length -1; i > k; i--)
        {
            sum += arrN[i];
        }
        Console.WriteLine("The maximal sum for {0} elemnts is: {1}",k, sum);

    }
}
