using System;

namespace DefiningClassesPartOne
{
    class Calls
    {
        //It should contain date, time, dialled phone number and duration(in seconds)
        private readonly string phoneNumber;
        private readonly DateTime callDateTime;
        private readonly TimeSpan callSpan;
        private readonly double callPrice;
        //constructor that takes all the parameters cuz a call must have 'em all
        public Calls(string phoneNumber,DateTime callDateTime, TimeSpan callDuration, double callPrice)
        {
            this.phoneNumber = phoneNumber;
            this.callDateTime = callDateTime;
            this.callSpan = callDuration;
            this.callPrice = callPrice;
        }

        public double totalCallsPrice()
        {
            return this.callSpan.TotalMinutes * this.callPrice;
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
        }
        public DateTime CallDateTime
        {
            get
            {
                return this.callDateTime;
            }
        }
        public TimeSpan CallSpan
        {
            get
            {
                return this.callSpan;
            }
        }
        public double CallPrice
        {
            get
            {
                return this.callPrice;
            }
        }
    }
}
