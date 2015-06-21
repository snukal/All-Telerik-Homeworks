namespace SchoolProblem
{
    using System;

    public class Person
    {
        private const string ExceptionText = "Name can't be null!";
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionText);
                }

                this.name = value;
            }
        }
    }
}
