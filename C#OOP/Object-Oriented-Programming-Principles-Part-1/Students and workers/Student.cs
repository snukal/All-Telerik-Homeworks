namespace Students_and_workers
{
    using System;

    public class Student : Human
    {
        private string grade;

        public Student(string firstName, string lastName, string grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public string Grade 
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Grade canot be null or empty");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name: {0} Last name: {1}", this.FirstName, this.LastName);
        }
    }
}
