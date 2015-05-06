using System;

class CalculateNK
{
    static void Main()
    {
        Console.Write("Enter n = : ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter k = : ");
        int coeficient = int.Parse(Console.ReadLine());

        double multidevider = 1;
        double subtractor = 1;
        int subCounter = number - coeficient;
        double faktoriel = 1;

        if (coeficient < number && coeficient > 1 && number < 100)
        {
            for (double count = 1; count <= number; count++)
            {
                if (coeficient >= count)
                {

                    multidevider *= count;
                }
                if (subCounter >= count)
                {
                    subtractor *= count;
                }
                faktoriel = faktoriel * count;
            }
            double division = faktoriel / (multidevider * subtractor);
            Console.WriteLine("n! / (k! * (n-k)!) =  {0}", division, number, coeficient);

        }
        else
        {
            Console.WriteLine("Invalid entry. (1 < k < n < 100)");
        }
    }
}
