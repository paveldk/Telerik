namespace Human
{
    using System;

    public class Worker : Human
    {
        private const int WorkDays = 5;
        private float weekSalary;
        private float workHoursPerDay;

        public Worker(string sname, string sfamily, float salary, float hoursPerDay)
            : base(sname, sfamily)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hoursPerDay;
        }

        public float WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Salary must be positive number!");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }

        public float WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                // Can't work more than 12 hours!
                if (value < 0 || value > 12) 
                {
                    Console.WriteLine("Work hours must be between 1 and 12!");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public float MoneyPerHour()
        {
            float result = 0;

            /* we have his/her week salary. To get day salary we must delete on working days
             * They're usualy five, so we gonna use this number(as constant) and then devide
             * by workhours per day
             * */
            result = (this.WeekSalary / WorkDays) / this.WorkHoursPerDay;
            return result;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.MoneyPerHour();
        }
    }
}
