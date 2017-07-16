using System;

namespace DefiningClassesPartOne
{
    class GSMCallHistoryTest
    {
        private GSM gsmDevice;
        public GSMCallHistoryTest()
        {
            gsmDevice = new GSM("One M8", "HTC");
        }

        public void GSMTester()
        {
            this.gsmDevice.AddCallToList(new Calls("+359 86 4 121223", new DateTime(), new TimeSpan(0,5,1), 0.5));
            this.gsmDevice.AddCallToList(new Calls("+359 86 5 999999", new DateTime(), new TimeSpan(0, 5, 1), 0.5));
            this.gsmDevice.AddCallToList(new Calls("+359 86 6 434343", new DateTime(), new TimeSpan(0, 9, 1), 0.5));
            this.gsmDevice.AddCallToList(new Calls("+359 86 5 888888", new DateTime(), new TimeSpan(0, 5, 1), 0.5));
            this.gsmDevice.AddCallToList(new Calls("+359 86 6 777777", new DateTime(), new TimeSpan(0, 5, 1), 0.5));
            this.gsmDevice.AddCallToList(new Calls("+359 86 5 665566", new DateTime(), new TimeSpan(0, 5, 1), 0.5));
            this.gsmDevice.AddCallToList(new Calls("+359 86 6 555555", new DateTime(), new TimeSpan(0, 6, 1), 0.5));
            gsmDevice.PrintCallHistory();
            gsmDevice.PrintTotalPrice();
            gsmDevice.DeleteLongestCallFromList();
            Console.WriteLine("---------");
            gsmDevice.PrintCallHistory();
            gsmDevice.PrintTotalPrice();
            Console.WriteLine("---------");
            gsmDevice.DeleteLongestCallFromList();
            gsmDevice.PrintCallHistory();
            gsmDevice.PrintTotalPrice();
            gsmDevice.ClearCallHistory();
            gsmDevice.PrintCallHistory();
        }
        public GSM GsmDevice
        {
            get
            {
                return this.gsmDevice;
            }
            set
            {
                this.gsmDevice = value;
            }
        }
    }
}
