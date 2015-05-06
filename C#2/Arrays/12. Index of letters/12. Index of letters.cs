using System;

class IndexOfLetters
{
    static void Main()
    {
        Console.Write("Insert word: ");
        char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        string theWord = Console.ReadLine();
        foreach (char symbol in theWord)
        {
            if (symbol == ' ')
            {
                Console.WriteLine();
                break;
            }
            for (int i = 0; i < alpha.Length; i++)
            {
                int symbol1 =Convert.ToChar( alpha[i]);
                if (alpha[i] == symbol)
                {
                    Console.WriteLine(@"Char ""{0}"" has index ""{1}"" in the Array", alpha[i], i);
                    break;  
                }
            }
            
        }

    }
}