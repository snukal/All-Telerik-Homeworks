using System;
using System.Diagnostics;

class Url
{
    static void Main()
    {
        Console.Write("Input url: ");
        string s = Console.ReadLine();
        int twoDots = s.IndexOf(":");
        ErrorInput(twoDots);
        string protokol = s.Substring(0, twoDots); 
        int slashSlash = s.IndexOf("//");
        ErrorInput(slashSlash);
        slashSlash += 2;
        int onlySlash = s.IndexOf("/", slashSlash);
        ErrorInput(onlySlash);
        string server = s.Substring(slashSlash, onlySlash - slashSlash);  
        string resource = s.Substring(onlySlash + 1);   
        Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resourse] = {2}", protokol, server, resource);

        Console.WriteLine("Opening browser...");
        try
        {

            Process.Start(s);  
        }
        catch (System.ComponentModel.Win32Exception)
        {
            Console.WriteLine("Try not break program");
            Console.ReadLine();
            Console.Clear();
            Main();
        }
    }
    static void ErrorInput(int a)
    {
        if (a < 0)
        {
            Console.WriteLine("Invalid Url! ");
            Console.ReadLine();
            Console.Clear();
            Main();
        }
    }
}