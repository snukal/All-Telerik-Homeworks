/*Problem 3. Range Exceptions

Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].*/
namespace Range_Exceptions
{
    using System;

    public class RangeExceptionsMain
    {
        private const string NumberMessageForConsoleWriteLine = "Enter number between {0} and {1}";
        private const string DateMessageForConsoleWriteLine = "Enter date between {0} and {1}";
        private const int LolwerLimit = 1;
        private const int UpperLimit = 100;
        private const string DateStringLowerLimit = "01.01.1980";
        private const string DateStringUpperLimit = "31.12.2013";

        public static void Main()
        {
            // int check
            Console.WriteLine(NumberMessageForConsoleWriteLine, LolwerLimit, UpperLimit);

            var parsedNumber = int.Parse(Console.ReadLine());

            if (parsedNumber < LolwerLimit || parsedNumber > UpperLimit)
            {
                throw new InvalidRangeException<int>(LolwerLimit, UpperLimit);
            }

            // DateTime check
            Console.WriteLine(DateMessageForConsoleWriteLine, DateStringLowerLimit, DateStringUpperLimit);

            var parsedDate = DateTime.Parse(Console.ReadLine()).ToString();

            if (parsedDate.CompareTo(DateTime.Parse(DateStringLowerLimit)) < 0 || parsedDate.CompareTo(DateTime.Parse(DateStringUpperLimit)) > 0)
            {
                throw new InvalidRangeException<DateTime>(DateTime.Parse(DateStringLowerLimit), DateTime.Parse(DateStringUpperLimit));
            }
        }
    }
}
