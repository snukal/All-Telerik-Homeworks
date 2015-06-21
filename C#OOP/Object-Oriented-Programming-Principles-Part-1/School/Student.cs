namespace SchoolProblem
{
    using System;

    public class Student : Person, IComment
    {
        private const string ExceptionText = "Name can't be null!";
        private string classNumber;

        public Student(string name, string classNumber) : base(name)
        {
            this.ClassNum = classNumber;
        }
        
        public string ClassNum 
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionText);
                }

                this.classNumber = value;
            }
        }
    }
}
