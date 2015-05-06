namespace Students_and_workers
{
    using System;
    using System.Linq;

    public class Worker : Human
    {
        private const int NullValueWorkHours = 0;
        private const int NullValueWeeksSalary = 0;
        private const string TextExeptionOfWorksHoursPerDay = "Work hours per day cannot be null or less!";
        private const string TextExceptionOfWeekSalary = "Week salari cannot be null or less!";
        private decimal weekSalary;
        private int workHoursPerDay;
        private decimal moneyPerHour;

        public Worker(string firstName, string lastName, int workHoursPerDay, int weekSalary) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value <= NullValueWorkHours)
                {
                    throw new ArgumentException(TextExeptionOfWorksHoursPerDay);
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value <= NullValueWeeksSalary)
                {
                    throw new ArgumentException(TextExceptionOfWeekSalary);
                }

                this.weekSalary = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / 5) / this.WorkHoursPerDay;
        }
    }
}
