using System;

class Divisible 
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int tempN = 0;
        for (int i = 1; i < n; i++)
        {
            tempN++;
            if ((tempN % 7 != 0) && (tempN % 3 != 0))
            {
                
                Console.Write("{0} ", tempN);
                
            }
            
        }
        Console.WriteLine("{0}", tempN + 1);
    }
}
