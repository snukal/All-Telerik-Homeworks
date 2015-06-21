namespace Students
{
    using System;
    using System.Collections.Generic;

    class TestWithMain
    {
        static void Main()
        {
            var students = new List<Student>
            {
              new Student("Maria","Ivanova","Georgieva", 123456789,23,"Borovinka","Mokresh",12345,"08867543234","maria@maria.net","Software Engineering",University.Telerik,UniversitySpecialty.WebServicesAndCloud, Faculty.Software),
              new Student("Pesho","Peshev","Goshev",234567890, 11, "Gorica", "Strashimirovo", 93012, "0987654321","pesho@goshev.com","Computer Sciences", University.NovBulgarski, UniversitySpecialty.DatabaseAdministration, Faculty.Hardware)
            };

            foreach (var student in students)
	        {
                Console.WriteLine(student);
	        }
            var firstStudent = new Student("Pesho", "Peshev", "Goshev", 234567890, 11, "Gorica", "Strashimirovo", 93012, "0987654321", "pesho@goshev.com", "Computer Sciences", University.NovBulgarski, UniversitySpecialty.DatabaseAdministration, Faculty.Hardware);
            var secondStudent = new Student("Pesho", "Atanasov", "Goshev", 234567890, 11, "Gorica", "Strashimirovo", 93012, "0987654321", "pesho@goshev.com", "Computer Sciences", University.NovBulgarski, UniversitySpecialty.DatabaseAdministration, Faculty.Hardware);
            Console.WriteLine("Testing overriding == and != Are these the same students? {0}", firstStudent == secondStudent);
            Console.WriteLine("Testing Equals(obj a) override. Are these the same students? {0}", firstStudent.Equals(secondStudent));
            Console.WriteLine("Testing GetHashCode() override. Are these the same students {0} {1}", firstStudent.GetHashCode(),secondStudent.GetHashCode());
            Console.WriteLine("Testing Cloning");
            var cloningStudent = (Student)secondStudent.Clone();
            Console.WriteLine("Are these the same students? {0} ", cloningStudent == secondStudent);
            Console.WriteLine("Are they saved at the same address in memory? {0}", ReferenceEquals(cloningStudent, secondStudent)); // should return false if the clone is working OK

            Console.WriteLine("Compare test {0}", firstStudent.CompareTo(secondStudent));
        }
    }
}
