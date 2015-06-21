namespace SchoolProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School 
    {
        private List<Class> classes;

        public List<Class> Classes
        {
            get
            {
                return new List<Class>(this.classes);
            }
        }

        public void AddingClass(Class newClass)
        {
            this.classes.Add(newClass);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var course in this.classes)
            {
                sb.Append(string.Format("{0}", course));
            }

            return sb.ToString();
        }
    }
}
