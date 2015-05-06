namespace SchoolProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person, IComment
    {
        private const string PlaceholdersTeacherDisciplines = "{0} {1} {2}";
        private const string ExceprionListOfDisciplines = "List Of Disciplines cannot ne null!";
        private List<Discipline> listOfDiscipline = new List<Discipline>();

        public Teacher(string name, List<Discipline> listOfDisciplines) : base(name)
        {
            this.Name = name;
            this.ListOfDisciplines = this.listOfDiscipline;
        }

        public List<Discipline> ListOfDisciplines
        {
            get
            {
                return new List<Discipline>(this.listOfDiscipline);
            }

            private set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("Disciplines cannnot be negative or zero");
                }

                this.listOfDiscipline = value;
            }
        }

        public string PrintTeachersDiscipline(List<Discipline> disciplines)
        {
            StringBuilder teachersDisciplines = new StringBuilder();

            foreach (var discipline in disciplines)
            {
                teachersDisciplines.Append(string.Format(PlaceholdersTeacherDisciplines, discipline.Name, discipline.NumberOfExercises, discipline.NumberOfLectures));
            }

            return teachersDisciplines.ToString();
        }
    }
}
