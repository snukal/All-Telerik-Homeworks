using System;

class SubStringInText
{
    static void Main()
    {
        Console.WriteLine("Please enter sub-string:");
        string subString = Console.ReadLine().ToLower();
        Console.WriteLine("Please enter source:");
        string text = Console.ReadLine().ToLower();
        //int count = text.Length - text.Replace(subString, "").Length;
        int count = 0;
        int index = 0;
        while (true)
        {
            int found = text.IndexOf(subString, index);
            if (found < 0)
            {
                break;
            }

            index = found + 1;
            count++;
        }
        Console.WriteLine(count);
        /*
        for (int i = 0; i < subString.Length; i++)
        {
            if (i < 0)
            {
                Console.WriteLine(count);
                break;
            }
            else
            {
                Console.WriteLine(count/subString.Length);
                break;
            }
        }
*/
    }
}