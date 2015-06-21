namespace SchoolProblem
{
    using System;

    public class Discipline : IComment
    {
        private const string ExceptionTextNameNull = "Name cannot be null!";
        private const string ExceptionTextNameOneChar = "Name cannot consist one letter!";
        private const string ExceptionTextLectures = "Number of lectures cannot be null!";
        private const string ExceptionTextExercises = "Number of exercises cannot be null!";
        private const int ValueForExeptionOfLectures = 0;
        private const int ValueForExeptionOfExercises = 0;

        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numLect, int numEser)
        {
            this.Name = name;
            this.NumberOfLectures = this.numberOfLectures;
            this.NumberOfExercises = this.numberOfExercises;
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                if (value <= ValueForExeptionOfExercises)
                {
                    throw new ArgumentException(ExceptionTextExercises);
                }

                this.numberOfExercises = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < ValueForExeptionOfLectures)
                {
                    throw new ArgumentException(ExceptionTextExercises);
                }

                this.NumberOfLectures = value;
            }
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
                    throw new ArgumentException(ExceptionTextNameNull);
                }

                if (value.Length <= 1)
                {
                    throw new ArgumentException(ExceptionTextNameOneChar);
                }

                this.name = this.Name;
            }
        }
    }
}
