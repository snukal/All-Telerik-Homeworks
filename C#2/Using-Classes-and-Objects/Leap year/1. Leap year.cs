using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        DateTime yearCheck = new DateTime(year,2,28);
        if (DateTime.IsLeapYear (year))
        {
            Console.WriteLine("Is {0} leap year? ---> {1}", year, DateTime.IsLeapYear(year));   
        }
        else
        {
            Console.WriteLine("Nope!");
        }

    }
}
