namespace _64BitsArray
{
    using System;
    using System.Linq;

    class TestIt
    {
        static void Main()
        {
            ulong number = 18446744073709551615; //this is the biggest ulong number possible
            string s = Convert.ToString((long)number, 2);

            var arrNumber = new BitArray64<char>();
            for (int i = 0; i < s.Length; i++)
            {
                arrNumber[i] = s[i];
            }
         Console.WriteLine(arrNumber);
            
        }
    }
}
