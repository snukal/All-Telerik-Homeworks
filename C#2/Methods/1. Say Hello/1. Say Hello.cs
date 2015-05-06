using System;

class SayHello
{
    static void Main()
    {
        Ask();
    }
    
    static void Ask()
    {
        Console.Write("Please, enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Hello {0}!", name);
        Console.WriteLine();
        

    }
}
