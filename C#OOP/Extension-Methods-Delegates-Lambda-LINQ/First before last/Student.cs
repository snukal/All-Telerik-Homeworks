namespace First_before_last
{
    using System;
     public class Student 
    {
         private string firstName;
         
         private string lastName;

         private int age;

         public Student(string firstName, string lastName) 
         {
             this.FirstName = firstName;
             this.LastName = lastName;
         }
         public Student(string firstName, string lastName, int age) :this(firstName,lastName)
         {
             this.Age = age;
         }

         public string FirstName
         {
             get 
             {
                 return this.firstName;
             }

             private set
             {
                 if (string.IsNullOrEmpty(value))
                 {
                     throw new ArgumentException("MAT");
                 }

                 this.firstName = value;
             }
         }

         public string LastName 
             {
             get 
             {
                 return this.lastName;
             }
             private set
             {
                 if (string.IsNullOrEmpty(value) || char.IsLower(value[0]))
                 {
                     throw new ArgumentException("MATHa");
                 }

                 this.lastName = value;
             }
         }

         public int Age 
             {
             get 
             {
                 return this.age;
             }
             private set
             {
                 if (value <= 0)
                 {
                     throw new ArgumentException("MATHAFAKA");
                 }

                 this.age = value;
             }
         }

         public override string ToString()
         {
             return string.Format("{0} {1} is {2} old", this.FirstName, this.LastName, this.Age);
         }
         
    }
}
