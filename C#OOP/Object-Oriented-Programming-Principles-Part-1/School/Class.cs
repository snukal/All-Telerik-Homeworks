namespace SchoolProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class : IComment
    {
        private const string PlaceholdersForComments = "Comment: {0}";
        private const string ExeptionUniqueTextIdentifiersErrorMessage = "The text identifier cannot be null or empty!";
        private string uniqueTextIdentifiers;
        private ICollection<Teacher> teachers;
        private ICollection<Student> students;
        private ICollection<string> comments;

        public Class(string uniqueTextIdentifiers, List<Student> students, List<Teacher> teachers)
        {
            this.UniqueTextIdentifiers = uniqueTextIdentifiers;
            this.students = students;
            this.teachers = teachers;
        }

        public string UniqueTextIdentifiers
        {
            get
            {
                return this.uniqueTextIdentifiers;
            }
            
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExeptionUniqueTextIdentifiersErrorMessage);
                }

                this.uniqueTextIdentifiers = value;
            }
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }

        public string GetComment(ICollection<string> getComment)
        {
            StringBuilder commentsToString = new StringBuilder();

            foreach (var item in getComment)
            {
                commentsToString.Append(string.Format(PlaceholdersForComments, item));
            }

            return commentsToString.ToString();
        }
    }
}
