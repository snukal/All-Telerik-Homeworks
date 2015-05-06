using System;


class Sentence
{
    static void Main()
    {
        Console.Write("Input text here: ");
        string[] sentences = Console.ReadLine().Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries);

        Console.Write("Hint: surround text with spaces to find exact. Word: ");
        string word = Console.ReadLine();
        foreach (var w in sentences)
        {
            if (w.Contains(word))
            {
                Console.WriteLine("--> {0}", w);
            }
        }
    }
}