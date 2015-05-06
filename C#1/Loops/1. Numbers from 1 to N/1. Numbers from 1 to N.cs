using System;

class NumbersFromOneToN
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int tempN = 0;
        
        for (int i = 1; i < n; i++)
        {
            ++tempN;
            Console.Write("{0} ",tempN);
        }
        Console.WriteLine(tempN +1);
    }
}
