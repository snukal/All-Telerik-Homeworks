using System;

class CalculateNK
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int prodN = 1;
        int numberN = 1;
        int prodK = 1;
        int numberK = 1;
        while (numberN <= n)
        {
            prodN *= numberN;
            numberN++;
        }
        
            while (numberK <= k)
            {
                prodK *= numberK;
                numberK++;

                
            }
            if ((1 < k) || (k < n) || (n < 100))
            {
                Console.WriteLine(prodN / prodK);

            }
            else
            {
                Console.WriteLine("Invalid value!");
            }
        

    }
}
