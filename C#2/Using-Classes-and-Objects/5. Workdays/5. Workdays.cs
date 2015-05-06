using System;
using System.Linq;
using System.Threading;

class Workdays
{
    static void Main()
    {
        Console.Write("Please enter start date /dd.MM.yyyy/: ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        string one = startDate.ToShortDateString();
        Console.Write("Please enter end date /dd.MM.yyyy/: ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        string two = endDate.ToShortDateString();
        

        Console.WriteLine("Workdays are " + GetWorkingDays(startDate, endDate) + " For the period of "  + one + " to " + two);
    }

    static int GetWorkingDays(DateTime from, DateTime to)
    {
        var dayDifference = (int)to.Subtract(from).TotalDays;
        return Enumerable
            .Range(1, dayDifference)
            .Select(x => from.AddDays(x))
            .Count(x => x.DayOfWeek != DayOfWeek.Saturday && x.DayOfWeek != DayOfWeek.Sunday);
    }
}
