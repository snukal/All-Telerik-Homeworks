using System;
using System.Text;


class ReplaceTa
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string n = Console.ReadLine();
        StringBuilder text = new StringBuilder();
        text.Append(n);
        text.Replace("<a href=\"", "[URL=");
        text.Replace("\">", "]");
        text.Replace("</a>", "[/URL]");
        Console.WriteLine(text);
    }
}