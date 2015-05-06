using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Is it beer time?");
        Console.Write("Please enter you time in format //hh:mm tt//:");
        DateTime beerTime = DateTime.Parse(Console.ReadLine());
        string sign = beerTime.ToString("tt");

        if (beerTime.Hour < 12)
        {
            if (sign == "AM")
            {
                if (beerTime.Hour >= 3 && beerTime.Minute >= 0 && beerTime.Minute < 60)
                {
                    Console.WriteLine("It's non-beer time");
                }
                else
                {
                    Console.WriteLine("Yeah, it's beer time! Cheers :)");
                }
            }
        }
        else
        {
            if (beerTime.Hour - 12 >= 1)
            {
                Console.WriteLine("Yeah, it's beer time! Cheers :)");
            }
            else
            {
                Console.WriteLine("It's non-beer time");
            }

        }
   }
}

