namespace GSMove
{
    using System;

    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialedNumber;
        private int duration;



        public Call(DateTime date, DateTime time, string dialed, int duration)
        {
            this.date = date;
            this.time = time;
            this.dialedNumber = dialed;
            this.duration = duration;
        }
    }
}