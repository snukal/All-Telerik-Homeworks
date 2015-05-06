using System;
using System.Text;

class ReverseStringD
{
    static void Main()
    {
        string aString = Console.ReadLine();
        Console.WriteLine(ReverseString(aString));

    }
    public static string ReverseString(string s)
    {
        StringBuilder sb = new StringBuilder(s.Length);
        for (int i = s.Length - 1; i >= 0; i--)
            sb.Append(s[i]);
        return sb.ToString();
        
    }


}