using System;

namespace DefiningClassesPartOne
{
    class Battery
    {
        private string batteryModel;
        private double batteryHoursIdle;
        private double batteryHoursTalk;
        private BatteryType batteryType;


        public Battery(BatteryType batteryType, string batteryModel = null, double batteryHoursIdle = 0, double batteryHoursTalk = 0)
        {
            this.BatteryType = batteryType;
            this.batteryModel = batteryModel;
            this.batteryHoursIdle = batteryHoursIdle;
            this.batteryHoursTalk = batteryHoursTalk;
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                this.batteryModel = value;
            }
        }
        public double BatteryHoursIdle
        {
            get
            {
                return this.batteryHoursIdle;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Batterie's idle hours cannot be bellow 0!");
                }
                else
                {
                    this.batteryHoursIdle = value;
                }
            }
        }
        public double BatteryHoursTalk
        {
            get
            {
                return this.batteryHoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Batterie's talk hours cannot be bellow 0!");
                }
                else
                {
                    this.batteryHoursTalk = value;
                }
            }
        }
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
    }
}
