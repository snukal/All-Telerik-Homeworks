namespace PersonTask
{
    using System;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            var firstPerson = new Person("Maria");
            var secondPerson = new Person("Georgi", 21);
            Console.WriteLine("Person with no age. {0}", firstPerson);
            Console.WriteLine("Person with age. {0}", secondPerson);
        }
    }
}
