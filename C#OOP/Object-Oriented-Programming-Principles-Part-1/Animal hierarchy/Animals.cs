namespace Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animals : ISound
    {
        private const string ExeptionMessageForName = "Name cannot be null!";
        private const string ExeptionMessageForSex = "Sex cannot be null!";
        private const string ExeptionMessageForAge = "Age cannot be null or negative value!";
        private string name;
        private int age;

        public Animals(int setAge, string setName, Gender setGender)
        {
            this.Gender = setGender;
            this.Name = setName;
            this.Age = setAge;
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
                    throw new ArgumentException(ExeptionMessageForName);
                }

                this.name = value;
            }
        }

        public Gender Gender { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExeptionMessageForAge);
                }

                this.age = value;
            }
        }

        public static double CalculateAverageAge(IEnumerable<Animals> animals)
        {
            return animals.Average(a => a.Age);
        }

        public abstract string ProduceSound();
    }
}
