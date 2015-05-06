/*
Problem 1. StringBuilder.Substring
Implement an extension method Substring(int index, int length) for the class StringBuilder 
that returns new StringBuilder and has the same functionality as Substring in the class String.
*/

using System;
using System.Text;

namespace StringBuilderSubstring
{
  
    public class MainStringBuilber
    {
        public static void Main()
        {
            StringBuilder kor = new StringBuilder();
            kor.Append("gazar");
            
            Console.WriteLine(kor.Substring(1, 2));
        }
    }
}
