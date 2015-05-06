using System;
class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        string lastDigit = Digit(number);

        Console.WriteLine("The last diggit of number " + number + " is " + lastDigit);
    }

    static string Digit(int number)
    {
        string lastDigit = number.ToString();
        lastDigit = lastDigit.Substring(lastDigit.Length -1 );

        switch (lastDigit)
        {
            case "1":
                lastDigit = "One";
                break;
            case "2":
                lastDigit = "Two";
                break;
            case "3":
                lastDigit = "Three";
                break;
            case "4":
                lastDigit = "Four";
                break;
            case "5":
                lastDigit = "Five";
                break;
            case "6":
                lastDigit = "Six";
                break;
            case "7":
                lastDigit = "Seven";
                break;
            case "8":
                lastDigit = "Eight";
                break;
            case "9":
                lastDigit = "Nine";
                break;
            case "0":
                lastDigit = "Zero";
                break;
            default:
                break;
        }
        return lastDigit;
    }
}
