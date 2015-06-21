namespace Range_Exceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private const string ExceptionMessageForInvalidRange = "{0} should be in range [{1} to {2}}";

        public InvalidRangeException(T start, T end, Exception exception) : base(string.Format(ExceptionMessageForInvalidRange, start.GetType().Name, start, end), exception) // ApplicationException have 3 more constructors for overload 
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(T start, T end) : this(start, end, null) // additionall constructor for getting the start and end 
        {
        }

        public T Start { get; set; }

        public T End { get; set; }
    }
}
