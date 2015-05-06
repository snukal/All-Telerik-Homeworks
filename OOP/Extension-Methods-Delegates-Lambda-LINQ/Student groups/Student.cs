namespace Student_groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        private string firstName;

        private string lastName;

        private string fN;

        private string tel;

        private string email;

        private List<int> marks;

        private int groupNumber;

        public Student(string firstName, string lastName, string fN, string tel, string email, int groupNumber, List<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
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
                    throw new ArgumentException("Please enter text!");
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please enter text!");
                }
                this.lastName = value;
            }
        }

        public string FN 
        {
            get 
            {
                return this.fN;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please enter text!");
                }
                this.fN = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please eter correct Tel number!");
                }

                this.tel = value;
            }

        }
        public string Email 
        {
            get
            {
                return this.email;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please enter a valid Email address!");
                }
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            private set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("Please add any marks!");  
                }
                this.marks = value;
            }

        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Please enter correct Group number!");
                }
                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nFaculty number: {2}\n" +
                                 "Group number: {3}\nMarks: {4}\nPhone: {5}\nEmail: {6}",
                this.firstName, this.lastName, this.fN, this.groupNumber,
                string.Join(", ", this.marks), this.tel, this.email);
        }
    }
}
