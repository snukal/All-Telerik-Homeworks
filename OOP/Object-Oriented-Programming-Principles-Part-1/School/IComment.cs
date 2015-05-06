namespace SchoolProblem
{
    using System.Collections.Generic;

    public interface IComment
    {
        void AddComment(string comment);

        string GetComment(ICollection<string> getComment);
    }
}
