using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        bool inRange = min <= max;

        if (inRange)
        {
            max += 1;

            Random randomGenerator = new Random();

            for (int i = 0; i <= n; i++)
            {
                int randomNumber = randomGenerator.Next(min, max);
                Console.Write(randomNumber + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input. Correct input --> min <= max");
        }
    }
}