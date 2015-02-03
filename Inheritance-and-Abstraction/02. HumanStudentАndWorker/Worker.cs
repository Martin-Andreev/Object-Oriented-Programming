namespace HumanStudentАndWorker
{
    using System;

    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary cannot be negative number!");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 8)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day must be in range 0...8!");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            int workDays = 5;
            double payment = this.weekSalary / (this.workHoursPerDay * workDays);

            return payment;
        }
    }
}
