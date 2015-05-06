/*
Problem 3. First before last
Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
Use LINQ query operators.
Problem 4. Age range
Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
 
Problem 5. Order students
Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
Rewrite the same with LINQ.
*/

namespace First_before_last
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FirstBeforeLastMain
    {
        public static List<Student> OrderedDiscendingLINQ(List<Student> students)
        {   
            var discendingSort =
                from st in students
                orderby st.FirstName descending, st.LastName
                select st;
            return discendingSort.ToList(); 
                
        }
        public static List<Student> OrderedDiscendingExtension(List<Student> students)
        {
            var discendingSort = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .ToList();
            return discendingSort;
        }

        public static List<Student> CompareAge(List<Student> students)
        {
            var sortedByAgeCollection =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select st;
            return sortedByAgeCollection.ToList();
        }

        public static List<Student> CompareStudent(List<Student> students)
        {
            var sortedCollection = from student in students
                                   where student.FirstName.CompareTo(student.LastName) < 0
                                   select student;
            return sortedCollection.ToList();
        }

        public static void DsplayResult(List<Student> students)
        { 
            foreach (var student in students)
	        {
                Console.WriteLine(student);	 
	        }
        }

        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Brat","Pit",30),
                new Student("Sasho","Aleksandrov",14),
                new Student("Krasi","Minev",20),
                new Student("Strahil","Ivanchev",15),
                new Student("Orlin","Gavrilov",28),
                new Student("Evstati","Menov",34)
            };
            //DsplayResult(CompareStudent(students));
            //DsplayResult(CompareAge(students));
            DsplayResult(OrderedDiscendingExtension(students));
            DsplayResult(OrderedDiscendingLINQ(students));

        }
    }
}
