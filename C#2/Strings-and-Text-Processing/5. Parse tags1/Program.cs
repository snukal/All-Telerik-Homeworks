using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Tags
{
    static void Main()
    {
        Console.Write("Enter tex here: ");
        string input = Console.ReadLine();
        int startIdx;
        int endIdx;
        int length;
        string result;
        string final;
        while (input.IndexOf("<upcase>") != -1)
        {
            startIdx = input.IndexOf("<upcase>") + 8;
            endIdx = input.IndexOf("</upcase>");
            length = endIdx - startIdx;
            if (length < 0)
            {
                break;
            }
            result = "<upcase>";
            result += input.Substring(startIdx, length);
            final = input.Substring(startIdx, length);

            result += "</upcase>";
            input = input.Replace(result, final.ToUpper());

        }
        Console.WriteLine("\n{0}", input);
    }
}
