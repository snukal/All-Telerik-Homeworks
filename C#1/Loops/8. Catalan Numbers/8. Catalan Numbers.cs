﻿using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        double n = double.Parse(Console.ReadLine());
        bool inRange = n > 1 && n < 100;

        if (inRange)
        {
            double nPlusOne = n + 1;

            BigInteger nFactorial = 1;
            BigInteger nPlusOneFactorial = 1;
            BigInteger doubleNFactorial = 1;
            BigInteger result = 0;

            for (int i = 1; i <= 2 * n; i++)
            {
                doubleNFactorial *= i;

                if (i <= n)
                {
                    nFactorial *= i;
                }
                if (i <= nPlusOne)
                {
                    nPlusOneFactorial *= i;
                }
            }
            result = doubleNFactorial / (nPlusOneFactorial * nFactorial);
            Console.WriteLine("{0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input. Correct input --> 1 < n < 100");
        }
    }
}