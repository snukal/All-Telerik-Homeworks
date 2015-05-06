using System;
using System.Text;  // For string builder


class Forbidden
{
    static void Main()
    {
        Console.Write("Input your text here: ");  // Case sensitive
        string n = Console.ReadLine();
        StringBuilder something = new StringBuilder();
        something.Append(n);
        Console.Write("Forbidden words separated by space: ");
        string[] forbiddenWords = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            if (something.ToString().Contains(forbiddenWords[i]))
            {
                something.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }
        }
        Console.WriteLine(something);
    }
}