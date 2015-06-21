/*
Problem 2. Students and workers

Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
*/
namespace Students_and_workers
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Students_WorkrsMain
    {
        public static IEnumerable<string> ListOfMergedAndSortedLists(List<Student> students, List<Worker> workers)
        {
            var namesStudents = students.Select(st => st.FirstName + " " + st.LastName);
            var nameWorker = workers.Select(w => w.FirstName + " " + w.LastName);
            var listing = namesStudents.Union(nameWorker).ToList();
            return listing;
        }

        public static IEnumerable<string> ListOfAsceningOrderedStudentsByGrade(List<Worker> workers)
        {
            var orderedWorkers = workers
                .OrderByDescending(worker => worker.MoneyPerHour())
                .Select(worker => string.Format("{0} {1}", worker.FirstName, worker.LastName));
            return orderedWorkers;
        }

        public static IEnumerable<string> ListOfAsceningOrderedStudentsByGrade(List<Student> students)
        {
            var listing =
                from st in students
                orderby st.Grade ascending
                select string.Format("{0} {1}", st.FirstName, st.LastName);
            return listing.ToList();
        }

        public static void Main()
        {
            List<Worker> listOfWorkers = new List<Worker>
            {
                new Worker("Poli", "Kaskin", 2, 230),
                new Worker("Ibra", "Ivanov", 6, 300),
                new Worker("Ahmed", "Dragoeva", 7, 500),
                new Worker("Grisho", "Petrov", 8, 500),
                new Worker("Paolo", "Djalil", 5, 300),
                new Worker("Dino", "Black", 4, 200),
                new Worker("John", "Dickinson", 4, 400),
                new Worker("Astrid", "Petrov", 8, 500),
                new Worker("Morfema", "Stoyanpv", 8, 500),
                new Worker("Kamel", "Kirov", 8, 500)
            };

            List<Student> listOfStudents = new List<Student>
            {
                new Student("Ivan", "Kaskin", "1klas"),
                new Student("Asen", "Ivanov", "2klas"),
                new Student("Elica", "Dragoeva", "3klas"),
                new Student("Abdul", "Petrov", "4klas"),
                new Student("Ferhunde", "Djalil", "2klas"),
                new Student("Damaj", "Black", "3klas"),
                new Student("Djedadaq", "Dickinson", "2klas"),
                new Student("Kosio", "Petrov", "11klas"),
                new Student("Iliika", "Stoyanpv", "1klas"),
                new Student("Azis", "Kirov", "1klas")
            };

            DisplayResult(ListOfMergedAndSortedLists(listOfStudents, listOfWorkers));
            System.Console.WriteLine();
        }
        //// hepl methods

        public static void DisplayResult(IEnumerable<string> students)
        {
            foreach (var student in students)
            {
                System.Console.WriteLine(student);
            }
        }
    }
}
