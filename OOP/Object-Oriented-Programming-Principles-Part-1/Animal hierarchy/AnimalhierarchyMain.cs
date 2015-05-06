/*Problem 3. Animal hierarchy

Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/
namespace Animal_hierarchy
{
    using System;
    using System.Text;

    public class AnimalhierarchyMain
    {
        private static StringBuilder sb = new StringBuilder();

        public static void Main()
        {
            Dog[] dogs = 
            {
                             new Dog("Balkan", Gender.Male, 5),
                             new Dog("Pesko", Gender.Male, 3),
                             new Dog("Koicho", Gender.Male, 2),
                             new Dog("Sherry", Gender.Female, 1)
                         };

            Cats[] cats = 
            {
                             new Cats("Tomy", Gender.Male, 7),
                             new Cats("Milenco", Gender.Male, 2),
                             new Cats("Spaska", Gender.Female, 3),
                             new Cats("Kalinka", Gender.Female, 5)
            };

            Frog[] frogs = 
            {
                               new Frog("Stamat", 1, Gender.Male),
                               new Frog("Pesho", 3, Gender.Male),
                               new Frog("Penka", 2, Gender.Female),
                               new Frog("Kapka", 7, Gender.Female)
                           };

            Kitten[] kittens = 
            {
                                   new Kitten("Minka", 2),
                                   new Kitten("Nadka", 4),
                                   new Kitten("Milena", 11),
                                   new Kitten("Sashka", 7)
                               };

            Tomcat[] tomcats = 
            {
                                   new Tomcat("Tom", 9),
                                   new Tomcat("Sam", 5),
                                   new Tomcat("Bill", 3),
                                   new Tomcat("Jhony", 12),
                               };

            double catsAverageAge = Animals.CalculateAverageAge(cats);
            double dogsAverageAge = Animals.CalculateAverageAge(dogs);
            double tomcatsAverageAge = Animals.CalculateAverageAge(tomcats);
            double kittensAverageAge = Animals.CalculateAverageAge(kittens);
            double frogsAverageAge = Animals.CalculateAverageAge(frogs);

            sb.AppendLine("Cats average age is: " + catsAverageAge)
                .AppendLine("Dogs average age is: " + dogsAverageAge)
                .AppendLine("Frogs average age is: " + frogsAverageAge)
                .AppendLine("Kittens average age is: " + kittensAverageAge)
                .AppendLine("Tomcats average age is: " + tomcatsAverageAge);

            Console.WriteLine(sb);
        }
    }
}
