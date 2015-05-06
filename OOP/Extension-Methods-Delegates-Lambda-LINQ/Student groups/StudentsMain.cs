/*
 Problem 9. Student groups
   Create a class `Student` with properties `FirstName`, `LastName`, `FN`, `Tel`, `Email`, `Marks` (a List<int>), `GroupNumber`.
   Create a `List<Student>` with sample students. Select only the students that are from group number 2.
   Use LINQ query. Order the students by FirstName.
 
 Problem 10. Student groups extensions
   Implement the previous using the same query expressed with extension methods.
 
 Problem 11. Extract students by email
   Extract all students that have email in `abv.bg`.
   Use `string` methods and LINQ.
 
 Problem 12. Extract students by phone
   Extract all students with phones in Sofia. Use LINQ.
 
 Problem 13. Extract students by marks
   Select all students that have at least one mark `Excellent` (`6`) into a new anonymous class that has properties – `FullName` and     `Marks`. Use LINQ.
 Problem 14. Extract students with two marks
   Write down a similar program that extracts the students with exactly two marks "`2`". Use extension methods.
 
 Problem 15. Extract marks 
   Extract all `Marks` of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
 
 Problem 16.* Groups
   Create a class `Group` with properties `GroupNumber` and `DepartmentName`.
   Introduce a property `Group` in the `Student` class.
   Extract all students from "Mathematics" department.
   Use the `Join` operator.
 
 Problem 18. Grouped by GroupName
   Create a program that extracts all students grouped by `GroupName` and then prints them to the console. Use LINQ.
 Problem 19. Grouped by GroupName extensions
   Rewrite the previous using extension methods.
 */


namespace Student_groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StudentsMain
    {

        public static Dictionary<int, string> GroupStudentsByGroupNumberExpressions(List<Student> students)
        {
            var groupedStudents = students.GroupBy(s => s.GroupNumber);

            var grouped = new Dictionary<int, string>();

            foreach (var group in groupedStudents)
            {
                var currentGorup = new List<string>();

                foreach (var student in group)
                {
                    currentGorup.Add(student.FirstName + " " + student.LastName);
                }

                grouped.Add(group.Key, string.Join(", ", currentGorup));
            }

            return grouped;
        }

        public static Dictionary<int, string> GroupStudentsByGroupNumberLINQ(List<Student> students)
        {
            var groupedStudents = from student in students
                                  group student by student.GroupNumber;

            var grouped = new Dictionary<int, string>();

            foreach (var group in groupedStudents)
            {
                var currentGorup = new List<string>();

                foreach (var student in group)
                {
                    currentGorup.Add(student.FirstName + " " + student.LastName);
                }

                grouped.Add(group.Key, string.Join(", ", currentGorup));
            }

            return grouped;
        }

        public static List<Student> ExtractStudentsByDepartmentName(List<Student> students)
        {
            var groups = new List<Group>
			             {
							new Group(1, "Biology"),
							new Group(2, "Mathematics"),
							new Group(3, "Chemistry"),
			             };

            var selectedStudents =
                from student in students
                join gr in groups on student.GroupNumber equals gr.GroupNumber
                where gr.DepartmentName == "Mathematics"
                select student;

            return selectedStudents.ToList<Student>();
        }

        public static List<dynamic> ListOfEnrolled(List<Student> students)
        { 
            var listing = students
                .Where(st => st.FN.Substring(4, 2) == "06")
                .Select(st => new
                {
                    Marks = string.Join(", ", st.Marks)
                });
            return listing.ToList<dynamic>();
                
        }
        public static List<dynamic> ListOfMarksExtension(List<Student> students)
        {
            var listing = students
                .Where(st => st.Marks.Count == 2)
                .Select(st => new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = string.Join(", ", st.Marks)
                }
                );
            return listing.ToList<dynamic>();
        }
        public static List<dynamic> ListOfMarksExcelentLINQ(List<Student> students)
        {
            var listing =
                from st in students
                where st.Marks.Contains(6)
                select new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = string.Join(", ",st.Marks)
                };
            return listing.ToList<dynamic>();
        }

        public static List<Student> ListOfPhonesLINQ(List<Student> students)
        {
            var listing =
                from st in students
                where st.Tel.Contains("02/")
                select st;
            return listing.ToList();
        }

        public static List<Student> ListOfEmailLINQ(List<Student> students)
        {
            var listing =
                from st in students
                where st.Email.Contains("abv.bg")
                select st;
            return listing.ToList<Student>();
        }

        public static List<Student> ListOfGroupTwoLINQ(List<Student> students)
        {
            var listing =
                from st in students
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;
            return listing.ToList<Student>();
        }

        public static List<Student> SecondGroupExtensionMethods(List<Student> students)
        {
            return students
                .Where(s => s.GroupNumber == 2)
                .OrderBy(s => s.FirstName)
                .ToList<Student>();
        }

        public static void DisplayResult<T>(List<T> students)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < students.Count; i++)
            {
                sb.Append(students[i].ToString());
                sb.AppendLine();
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }

        public static void DisplayResult(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void DisplayResult(Dictionary<int, string> studets)
        {
            foreach (var studet in studets)
            {
                Console.WriteLine("Group {0}", studet.Key + "-" + studet.Value);
            }
        }

        static void Main()
        {
            List<Student> studentslist = new List<Student> 
           {
               new Student("Stamat", "Penchev", "7024268", "02/9730177", "stamat@yahoo.com", 1, new List<int>{5, 6,}),
               new Student("Pesho", "Ivanov", "2024068", "02/9735001", "pesho@abv.bg", 2, new List<int>{2, 3, 6,}),
               new Student("Gosho", "Dimitrov", "3054769", "052/9920177", "gosho@gmail.com", 1, new List<int>{6, 5, 6, 6}),
               new Student("Balkan", "Georgiev", "2655268", "02/9332242", "balkan@mail.bg", 2, new List<int>{2, 2, 3, 3}), 
               new Student("Gospodin", "Gospodinov", "5353068", "032/5440000", "gospodin@gmail.com", 3, new List<int>{4, 5, 4, 4})
           };

            //DisplayResult(ListOfGroupTwoLINQ(studentslist));
            //DisplayResult(SecondGroupExtensionMethods(studentslist));
            //DisplayResult(ListOfEmailLINQ(studentslist));
            //DisplayResult(ListOfEnrolled(studentslist));....TEST ZONE.Use the themplate!
        }
    }
}
