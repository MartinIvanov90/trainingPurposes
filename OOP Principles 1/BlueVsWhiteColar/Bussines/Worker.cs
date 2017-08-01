using System;
using BlueVsWhiteColar.Abstract;

namespace BlueVsWhiteColar.Bussines
{
    class Worker : Human
    {

        private double weekSalary;
        private int workHoursPerDay;

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentNullException($"Salary cannot be negative or null. This is not a charity!");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException($"Work hours cannot be negative value, though a zero would be nice!");
                }
                this.workHoursPerDay = value;
            }
        }
        public double MoneyPerHourProp
        {
            get
            {
                return MoneyPerHour();
            }
        }

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay) : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private double MoneyPerHour()
        {
            double result = this.weekSalary/(5 * this.workHoursPerDay);
            return result;
        }

    }
}
