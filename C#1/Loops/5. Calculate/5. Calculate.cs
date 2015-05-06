using System;

class CalcSomeSHt
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        int prodN = 1;
        int numberN = 1;
        int exprX = 1;
        int tempX = x;
        while (numberN <= n)
        {
            prodN *= numberN;
            numberN++;

            
                exprX += prodN / tempX;
                tempX++;
            
        }
        //S = 1 + 1!/x + 2!/x2 + … + n!/x^n

        double poweredXN = Math.Pow(x, n);
        double S = (exprX + prodN / poweredXN);
        Console.WriteLine("S = {0:F5}",S);

    }
}
