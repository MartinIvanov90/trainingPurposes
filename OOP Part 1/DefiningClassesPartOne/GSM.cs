using System;
using System.Collections.Generic;

namespace DefiningClassesPartOne
{
    class GSM
    {
        private readonly string model;
        private readonly string manufacturer;
        private double price;
        private string owner;
        private static GSM iPhone4S;
        private Battery battery;
        private Display display;
        private List<Calls> callsList;

        //basic constructor
        static GSM()
        {
            iPhone4S = new GSM("iPhone4s", "Apple");
            iPhone4S.price = 100000.00;
            iPhone4S.owner = "Not Me";
            iPhone4S.battery = new Battery(BatteryType.LiPol, "refferenceModel", 1.1, 0.1);
            iPhone4S.display = new Display(3, 2);
        }
        public GSM(string model, string manufacturer)
        {
            //mandatory fields
            this.model = model;
            this.manufacturer = manufacturer;
            this.Price = 0;
            this.Owner = null;
            this.CallsList = new List<Calls>();
            this.battery = new Battery(BatteryType.unknown);
            this.display = new Display();
        }
        public GSM(string model, string manufacturer, double price, string owner, 
                    Battery battery, Display display, List<Calls> callsList)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
            this.callsList = callsList;
        }
        //Returns the full info of the GSMz. Display and Battery must be initialized!
        public override string ToString()
        {
            //TODO: Complete the return info
            return ($"model: {this.model}\nmanufacturer: {this.manufacturer}\nprice: {this.price:F2}\n" +
                $"owner: {this.owner}\nbattery model: {this.battery.BatteryModel}\n" +
                $"battery type: {this.battery.BatteryType}\nbattery hours idle: {this.battery.BatteryHoursIdle}\n" +
                $"battery hours of talk: {this.battery.BatteryHoursTalk}\ndisplay size: {this.display.DisplaySize}\n" +
                $"display colors: {this.display.DisplayColors}\n");
        }
        public void AddCallToList(Calls call)
        {
                this.callsList.Add(call);
        }
        public void DelCallFromList(int callIndex)
        {
            this.callsList.RemoveAt(callIndex);
        }
        public void DeleteLongestCallFromList()
        {
            int index = 0;
            int callListLength = callsList.Count;
            double intermediateCounter = callListLength !=0 ? callsList[0].CallSpan.TotalMinutes : 0;
            for (int i = 0; i< callListLength - 1; i++)
            {
                if(intermediateCounter < callsList[i + 1].CallSpan.TotalMinutes)
                {
                    index = i + 1;
                    intermediateCounter = callsList[i + 1].CallSpan.TotalMinutes;
                }

            }
            if(intermediateCounter != 0)
            {
                DelCallFromList(index);
            }

        }
        public void ClearCallHistory()
        {
            this.callsList.Clear();
        }
        public void PrintCallHistory()
        {
            int counter = 0;
            foreach(Calls call in callsList)
            {
                
                Console.WriteLine($"{counter}\nPhone number: {call.PhoneNumber}\n" +
                    $"Duration: {call.CallSpan.Hours:F2}:{call.CallSpan.Minutes:F2}:{call.CallSpan.Seconds:F2}\n" +
                    $"Date: {call.CallDateTime.Year}/{call.CallDateTime.Month}/{call.CallDateTime.Day}\n" +
                    $"Price: {call.CallPrice}");
                counter++;
            }
        }
        public void PrintTotalPrice()
        {
            double total = 0;
            foreach (Calls call in callsList)
            {

                total += call.CallPrice*Math.Ceiling(call.CallSpan.TotalMinutes);
            }
            Console.WriteLine($"{total:F2}");
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (this.price < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public List<Calls> CallsList
        {
            get
            {
                return this.callsList;
            }
            private set
            {
                this.callsList = value;
            }
            //calls lists cant be swept between devices
        }
        public static string IPhone4S
        {
            get
            {

                return iPhone4S.ToString();
            }
        }

    }
}
