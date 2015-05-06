using System;
using System.IO;

// Write a program that replaces all occurrences of the 
// sub-string start with the sub-string finish in a text file.
// Ensure it will work with large files (e.g. 100 MB).

public class ReplaceSubString
{
    public static void Main(string[] args)
    {
        using (StreamReader streamReader = new StreamReader("../../Text.txt"))
        {
            using (StreamWriter streamWriter = new StreamWriter("../../Result.txt"))
            {
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    streamWriter.WriteLine(line.Replace("start", "finish"));
                    line = streamReader.ReadLine();
                }

                Console.WriteLine("Result.txt - Done");
            }
        }
    }
}