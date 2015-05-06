using System;
using System.Linq;

class MInMax
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double [] a = new double[n];
        double sum = 0;
        double avg = sum / n;
        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            a[i] = num;
            sum += a[i];
        }
        Console.WriteLine(a.Min());
        Console.WriteLine(a.Max());
        Console.WriteLine(sum);
        Console.WriteLine("{0:0.00}",sum /n);
    }
}