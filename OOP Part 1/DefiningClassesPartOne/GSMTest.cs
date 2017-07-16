using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class GSMTest
    {
        private GSM[] listOfDevices;
        private int deviceListCount;


        public GSMTest(int howManyDevices)
        {
            this.deviceListCount = howManyDevices;
            this.listOfDevices = new GSM[howManyDevices];
            for(int i = 0; i < howManyDevices; i++)
            {
                listOfDevices[i] = new GSM($"[unnamedDevice{i}]", $"[unnamedModel{i}]");
            }
        }

        public void PrintDevicesInfo()
        {
            for (int i = 0; i < deviceListCount; i++)
            {
                Console.WriteLine(this.listOfDevices[i].ToString());
            }
        }
        public void PrintIphoneInfo()
        {
            Console.WriteLine(GSM.IPhone4S); 
        }
    }
}
